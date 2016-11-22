using System;
using System.Windows.Forms;
using System.ServiceModel;
using System.Drawing;
using MMManager.GameObjects;
using MMManager.CommInterfaces;
using MMManager.PersistanceObjects;
namespace MMManager
{

    public partial class MMMChatClient : Form, IChatService, IMessageRelay
    {
        private int instanceNumber; // The instance number of this application.
        private TTTProfile tttProfile = new TTTProfile();
       // private SharedTicTacToeBoardData theTicTacToeBoardData; //Contains all neeeded
        private delegate void UserJoined(string name);
        private delegate void UserSendMessage(string name, string message);
        private delegate void UserLeft(string name);
        public delegate void UserTicTacToeMessage(string gameName, PlayerClass player, SharedTicTacToeBoardData theBoard);

        private static event UserJoined NewJoin;
        private static event UserSendMessage MessageSent;
        private static event UserLeft RemoveUser;
        private static event UserTicTacToeMessage TicTacToeMessageSent;

        private string userName;
        public IChatChannel channel; //Shared for sending messages as call back.
        private DuplexChannelFactory<IChatChannel> factory;
        public MMMChatClient()
        {
            InitializeComponent();
            channel = null;
            factory = null;
            this.AcceptButton = btnLogin;

        }
        public MMMChatClient(int InstanceNumber):this()
        {
            instanceNumber = InstanceNumber;// Assign the instance number
        }
        public MMMChatClient(string userName):this()
        {
            this.userName = userName;
            if (userName != null)
            {
                txtUserName.Text = userName;
                //PlayerClass p = new PlayerClass() { PlayerName = userName, PlayerScore = 0, PlayerStatus = "Waiting...", PlayerSymbol = btnSymbolChoice.ImageIndex };
                MMManager.GameControls.TicTacToePlayer p = new GameControls.TicTacToePlayer() { PlayerName = userName, PlayerScore = 0, PlayerStatus = "Waiting...", PlayerSymbol = btnSymbolChoice.ImageIndex };
                ticTacToeBoard1.GameInfo.Player = p;
                //Need Computer or Game Name so we can filter
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtUserName.Text.Trim()))
            {
                try
                {
                    btnLogin.Enabled = false;
                    btnLogin.Text = "Connecting..";
                    NewJoin += new UserJoined(MMMChatClient_NewJoin);
                    MessageSent += new UserSendMessage(MMMChatClient_MessageSent);
                    RemoveUser += new UserLeft(MMMChatClient_RemoveUser);
                    TicTacToeMessageSent += new UserTicTacToeMessage(MMMChatClient_TicTacToeMessageSent);
                    channel = null;
                    this.userName = txtUserName.Text.Trim();
                    //ticTacToeBoard1.GameInfo.Player.PlayerName = this.userName; // Assign Player Name when Logging in.
                    //ticTacToeBoard1.GameInfo.GameName = this.userName + "'s Game"; // Default to something.. but will be overwritten in GameInfo if needed.

                    //PlayerClass p = new PlayerClass() { PlayerName = userName, PlayerScore = 0, PlayerStatus = "Waiting...", PlayerSymbol = btnSymbolChoice.ImageIndex };
                    MMManager.GameControls.TicTacToePlayer p = new GameControls.TicTacToePlayer() { PlayerName = userName, PlayerScore = 0, PlayerStatus = "Waiting...", PlayerSymbol = btnSymbolChoice.ImageIndex };
                    ticTacToeBoard1.GameInfo.Player = p;
                    InstanceContext context = new InstanceContext(new MMMChatClient(txtUserName.Text.Trim()));
                    //InstanceContext context = new InstanceContext(this);
                    factory =  new DuplexChannelFactory<IChatChannel>(context, "ChatEndPoint");

                    channel = factory.CreateChannel();
                    IOnlineStatus status = channel.GetProperty<IOnlineStatus>();
                    status.Offline += new EventHandler(Offline);
                    status.Online += new EventHandler(Online);                    
                    channel.Open();                    


                    //All below should be in Online Event handler
                    //channel.Join(this.userName);
                    grpMessageWindow.Enabled = true;
                    grpUserList.Enabled = true;
                    channel.Join(this.userName);
                    grpUserCredentials.Enabled = false;
                    //gbTicTacToe.Enabled = true; //Enable TicTacToe                    
                    channel.InitializeMesh(); //Doesn't do anything..
                    this.AcceptButton = btnSend;
                    rtbMessages.AppendColorText("*****************************WELCOME to the Chat Application*****************************\r\n", Color.Green);
                    txtSendMessage.Select();
                    txtSendMessage.Focus();
                    if(ticTacToeBoard1.ServiceProvider == null)
                        ticTacToeBoard1.ServiceProvider = this; // Set this form to be the service provider for the game.
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

  

        void MMMChatClient_RemoveUser(string name)
        {
            try
            {
                rtbMessages.AppendColorText("\r\n" + name + " left at " + DateTime.Now.ToString() + "\r\n", Color.Green);
                lstUsers.Items.Remove(name);
                PlayerClass p = new PlayerClass() { PlayerName = name };
                ticTacToeBoard1.GameInfo.Players.LeaveGame(p);
            }
            catch (Exception ex)
            {
                System.Diagnostics.Trace.WriteLine(ex.ToString());
            }
        }

        void MMMChatClient_MessageSent(string name, string message)
        {
            if (!lstUsers.Items.Contains(name))
            {
                lstUsers.Items.Add(name);
            }
            
            //rtbMessages.AppendText( name + " says: " + message + "\r\n");
            rtbMessages.AppendColorText(name + " says: " + message + "\r\n", Color.Blue);
           // rtbMessages.PrependColorText(name + " says: ", Color.Goldenrod);
           // rtbMessages.PrependColorText(message + "\r\n", Color.Black);
        }

        void MMMChatClient_NewJoin(string name)
        {
            rtbMessages.AppendColorText("\r\n" + name + " joined at: [" + DateTime.Now.ToString() + "]\r\n", Color.Red);

            lstUsers.Items.Add(name);
        }

        void Online(object sender, EventArgs e)
        {
            btnLogin.Text = "Online";
            rtbMessages.AppendColorText("\r\nOnline: " + this.userName + "\r\n", Color.Green);
            //Enable TicTacToe    
        }

        void Offline(object sender, EventArgs e)
        {
            btnLogin.Text = "Offline";
            rtbMessages.AppendColorText("\r\nOffline: " + this.userName + "\r\n", Color.Green);
        }

        /// <summary>
        /// Event Handler for All TTT Messages.
        /// All sessions connected receive all messages.
        /// </summary>
        /// <param name="name">The User Name</param>
        /// <param name="theBoard">The Current Board</param>
        private void MMMChatClient_TicTacToeMessageSent(string gameName, PlayerClass player, SharedTicTacToeBoardData theSharedBoardData)
        {
            propertyGrid1.SelectedObject = theSharedBoardData; // For Debugging Stuff.. will be removed.
            ticTacToeBoard1.ReceiveMessage(gameName, player, theSharedBoardData);
        }
        #region IChatService Members

        public void Join(string memberName)
        {            
            if (NewJoin != null)
            {
                NewJoin(memberName);
            }
        }

        public new void Leave(string memberName)
        {
            if (RemoveUser != null)
            {
                RemoveUser(memberName);
            }
        }

        public void SendMessage(string memberName, string message)
        {
            if (MessageSent != null)
            {
                MessageSent(memberName, message);
            }
        }
  
        public void TicTacToeMessage(string gameName, PlayerClass player, SharedTicTacToeBoardData generatedBoardData)
        {
            if (TicTacToeMessageSent != null)
            {
                TicTacToeMessageSent(gameName, player, generatedBoardData);
            }
        }

        public void InitializeMesh()
        {
            //do nothing
        }
        #endregion

        private void btnSend_Click(object sender, EventArgs e)
        {
            channel.SendMessage(this.userName, txtSendMessage.Text.Trim());
            txtSendMessage.Clear();
            txtSendMessage.Select();
            txtSendMessage.Focus();
        }

        private void MMMChatClient_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                tttProfile.SaveSettings(instanceNumber); // Save Profile Settings.
                NewJoin = null;
                MessageSent = null;
                RemoveUser = null;
                TicTacToeMessageSent = null;

                if (channel != null)
                {
                    channel.Leave(this.userName); //Removes user from other members list.
                    channel.Close();
                }
                if (factory != null)
                {
                    factory.Close();
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }
        /// <summary>
        /// Function to Initiate the Game and board.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStartTicTacToe_Click(object sender, EventArgs e)
        {
            ////Can Start a Game
            //if (theTicTacToeBoardData != null)
            //{
            //    if (theTicTacToeBoardData.State == SharedTicTacToeBoardData.GameState.Playing)
            //        return;
            //}
            //if (btnStartTicTacToe.Text.StartsWith("Start"))
            //{
            //    theTicTacToeBoardData= new SharedTicTacToeBoardData();
            //    //theTicTacToeBoard.FirstName = this.userName;
            //    theTicTacToeBoardData.State = SharedTicTacToeBoardData.GameState.Waiting;
            //    theTicTacToeBoardData.Message = SharedTicTacToeBoardData.MessageCode.Start;
            //    channel.TicTacToeMessage(ticTacToeBoard1.GameInfo.GameName, ticTacToeBoard1.GameInfo.Player.PlayerName, theTicTacToeBoardData);
            //    btnStartTicTacToe.Text = "Waiting..";
            //    // btnStartTicTacToe.Enabled = false;
            //}
            //else //Accept
            //{
            //    if (theTicTacToeBoardData != null)
            //    {
            //       // theTicTacToeBoard.SecondName = this.userName;
            //        theTicTacToeBoardData.Message = SharedTicTacToeBoardData.MessageCode.Join;
            //        theTicTacToeBoardData.State = SharedTicTacToeBoardData.GameState.Playing;
            //       // btnStartTicTacToe.Text = "Playing: " + theTicTacToeBoard.FirstName;
            //        channel.TicTacToeMessage(ticTacToeBoard1.GameInfo.GameName, ticTacToeBoard1.GameInfo.Player.PlayerName, theTicTacToeBoardData);
            //    }
            //}

        }


        private void txtUserName_TextChanged(object sender, EventArgs e)
        {
            if (txtUserName.Text.Trim().Length > 0)
            {
                this.userName = txtUserName.Text.Trim();
                tttProfile.UserName = this.userName;
            }
        }

        private void MMMChatClient_Load(object sender, EventArgs e)
        {
            string version = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString();
            this.Text += String.Format("  Ver. {0}", version);
            btnSymbolChoice.ImageList = ticTacToeBoard1.ButtonImageList;
            tttProfile = tttProfile.LoadSettings(instanceNumber); // Load Saved Settings or default
            txtUserName.Text = tttProfile.UserName; //Assign UserName
            btnSymbolChoice.ImageIndex = tttProfile.Symbol; //Assign Symbol.
        }

        public void SendTicTacToeMessage(string gameName, PlayerClass player, SharedTicTacToeBoardData generatedBoardData)
        {
            channel.TicTacToeMessage(gameName,player, generatedBoardData); // Send messages using the proper channel
            //Log messages as debugging
            channel.SendMessage(player.PlayerName, generatedBoardData.Message + " " + generatedBoardData.MessageString + " " + generatedBoardData.MessageValue);
        }

        private void ticTacToeBoard1_Load(object sender, EventArgs e)
        {

        }

        private void btnSymbolChoice_Click(object sender, EventArgs e)
        {
            frmSymbolSelector fs = new frmSymbolSelector();
            fs.ShowDialog();
            btnSymbolChoice.ImageIndex = fs.ImageSelected();
            tttProfile.Symbol = btnSymbolChoice.ImageIndex; // Save for Profile
        }
    }
}