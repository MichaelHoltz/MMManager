using System;
using System.Windows.Forms;
using System.ServiceModel;
using System.ServiceModel.Channels;

namespace MMManager
{

    public partial class MMMChatClient : Form, IChatService
    {
        private TicTacToeBoard theTicTacToeBoard; //Contains all neeeded
        private delegate void UserJoined(string name);
        private delegate void UserSendMessage(string name, string message);
        private delegate void UserLeft(string name);
        //private delegate void UserSendButton(string name, int ButtonNum);
        //private delegate void StartingTicTacToe(string name, TicTacToeBoard theBoard);
        private delegate void UserTicTacToeMessage(string name, TicTacToeBoard theBoard);

        private static event UserJoined NewJoin;
        private static event UserSendMessage MessageSent;
        private static event UserLeft RemoveUser;
        //private static event UserSendButton ButtonSend;
        //private static event StartingTicTacToe StartTicTacToe;
        private static event UserTicTacToeMessage TicTacToeMessageSent;

        private string userName;
        private IChatChannel channel;
        private DuplexChannelFactory<IChatChannel> factory;

        public MMMChatClient()
        {
            InitializeComponent();
            this.AcceptButton = btnLogin;
        }

        public MMMChatClient(string userName)
        {
            this.userName = userName;
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
                   // ButtonSend +=new UserSendButton( MMMChatClient_ButtonSend);
                   // StartTicTacToe += new StartingTicTacToe(MMMChatClient_TicTacToeStarted);
                    TicTacToeMessageSent += new UserTicTacToeMessage(MMMChatClient_TicTacToeMessageSent);
                    channel = null;
                    this.userName = txtUserName.Text.Trim();



                    #region Converting from App.config - Just needed to syncronize!
                    //NetPeerTcpBinding binding = new NetPeerTcpBinding();
                    //binding.Name = "PeerTcpConfig";
                    //binding.Port = 0;
                    //binding.Security.Mode = SecurityMode.None;
                    //binding.Resolver.Mode = System.ServiceModel.PeerResolvers.PeerResolverMode.Auto;

                    //System.ServiceModel.Description.ContractDescription ContractDesc = new System.ServiceModel.Description.ContractDescription("MMManager.IChatService", "MMManager");
                    //ContractDesc.ContractType = typeof(IChatService);
                    //ContractDesc.ConfigurationName = "ChatEndPoint";

                    //System.ServiceModel.Description.ServiceEndpoint ChatEndPoint = new System.ServiceModel.Description.ServiceEndpoint(ContractDesc);
                    //ChatEndPoint.Name = "ChatEndPoint";
                    //ChatEndPoint.Address = new EndpointAddress("net.p2p://localhost/ChatServer");
                    //ChatEndPoint.Binding = binding;
                    //ChatEndPoint.Contract = ContractDesc;
                    //InstanceContext context = new InstanceContext(new MMMChatClient(txtUserName.Text.Trim()));
                    //factory = new DuplexChannelFactory<IChatChannel>(context, "ChatEndPoint");

                    #endregion 

                    InstanceContext context = new InstanceContext(new MMMChatClient(txtUserName.Text.Trim()));
                    factory =  new DuplexChannelFactory<IChatChannel>(context, "ChatEndPoint");
                    channel = factory.CreateChannel();
                    IOnlineStatus status = channel.GetProperty<IOnlineStatus>();
                    status.Offline += new EventHandler(Offline);
                    status.Online += new EventHandler(Online);                    
                    channel.Open();                    
                    channel.Join(this.userName);
                    grpMessageWindow.Enabled = true;
                    grpUserList.Enabled = true;
                
                    grpUserCredentials.Enabled = false;
                    gbTicTacToe.Enabled = true; //Enable TicTacToe                     
                    this.AcceptButton = btnSend;
                    rtbMessages.AppendText("*****************************WEL-COME to Chat Application*****************************\r\n");
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
                rtbMessages.AppendText("\r\n");
                rtbMessages.AppendText(name + " left at " + DateTime.Now.ToString());
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
            rtbMessages.AppendText("\r\n");
            rtbMessages.AppendText(name + " says: " + message);
        }

