using System;
using System.Windows.Forms;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.Drawing;

namespace MMManager
{

    public partial class MMMChatClient : Form, IChatService
    {
        private TicTacToeBoard theTicTacToeBoard; //Contains all neeeded
        private delegate void UserJoined(string name);
        private delegate void UserSendMessage(string name, string message);
        private delegate void UserLeft(string name);
        private delegate void UserTicTacToeMessage(string name, TicTacToeBoard theBoard);

        private static event UserJoined NewJoin;
        private static event UserSendMessage MessageSent;
        private static event UserLeft RemoveUser;
        private static event UserTicTacToeMessage TicTacToeMessageSent;

        private string userName;
        private IChatChannel channel;
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

                    //InstanceContext context = new InstanceContext(new MMMChatClient(txtUserName.Text.Trim()));
                    InstanceContext context = new InstanceContext(this);
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
                    gbTicTacToe.Enabled = true; //Enable TicTacToe                    
                    channel.InitializeMesh(); //Doesn't do anything..
                    this.AcceptButton = btnSend;
                    //rtbMessages.PrependText("\r\n*****************************WELCOME to the Chat Application*****************************");
                    rtbMessages.AppendColorText("*****************************WELCOME to the Chat Application*****************************\r\n", Color.Green);
                    txtSendMessage.Select();
                    txtSendMessage.Focus();
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
                //rtbMessages.AppendText( "\r\n" + name + " left at " + DateTime.Now.ToString() + "\r\n");
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
            //rtbMessages.AppendText("\r\n" + name + " joined at: [" + DateTime.Now.ToString() + "]\r\n" );

            lstUsers.Items.Add(name);
        }

        void Online(object sender, EventArgs e)
        { 
            //rtbMessages.AppendText("\r\nOnline: " + this.userName + "\r\n");
            rtbMessages.AppendColorText("\r\nOnline: " + this.userName + "\r\n", Color.Green);
            gbTicTacToe.Enabled = true; //Enable TicTacToe    
        }

        void Offline(object sender, EventArgs e)
        {
            //rtbMessages.AppendText("\r\nOffline: " + this.userName + "\r\n");
            rtbMessages.AppendColorText("\r\nOffline: " + this.userName + "\r\n", Color.Green);
        }

        /// <summary>
        /// Event Handler for All TTT Messages.
        /// All sessions connected receive all messages.
        /// </summary>
        /// <param name="name">The User Name</param>
        /// <param name="theBoard">The Current Board</param>
        private void MMMChatClient_TicTacToeMessageSent(string name, TicTacToeBoard theBoard)
        {
            propertyGrid1.SelectedObject = theBoard;
            if (name == this.userName)
                return;
            //Message REceived to start TickTack Toe
            if (theBoard.Message == TicTacToeBoard.MessageCode.Start)
            {
                MessageBox.Show(this, "Tic Tac Toe Request");
                btnStartTicTacToe.Text = "Accept";
                theTicTacToeBoard = theBoard;
                theTicTacToeBoard.SecondName = name;
            }
            if (theBoard.Message == TicTacToeBoard.MessageCode.Accept)
            {
                btnStartTicTacToe.Text = "Playing: " + theBoard.SecondName;
                theTicTacToeBoard = theBoard;
                theTicTacToeBoard.SecondName = name;
                theTicTacToeBoard.Message = TicTacToeBoard.MessageCode.Play;
            }

            if (theBoard.Message == TicTacToeBoard.MessageCode.Move)
            {
                Button b = null;
                foreach (Control item in gbTicTacToe.Controls)
                {
                    if (item.Name == theBoard.MessageString)
                    {
                        b = (item as Button);
                        b.Text = theBoard.MessageValue;
                        if (theBoard.MessageValue != "B!") 
                            b.Enabled = false;
                        break;
                    }

                }
                

            }
            if (theBoard.Message == TicTacToeBoard.MessageCode.Reset)
            {
                reset();
            }

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
  
        public void TicTacToeMessage(string memberName, TicTacToeBoard generatedBoard)
        {
            if (TicTacToeMessageSent != null)
            {
                TicTacToeMessageSent(memberName, generatedBoard);
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
        #region ticTacToe
        private void reset()
        {
            b1.Text = "";
            b1.Enabled = true;
            b2.Text = "";
            b2.Enabled = true;
            b3.Text = "";
            b3.Enabled = true;
            b4.Text = "";
            b4.Enabled = true;
            b5.Text = "";
            b5.Enabled = true;
            b6.Text = "";
            b6.Enabled = true;
            b7.Text = "";
            b7.Enabled = true;
            b8.Text = "";
            b8.Enabled = true;
            b9.Text = "";
            b9.Enabled = true;
            btnStartTicTacToe.Text = "Start Tic Tac Toe";
        }


        private void setButtonValue(Button b)
        {
            b.Text = theTicTacToeBoard.Move(Convert.ToInt32(b.Tag), this.userName);
            theTicTacToeBoard.MessageValue = b.Text;
            if (b.Text == "B!")
            {

            }
            else
            {
                b.Enabled = false;
            }

        }

        private void AllButtonClick(object sender, EventArgs e)
        {
            theTicTacToeBoard.Message = TicTacToeBoard.MessageCode.Move;
            theTicTacToeBoard.MessageString = (sender as Button).Name;

            setButtonValue(sender as Button);
            //Button b = (sender as Button);
            //b.Text = theTicTacToeBoard.Move(Convert.ToInt32(b.Tag), this.userName);

            //if (b.Text == "B!")
            //{

            //}
            //else
            //{
            //    b.Enabled = false;
            //}
            channel.TicTacToeMessage(this.userName, theTicTacToeBoard); // Update The other player
            if (theTicTacToeBoard.CheckReset())
            {
                theTicTacToeBoard.Message = TicTacToeBoard.MessageCode.Reset;
                reset();
                channel.TicTacToeMessage(this.userName, theTicTacToeBoard); // Update The other player
            }
        }
        #endregion

        /// <summary>
        /// Function to Initiate the Game and board.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStartTicTacToe_Click(object sender, EventArgs e)
        {
            //Can Start a Game
            if (theTicTacToeBoard != null)
            {
                if (theTicTacToeBoard.State == TicTacToeBoard.GameState.Playing)
                    return;
            }
            if (btnStartTicTacToe.Text.StartsWith("Start"))
            {
                theTicTacToeBoard = new TicTacToeBoard();
                theTicTacToeBoard.FirstName = this.userName;
                theTicTacToeBoard.State = TicTacToeBoard.GameState.Waiting;
                theTicTacToeBoard.Message = TicTacToeBoard.MessageCode.Start;
                channel.TicTacToeMessage(this.userName, theTicTacToeBoard);
                btnStartTicTacToe.Text = "Waiting..";
                // btnStartTicTacToe.Enabled = false;
            }
            else //Accept
            {
                if (theTicTacToeBoard != null)
                {
                    theTicTacToeBoard.SecondName = this.userName;
                    theTicTacToeBoard.Message = TicTacToeBoard.MessageCode.Accept;
                    theTicTacToeBoard.State = TicTacToeBoard.GameState.Playing;
                    btnStartTicTacToe.Text = "Playing: " + theTicTacToeBoard.FirstName;
                    channel.TicTacToeMessage(this.userName, theTicTacToeBoard);
                }
            }

        }

        private void MMMChatClient_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {
            if (txtUserName.Text.Trim().Length > 0)
            {
                this.userName = txtUserName.Text.Trim();
            }
        }
    }
}