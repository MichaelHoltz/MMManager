namespace MMManager

{
    partial class MMMChatClient
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grpMessageWindow = new System.Windows.Forms.GroupBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.txtSendMessage = new System.Windows.Forms.TextBox();
            this.rtbMessages = new System.Windows.Forms.RichTextBox();
            this.grpUserCredentials = new System.Windows.Forms.GroupBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.lblLoginName = new System.Windows.Forms.Label();
            this.grpUserList = new System.Windows.Forms.GroupBox();
            this.lstUsers = new System.Windows.Forms.ListBox();
            this.b9 = new System.Windows.Forms.Button();
            this.b8 = new System.Windows.Forms.Button();
            this.b7 = new System.Windows.Forms.Button();
            this.b6 = new System.Windows.Forms.Button();
            this.b5 = new System.Windows.Forms.Button();
            this.b4 = new System.Windows.Forms.Button();
            this.b3 = new System.Windows.Forms.Button();
            this.b2 = new System.Windows.Forms.Button();
            this.b1 = new System.Windows.Forms.Button();
            this.btnStartTicTacToe = new System.Windows.Forms.Button();
            this.gbTicTacToe = new System.Windows.Forms.GroupBox();
            this.propertyGrid1 = new System.Windows.Forms.PropertyGrid();
            this.grpMessageWindow.SuspendLayout();
            this.grpUserCredentials.SuspendLayout();
            this.grpUserList.SuspendLayout();
            this.gbTicTacToe.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpMessageWindow
            // 
            this.grpMessageWindow.Controls.Add(this.btnSend);
            this.grpMessageWindow.Controls.Add(this.txtSendMessage);
            this.grpMessageWindow.Controls.Add(this.rtbMessages);
            this.grpMessageWindow.Enabled = false;
            this.grpMessageWindow.Location = new System.Drawing.Point(12, 71);
            this.grpMessageWindow.Name = "grpMessageWindow";
            this.grpMessageWindow.Size = new System.Drawing.Size(516, 296);
            this.grpMessageWindow.TabIndex = 0;
            this.grpMessageWindow.TabStop = false;
            this.grpMessageWindow.Text = "Message window";
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(435, 235);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 55);
            this.btnSend.TabIndex = 2;
            this.btnSend.Text = "&Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // txtSendMessage
            // 
            this.txtSendMessage.Location = new System.Drawing.Point(9, 235);
            this.txtSendMessage.Multiline = true;
            this.txtSendMessage.Name = "txtSendMessage";
            this.txtSendMessage.Size = new System.Drawing.Size(408, 55);
            this.txtSendMessage.TabIndex = 1;
            // 
            // rtbMessages
            // 
            this.rtbMessages.Location = new System.Drawing.Point(9, 33);
            this.rtbMessages.Name = "rtbMessages";
            this.rtbMessages.ReadOnly = true;
            this.rtbMessages.Size = new System.Drawing.Size(501, 190);
            this.rtbMessages.TabIndex = 0;
            this.rtbMessages.Text = "";
            // 
            // grpUserCredentials
            // 
            this.grpUserCredentials.Controls.Add(this.btnLogin);
            this.grpUserCredentials.Controls.Add(this.txtUserName);
            this.grpUserCredentials.Controls.Add(this.lblLoginName);
            this.grpUserCredentials.Location = new System.Drawing.Point(12, 25);
            this.grpUserCredentials.Name = "grpUserCredentials";
            this.grpUserCredentials.Size = new System.Drawing.Size(339, 40);
            this.grpUserCredentials.TabIndex = 1;
            this.grpUserCredentials.TabStop = false;
            this.grpUserCredentials.Text = "User credentials:";
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(258, 11);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "&Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(77, 12);
            this.txtUserName.MaxLength = 10;
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(158, 20);
            this.txtUserName.TabIndex = 1;
            // 
            // lblLoginName
            // 
            this.lblLoginName.AutoSize = true;
            this.lblLoginName.Location = new System.Drawing.Point(6, 16);
            this.lblLoginName.Name = "lblLoginName";
            this.lblLoginName.Size = new System.Drawing.Size(65, 13);
            this.lblLoginName.TabIndex = 0;
            this.lblLoginName.Text = "Login name:";
            // 
            // grpUserList
            // 
            this.grpUserList.Controls.Add(this.lstUsers);
            this.grpUserList.Enabled = false;
            this.grpUserList.Location = new System.Drawing.Point(534, 71);
            this.grpUserList.Name = "grpUserList";
            this.grpUserList.Size = new System.Drawing.Size(149, 296);
            this.grpUserList.TabIndex = 2;
            this.grpUserList.TabStop = false;
            this.grpUserList.Text = "Users online";
            // 
            // lstUsers
            // 
            this.lstUsers.FormattingEnabled = true;
            this.lstUsers.Location = new System.Drawing.Point(16, 19);
            this.lstUsers.Name = "lstUsers";
            this.lstUsers.Size = new System.Drawing.Size(127, 264);
            this.lstUsers.TabIndex = 0;
            // 
            // b9
            // 
            this.b9.Location = new System.Drawing.Point(109, 142);
            this.b9.Name = "b9";
            this.b9.Size = new System.Drawing.Size(32, 30);
            this.b9.TabIndex = 31;
            this.b9.Tag = "8";
            this.b9.UseVisualStyleBackColor = true;
            this.b9.Click += new System.EventHandler(this.AllButtonClick);
            // 
            // b8
            // 
            this.b8.Location = new System.Drawing.Point(71, 142);
            this.b8.Name = "b8";
            this.b8.Size = new System.Drawing.Size(32, 30);
            this.b8.TabIndex = 30;
            this.b8.Tag = "7";
            this.b8.UseVisualStyleBackColor = true;
            this.b8.Click += new System.EventHandler(this.AllButtonClick);
            // 
            // b7
            // 
            this.b7.Location = new System.Drawing.Point(33, 142);
            this.b7.Name = "b7";
            this.b7.Size = new System.Drawing.Size(32, 30);
            this.b7.TabIndex = 29;
            this.b7.Tag = "6";
            this.b7.UseVisualStyleBackColor = true;
            this.b7.Click += new System.EventHandler(this.AllButtonClick);
            // 
            // b6
            // 
            this.b6.Location = new System.Drawing.Point(109, 106);
            this.b6.Name = "b6";
            this.b6.Size = new System.Drawing.Size(32, 30);
            this.b6.TabIndex = 28;
            this.b6.Tag = "5";
            this.b6.UseVisualStyleBackColor = true;
            this.b6.Click += new System.EventHandler(this.AllButtonClick);
            // 
            // b5
            // 
            this.b5.Location = new System.Drawing.Point(71, 106);
            this.b5.Name = "b5";
            this.b5.Size = new System.Drawing.Size(32, 30);
            this.b5.TabIndex = 27;
            this.b5.Tag = "4";
            this.b5.UseVisualStyleBackColor = true;
            this.b5.Click += new System.EventHandler(this.AllButtonClick);
            // 
            // b4
            // 
            this.b4.Location = new System.Drawing.Point(33, 106);
            this.b4.Name = "b4";
            this.b4.Size = new System.Drawing.Size(32, 30);
            this.b4.TabIndex = 26;
            this.b4.Tag = "3";
            this.b4.UseVisualStyleBackColor = true;
            this.b4.Click += new System.EventHandler(this.AllButtonClick);
            // 
            // b3
            // 
            this.b3.Location = new System.Drawing.Point(109, 70);
            this.b3.Name = "b3";
            this.b3.Size = new System.Drawing.Size(32, 30);
            this.b3.TabIndex = 25;
            this.b3.Tag = "2";
            this.b3.UseVisualStyleBackColor = true;
            this.b3.Click += new System.EventHandler(this.AllButtonClick);
            // 
            // b2
            // 
            this.b2.Location = new System.Drawing.Point(71, 70);
            this.b2.Name = "b2";
            this.b2.Size = new System.Drawing.Size(32, 30);
            this.b2.TabIndex = 24;
            this.b2.Tag = "1";
            this.b2.UseVisualStyleBackColor = true;
            this.b2.Click += new System.EventHandler(this.AllButtonClick);
            // 
            // b1
            // 
            this.b1.Location = new System.Drawing.Point(33, 70);
            this.b1.Name = "b1";
            this.b1.Size = new System.Drawing.Size(32, 30);
            this.b1.TabIndex = 23;
            this.b1.Tag = "0";
            this.b1.UseVisualStyleBackColor = true;
            this.b1.Click += new System.EventHandler(this.AllButtonClick);
            // 
            // btnStartTicTacToe
            // 
            this.btnStartTicTacToe.Location = new System.Drawing.Point(24, 33);
            this.btnStartTicTacToe.Name = "btnStartTicTacToe";
            this.btnStartTicTacToe.Size = new System.Drawing.Size(130, 26);
            this.btnStartTicTacToe.TabIndex = 33;
            this.btnStartTicTacToe.Text = "Start Tic-Tac-Toe";
            this.btnStartTicTacToe.UseVisualStyleBackColor = true;
            this.btnStartTicTacToe.Click += new System.EventHandler(this.btnStartTicTacToe_Click);
            // 
            // gbTicTacToe
            // 
            this.gbTicTacToe.Controls.Add(this.btnStartTicTacToe);
            this.gbTicTacToe.Controls.Add(this.b1);
            this.gbTicTacToe.Controls.Add(this.b2);
            this.gbTicTacToe.Controls.Add(this.b9);
            this.gbTicTacToe.Controls.Add(this.b3);
            this.gbTicTacToe.Controls.Add(this.b8);
            this.gbTicTacToe.Controls.Add(this.b4);
            this.gbTicTacToe.Controls.Add(this.b7);
            this.gbTicTacToe.Controls.Add(this.b5);
            this.gbTicTacToe.Controls.Add(this.b6);
            this.gbTicTacToe.Enabled = false;
            this.gbTicTacToe.Location = new System.Drawing.Point(689, 71);
            this.gbTicTacToe.Name = "gbTicTacToe";
            this.gbTicTacToe.Size = new System.Drawing.Size(195, 296);
            this.gbTicTacToe.TabIndex = 34;
            this.gbTicTacToe.TabStop = false;
            this.gbTicTacToe.Text = "Network Tic-Tac-Toe";
            // 
            // propertyGrid1
            // 
            this.propertyGrid1.Location = new System.Drawing.Point(884, 20);
            this.propertyGrid1.Name = "propertyGrid1";
            this.propertyGrid1.Size = new System.Drawing.Size(202, 407);
            this.propertyGrid1.TabIndex = 35;
            // 
            // MMMChatClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1126, 556);
            this.Controls.Add(this.propertyGrid1);
            this.Controls.Add(this.gbTicTacToe);
            this.Controls.Add(this.grpUserList);
            this.Controls.Add(this.grpUserCredentials);
            this.Controls.Add(this.grpMessageWindow);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "MMMChatClient";
            this.Text = "MMMChatClient";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MMMChatClient_FormClosing);
            this.grpMessageWindow.ResumeLayout(false);
            this.grpMessageWindow.PerformLayout();
            this.grpUserCredentials.ResumeLayout(false);
            this.grpUserCredentials.PerformLayout();
            this.grpUserList.ResumeLayout(false);
            this.gbTicTacToe.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpMessageWindow;
        private System.Windows.Forms.GroupBox grpUserCredentials;
        private System.Windows.Forms.GroupBox grpUserList;
        private System.Windows.Forms.Label lblLoginName;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.RichTextBox rtbMessages;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox txtSendMessage;
        private System.Windows.Forms.ListBox lstUsers;
        private System.Windows.Forms.Button b9;
        private System.Windows.Forms.Button b8;
        private System.Windows.Forms.Button b7;
        private System.Windows.Forms.Button b6;
        private System.Windows.Forms.Button b5;
        private System.Windows.Forms.Button b4;
        private System.Windows.Forms.Button b3;
        private System.Windows.Forms.Button b2;
        private System.Windows.Forms.Button b1;
        private System.Windows.Forms.Button btnStartTicTacToe;
        private System.Windows.Forms.GroupBox gbTicTacToe;
        private System.Windows.Forms.PropertyGrid propertyGrid1;
    }
}

