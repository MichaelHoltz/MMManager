using System;
using System.Windows.Forms;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.Drawing;
using MMManager.GameObjects;
using MMManager.GameInterfaces;
namespace MMManager
{

    public partial class MMMChatClient : Form, IChatService, IMessageRelay
    {
       // private SharedTicTacToeBoardData theTicTacToeBoardData; //Contains all neeeded
        private delegate void UserJoined(string name);
        private delegate void UserSendMessage(string name, string message);
        private delegate void UserLeft(string name);
        public delegate void UserTicTacToeMessage(string gameName, string memberName, SharedTicTacToeBoardData theBoard);

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

        public MMMChatClient(string userName):this()
        {
            this.userName = userName;
            if (userName != null)
            {
                txtUserName.Text = userName;
                ticTacToeBoard1.PlayerName = userName;
                //Need Computer or Game Name so we can filter
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtUserName.Text.Trim()))
            {
                try
                {
                    NewJoin += new UserJoined(MMMChatClient_NewJoin);
                    MessageSent += new UserSendMessage(MMMChatClient_MessageSent);
                    RemoveUser += new UserLeft(MMMChatClient_RemoveUser);
                    TicTacToeMessageSent += new UserTicTacToeMessage(MMMChatClient_TicTacToeMessageSent);
                    channel = null;
                    this.userName = txtUserName.Text.Trim();
                    ticTacToeBoard1.GameInfo.Player.PlayerName = this.userName; // Assign Player Name when Logging in.
                    ticTacToeBoard1.GameInfo.GameName = this.userName + "'s Game"; // Default to something.. but will be overwritten in GameInfo if needed.
                    InstanceContext context = new InstanceContext(new MMMChatClient(txtUserName.Text.Trim()));
                    //InstanceContext context = new InstanceContext(this);
                    factory =  new DuplexChannelFactory<IChatChannel>(context, "ChatEndPoint");

                    channel = factory.CreateChannel();
                    IOnlineStatus status = channel.GetProperty<IOnlineStatus>();
                    status.Offline += new EventHandler(Offline);
                    status.Online += new EventHandler(Online);                    
                    channel.Open();                    
                    //channel.Join(this.userName);
                    grpMessageWindow.Enabled = true;
                    grpUserList.Enabled = true;
                    channel.Join(this.userName);
                    grpUserCredentials.Enabled = false;
                    //gbTicTacToe.Enabled = true; //Enable TicTacToe                    
                    channel.InitializeMesh(); //Doesn't do anything..
                    this.AcceptButton = btnSend;
                    //rtbMessages.PrependText("\r\n*****************************WELCOME to the Chat Application*****************************");
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
            rtbMessages.AppendColorText("\r\nOnline: " + this.userName + "\r\n", Color.Green);
            //Enable TicTacToe    
        }

        void Offline(object sender, EventArgs e)
        {
            rtbMessages.AppendColorText("\r\nOffline: " + this.userName + "\r\n", Color.Green);
        }

        /// <summary>
        /// Event Handler for All TTT Messages.
        /// All sessions connected receive all messages.
        /// </summary>
        /// <param name="name">The User Name</param>
        /// <param name="theBoard">The Current Board</param>
        private void MMMChatClient_TicTacToeMessageSent(string gameName, string memberName, SharedTicTacToeBoardData theSharedBoardData)
        {
            propertyGrid1.SelectedObject = theSharedBoardData; // For Debugging Stuff.. will be removed.
            ticTacToeBoard1.ReceiveMessage(gameName, memberName, theSharedBoardData);
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
  
        public void TicTacToeMessage(string gameName, string memberName, SharedTicTacToeBoardData generatedBoardData)
        {
            if (TicTacToeMessageSent != null)
            {
                TicTacToeMessageSent(gameName, memberName, generatedBoardData);
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
            }
        }

        private void MMMChatClient_Load(object sender, EventArgs e)
        {
            string version = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString();
            this.Text += String.Format("  Ver. {0}", version);
            //ticTacToeBoard1.ServiceProvider = this.channel; // Set this form to be the service provider for the game.
        }

        public void SendTicTacToeMessage(string gameName, string memberName, SharedTicTacToeBoardData generatedBoardData)
        {
            channel.TicTacToeMessage(gameName,memberName, generatedBoardData); // Send messages using the proper channel
        }

        private void ticTacToeBoard1_Load(object sender, EventArgs e)
        {

        }
    }
}