        void MMMChatClient_NewJoin(string name)
        {
            rtbMessages.AppendText("\r\n");
            rtbMessages.AppendText(name + " joined at: [" + DateTime.Now.ToString() + "]");            
            lstUsers.Items.Add(name);       
        }

        void Online(object sender, EventArgs e)
        {            
            rtbMessages.AppendText("\r\nOnline: " + this.userName);
            gbTicTacToe.Enabled = true; //Enable TicTacToe    
        }

        void Offline(object sender, EventArgs e)
        {
            rtbMessages.AppendText("\r\nOffline: " + this.userName);
        }



        //private void MMMChatClient_ButtonSend(string name, int ButtonNum)
        //{

        //    if (ButtonNum == 1)
        //        setValue(b1);
        //    //AllButtonClick(b1, EventArgs.Empty);
        //    if (ButtonNum == 2)
        //        setValue(b2);
        //    //AllButtonClick(b2, EventArgs.Empty);
        //    if (ButtonNum == 3)
        //        setValue(b3);
        //    //AllButtonClick(b3, EventArgs.Empty);
        //    if (ButtonNum == 4)
        //        setValue(b4);
        //    //AllButtonClick(b4, EventArgs.Empty);
        //    if (ButtonNum == 5)
        //        setValue(b5);
        //    //AllButtonClick(b5, EventArgs.Empty);
        //    if (ButtonNum == 6)
        //        setValue(b6);
        //    //AllButtonClick(b6, EventArgs.Empty);
        //    if (ButtonNum == 7)
        //        setValue(b7);
        //    //AllButtonClick(b7, EventArgs.Empty);
        //    if (ButtonNum == 8)
        //        setValue(b8);
        //    //AllButtonClick(b8, EventArgs.Empty);
        //    if (ButtonNum == 9)
        //        setValue(b9);
        //    //AllButtonClick(b9, EventArgs.Empty);
        //    if (ButtonNum == 10)
        //        reset();
        //    //AllButtonClick(bc, EventArgs.Empty);


        //}
        //private void MMMChatClient_TicTacToeStarted(string name, TicTacToeBoard theBoard)
        //{
        //    //Message REceived to start TickTack Toe
        //    if (name != this.userName)
        //    {
        //        MessageBox.Show("Tic Tac Toe Request");
        //        btnStartTicTacToe.Text = "Accept";
        //        theTicTacToeBoard = theBoard;
        //        theTicTacToeBoard.SecondName = name;
        //    }
        //}
        private void MMMChatClient_TicTacToeMessageSent(string name, TicTacToeBoard theBoard)
        {
            propertyGrid1.SelectedObject = theBoard;
            if (name == this.userName)
                return;
            //Message REceived to start TickTack Toe
            if (theBoard.Message == TicTacToeBoard.MessageCode.Start)
            {
                MessageBox.Show("Tic Tac Toe Request");
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
        //public void SendButton(string memberName, int ButtonNum)
        //{
        //    if (ButtonSend != null)
        //    {
        //        ButtonSend(memberName, ButtonNum);
        //    }
        //}

        //public void RequestStartTicTacToe(string memberName, TicTacToeBoard generatedBoard)
        //{
        //    if (StartTicTacToe != null)
        //    {
        //        StartTicTacToe(memberName, generatedBoard);
        //    }
        //  //  MessageBox.Show("Contract Start Tic Tack Toe");
        //   // throw new NotImplementedException();
        //}
        public void TicTacToeMessage(string memberName, TicTacToeBoard generatedBoard)
        {
            if (TicTacToeMessageSent != null)
            {
                TicTacToeMessageSent(memberName, generatedBoard);
            }
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
                if (channel != null)
                {
                    channel.Leave(this.userName);
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


    }
}