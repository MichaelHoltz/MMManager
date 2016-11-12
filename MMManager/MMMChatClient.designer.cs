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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MMMChatClient));
            this.grpMessageWindow = new System.Windows.Forms.GroupBox();
            this.rtbMessages = new MMManager.Controls.RichTextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.txtSendMessage = new System.Windows.Forms.TextBox();
            this.grpUserCredentials = new System.Windows.Forms.GroupBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.lblLoginName = new System.Windows.Forms.Label();
            this.grpUserList = new System.Windows.Forms.GroupBox();
            this.lstUsers = new System.Windows.Forms.ListBox();
            this.propertyGrid1 = new System.Windows.Forms.PropertyGrid();
            this.ticTacToeBoard1 = new MMManager.GameControls.TicTacToeBoard();
            this.grpMessageWindow.SuspendLayout();
            this.grpUserCredentials.SuspendLayout();
            this.grpUserList.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpMessageWindow
            // 
            this.grpMessageWindow.Controls.Add(this.rtbMessages);
            this.grpMessageWindow.Controls.Add(this.btnSend);
            this.grpMessageWindow.Controls.Add(this.txtSendMessage);
            this.grpMessageWindow.Enabled = false;
            this.grpMessageWindow.Location = new System.Drawing.Point(12, 71);
            this.grpMessageWindow.Name = "grpMessageWindow";
            this.grpMessageWindow.Size = new System.Drawing.Size(516, 296);
            this.grpMessageWindow.TabIndex = 0;
            this.grpMessageWindow.TabStop = false;
            this.grpMessageWindow.Text = "Message window";
            // 
            // rtbMessages
            // 
            this.rtbMessages.Location = new System.Drawing.Point(9, 19);
            this.rtbMessages.Name = "rtbMessages";
            this.rtbMessages.ReadOnly = true;
            this.rtbMessages.Size = new System.Drawing.Size(500, 204);
            this.rtbMessages.TabIndex = 3;
            this.rtbMessages.Text = "";
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
            this.txtUserName.MaxLength = 32;
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(158, 20);
            this.txtUserName.TabIndex = 1;
            this.txtUserName.TextChanged += new System.EventHandler(this.txtUserName_TextChanged);
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
            this.grpUserList.Size = new System.Drawing.Size(138, 296);
            this.grpUserList.TabIndex = 2;
            this.grpUserList.TabStop = false;
            this.grpUserList.Text = "Users online";
            // 
            // lstUsers
            // 
            this.lstUsers.FormattingEnabled = true;
            this.lstUsers.Location = new System.Drawing.Point(16, 19);
            this.lstUsers.Name = "lstUsers";
            this.lstUsers.Size = new System.Drawing.Size(113, 264);
            this.lstUsers.TabIndex = 0;
            // 
            // propertyGrid1
            // 
            this.propertyGrid1.Location = new System.Drawing.Point(321, 386);
            this.propertyGrid1.Name = "propertyGrid1";
            this.propertyGrid1.Size = new System.Drawing.Size(366, 306);
            this.propertyGrid1.TabIndex = 35;
            this.propertyGrid1.ToolbarVisible = false;
            // 
            // ticTacToeBoard1
            // 
            this.ticTacToeBoard1.AutoSize = true;
            this.ticTacToeBoard1.Location = new System.Drawing.Point(693, 71);
            this.ticTacToeBoard1.Name = "ticTacToeBoard1";
            this.ticTacToeBoard1.PlayerName = null;
            this.ticTacToeBoard1.ServiceProvider = null;
            this.ticTacToeBoard1.Size = new System.Drawing.Size(456, 492);
            this.ticTacToeBoard1.TabIndex = 36;
            this.ticTacToeBoard1.Load += new System.EventHandler(this.ticTacToeBoard1_Load);
            // 
            // MMMChatClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1275, 727);
            this.Controls.Add(this.ticTacToeBoard1);
            this.Controls.Add(this.propertyGrid1);
            this.Controls.Add(this.grpUserList);
            this.Controls.Add(this.grpUserCredentials);
            this.Controls.Add(this.grpMessageWindow);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MMMChatClient";
            this.Text = "MMMChatClient";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MMMChatClient_FormClosing);
            this.Load += new System.EventHandler(this.MMMChatClient_Load);
            this.grpMessageWindow.ResumeLayout(false);
            this.grpMessageWindow.PerformLayout();
            this.grpUserCredentials.ResumeLayout(false);
            this.grpUserCredentials.PerformLayout();
            this.grpUserList.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpMessageWindow;
        private System.Windows.Forms.GroupBox grpUserCredentials;
        private System.Windows.Forms.GroupBox grpUserList;
        private System.Windows.Forms.Label lblLoginName;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox txtSendMessage;
        private System.Windows.Forms.ListBox lstUsers;
        private System.Windows.Forms.PropertyGrid propertyGrid1;
        private Controls.RichTextBox rtbMessages;
        private GameControls.TicTacToeBoard ticTacToeBoard1;
    }
}

