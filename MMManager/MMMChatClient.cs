using System;
using System.Windows.Forms;
using System.ServiceModel;
using System.Drawing;
using MMManager.GameObjects;
using MMManager.CommInterfaces;
using MMManager.GameInterfaces;
using MMManager.PersistanceObjects;
using SpriteLibrary;
namespace MMManager
{

    public partial class MMMChatClient : Form, IChatService, IMessageRelay
    {
        SpriteController MySpriteController;
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
                SetPlayer();
            }
        }
        private void SetPlayer()
        {
            ticTacToeBoard1.GameInfo.Players.Player.ButtonImageList = ticTacToeBoard1.ButtonImageList;
            ticTacToeBoard1.GameInfo.Players.ScoreBoard.ButtonImageList = ticTacToeBoard1.ButtonImageList; 
            ticTacToeBoard1.GameInfo.Players.Player.PlayerName = userName;
            ticTacToeBoard1.GameInfo.Players.Player.PlayerScore = 0;
            ticTacToeBoard1.GameInfo.Players.Player.PlayerStatus = "Waiting..!";
            ticTacToeBoard1.GameInfo.Players.Player.PlayerSymbol = btnSymbolChoice.ImageIndex;
            

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
                    SetPlayer();
                    //InstanceContext context = new InstanceContext(new MMMChatClient(txtUserName.Text.Trim()));
                    InstanceContext context = new InstanceContext(this);
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
                PlayerClass p = (ticTacToeBoard1 as IGame).theBoard.Players.Find(x => x.PlayerName == name); //Have the player that sent the Leave Message
                if (p != null)
                {

                    String GameName = (ticTacToeBoard1 as IGame).theBoard.GameName;
                    (ticTacToeBoard1 as IGame).theBoard.MessageSender = p;
                    (ticTacToeBoard1 as IGame).theBoard.Message = SharedTicTacToeBoardData.MessageCode.LeaveGame;
                    (ticTacToeBoard1 as IGame).theBoard.MessageString = "";
                    (ticTacToeBoard1 as IGame).theBoard.MessageValue = "";
                    (ticTacToeBoard1 as IGame).SendMessage(GameName, p, (ticTacToeBoard1 as IGame).theBoard); //Send the message
                }
                else
                {
                   // MessageBox.Show(name + " left the game by closing the window but can't be found in the board Players by name.");
                }
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
            propertyGrid1.SelectedObject = theSharedBoardData.Players; // For Debugging Stuff.. will be removed.
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
                    try
                    {
                        if (ticTacToeBoard1.GameInfo.GameMode != ControlStatus.Unknown)
                        {
                            //Player Leaving
                            ticTacToeBoard1.theBoard.Message = SharedTicTacToeBoardData.MessageCode.LeaveGame;
                            ticTacToeBoard1.theBoard.MessageSender = ticTacToeBoard1.GameInfo.Player.ToClass();
                            ticTacToeBoard1.theBoard.MessageString = ticTacToeBoard1.GameInfo.GameName;
                            ticTacToeBoard1.SendMessage(ticTacToeBoard1.GameInfo.GameName, ticTacToeBoard1.GameInfo.Player.ToClass(), ticTacToeBoard1.theBoard); // Send message to Everyone

                            if (ticTacToeBoard1.GameInfo.GameMode == ControlStatus.Hosting)
                            {
                                ticTacToeBoard1.theBoard.Message = SharedTicTacToeBoardData.MessageCode.RemoveGame; // Remove the hosted game.
                                ticTacToeBoard1.theBoard.MessageSender = ticTacToeBoard1.GameInfo.Player.ToClass();
                                ticTacToeBoard1.theBoard.MessageString = ticTacToeBoard1.GameInfo.GameName;
                                ticTacToeBoard1.SendMessage(ticTacToeBoard1.GameInfo.GameName, ticTacToeBoard1.GameInfo.Player.ToClass(), ticTacToeBoard1.theBoard); // Send message to Everyone

                            }
                        }
                    }
                    catch
                    {
                        //Ignore errors.
                    }
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
            channel.SendMessage(player.PlayerName, gameName + " " + generatedBoardData.Message + " " + generatedBoardData.MessageString + " " + generatedBoardData.MessageValue);
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

        private void mmManagerTTTButton2_Click(object sender, EventArgs e)
        {
            MMManagerTTTButton btn = (sender as MMManagerTTTButton);
  //          Bitmap b = new Bitmap(btn.TurnToPicture());
//            pictureBox1.BackgroundImage = b;
            
            //pictureBox1.Image = b;
            Sprite OneSprite;
            MySpriteController = new SpriteController(pictureBox1);

            OneSprite = new Sprite(MySpriteController, Properties.Resources.explode, 50, 50, 50);
            OneSprite.SetSize(new Size(50, 50));
            OneSprite.SetName(SpriteNames.explosion.ToString());
            //The function to run when the explosion animation completes
            OneSprite.SpriteAnimationComplete += ExplosionCompletes;
            //SpriteController MySpriteController;

            //btn.explode();
            //if (btn.Top > 0)
            //    btn.Fall(50);
            //else
            //{
            //    btn.Rise(50);
            //}
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //SpriteController MySpriteController;
            //Sprite OneSprite;
            //MySpriteController = new SpriteController(pictureBox1);
            //OneSprite = new Sprite(MySpriteController, Properties.Resources.explode, 50, 50, 50);
            //OneSprite.SetSize(new Size(50, 50));
            //OneSprite.SetName(SpriteNames.explosion.ToString());
            ////The function to run when the explosion animation completes
            //OneSprite.SpriteAnimationComplete += ExplosionCompletes;

            Sprite nSprite = MySpriteController.DuplicateSprite(SpriteNames.explosion.ToString());
            nSprite.PutBaseImageLocation(50, 50);
            nSprite.SetSize(new Size(150, 150));
             nSprite.AnimateOnce(0);
            //nSprite.AnimateJustAFewTimes(1, 10);
        }
        public void ExplosionCompletes(object sender, EventArgs e)
        {
            Sprite tSprite = (Sprite)sender;
            tSprite.Destroy();
            // CountMonsters();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}