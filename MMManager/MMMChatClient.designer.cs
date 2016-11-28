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
            this.components = new System.ComponentModel.Container();
            this.grpMessageWindow = new System.Windows.Forms.GroupBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.txtSendMessage = new System.Windows.Forms.TextBox();
            this.grpUserCredentials = new System.Windows.Forms.GroupBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.lblLoginName = new System.Windows.Forms.Label();
            this.grpUserList = new System.Windows.Forms.GroupBox();
            this.lstUsers = new System.Windows.Forms.ListBox();
            this.propertyGrid1 = new System.Windows.Forms.PropertyGrid();
            this.lblMySymbol = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.mmManagerTTTButton3 = new MMManager.MMManagerTTTButton();
            this.mmManagerTTTButton1 = new MMManager.MMManagerTTTButton();
            this.mmManagerTTTButton2 = new MMManager.MMManagerTTTButton();
            this.btnSymbolChoice = new MMManager.MMManagerTTTButton();
            this.ticTacToeBoard1 = new MMManager.GameControls.TicTacToeBoard();
            this.rtbMessages = new MMManager.Controls.RichTextBox();
            this.grpMessageWindow.SuspendLayout();
            this.grpUserCredentials.SuspendLayout();
            this.grpUserList.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // grpMessageWindow
            // 
            this.grpMessageWindow.Controls.Add(this.rtbMessages);
            this.grpMessageWindow.Controls.Add(this.btnSend);
            this.grpMessageWindow.Controls.Add(this.txtSendMessage);
            this.grpMessageWindow.Enabled = false;
            this.grpMessageWindow.Location = new System.Drawing.Point(590, 20);
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
            // grpUserCredentials
            // 
            this.grpUserCredentials.Controls.Add(this.btnLogin);
            this.grpUserCredentials.Controls.Add(this.txtUserName);
            this.grpUserCredentials.Controls.Add(this.lblLoginName);
            this.grpUserCredentials.Location = new System.Drawing.Point(152, 20);
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
            this.grpUserList.Location = new System.Drawing.Point(1112, 20);
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
            this.propertyGrid1.Location = new System.Drawing.Point(596, 338);
            this.propertyGrid1.Name = "propertyGrid1";
            this.propertyGrid1.Size = new System.Drawing.Size(366, 306);
            this.propertyGrid1.TabIndex = 35;
            this.propertyGrid1.ToolbarVisible = false;
            // 
            // lblMySymbol
            // 
            this.lblMySymbol.AutoSize = true;
            this.lblMySymbol.Location = new System.Drawing.Point(19, 35);
            this.lblMySymbol.Name = "lblMySymbol";
            this.lblMySymbol.Size = new System.Drawing.Size(58, 13);
            this.lblMySymbol.TabIndex = 39;
            this.lblMySymbol.Text = "My Symbol";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.groupBox1.Controls.Add(this.mmManagerTTTButton3);
            this.groupBox1.Controls.Add(this.mmManagerTTTButton1);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.mmManagerTTTButton2);
            this.groupBox1.Location = new System.Drawing.Point(339, 164);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(226, 204);
            this.groupBox1.TabIndex = 43;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Testing Group Box";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(122, 167);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 45;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(122, 138);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 44;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(339, 84);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(226, 74);
            this.pictureBox1.TabIndex = 43;
            this.pictureBox1.TabStop = false;
            // 
            // mmManagerTTTButton3
            // 
            this.mmManagerTTTButton3.allowClick = true;
            this.mmManagerTTTButton3.AutoFall = false;
            this.mmManagerTTTButton3.ButtonBelow = null;
            this.mmManagerTTTButton3.customEnable = true;
            this.mmManagerTTTButton3.Falling = false;
            this.mmManagerTTTButton3.Location = new System.Drawing.Point(44, 142);
            this.mmManagerTTTButton3.Name = "mmManagerTTTButton3";
            this.mmManagerTTTButton3.Size = new System.Drawing.Size(50, 50);
            this.mmManagerTTTButton3.TabIndex = 47;
            this.mmManagerTTTButton3.Text = "3";
            this.mmManagerTTTButton3.UseVisualStyleBackColor = true;
            this.mmManagerTTTButton3.Click += new System.EventHandler(this.mmManagerTTTButton3_Click);
            // 
            // mmManagerTTTButton1
            // 
            this.mmManagerTTTButton1.allowClick = true;
            this.mmManagerTTTButton1.AutoFall = false;
            this.mmManagerTTTButton1.ButtonBelow = "mmManagerTTTButton3";
            this.mmManagerTTTButton1.customEnable = true;
            this.mmManagerTTTButton1.Falling = false;
            this.mmManagerTTTButton1.Location = new System.Drawing.Point(33, 82);
            this.mmManagerTTTButton1.Name = "mmManagerTTTButton1";
            this.mmManagerTTTButton1.Size = new System.Drawing.Size(50, 50);
            this.mmManagerTTTButton1.TabIndex = 46;
            this.mmManagerTTTButton1.Text = "2";
            this.mmManagerTTTButton1.UseVisualStyleBackColor = true;
            // 
            // mmManagerTTTButton2
            // 
            this.mmManagerTTTButton2.allowClick = true;
            this.mmManagerTTTButton2.AutoFall = false;
            this.mmManagerTTTButton2.ButtonBelow = "mmManagerTTTButton1";
            this.mmManagerTTTButton2.customEnable = true;
            this.mmManagerTTTButton2.Falling = false;
            this.mmManagerTTTButton2.Location = new System.Drawing.Point(22, 19);
            this.mmManagerTTTButton2.Name = "mmManagerTTTButton2";
            this.mmManagerTTTButton2.Size = new System.Drawing.Size(50, 50);
            this.mmManagerTTTButton2.TabIndex = 42;
            this.mmManagerTTTButton2.Text = "1";
            this.mmManagerTTTButton2.UseVisualStyleBackColor = true;
            this.mmManagerTTTButton2.Click += new System.EventHandler(this.mmManagerTTTButton2_Click);
            // 
            // btnSymbolChoice
            // 
            this.btnSymbolChoice.allowClick = true;
            this.btnSymbolChoice.AutoFall = false;
            this.btnSymbolChoice.ButtonBelow = null;
            this.btnSymbolChoice.customEnable = true;
            this.btnSymbolChoice.Falling = false;
            this.btnSymbolChoice.Location = new System.Drawing.Point(83, 20);
            this.btnSymbolChoice.Name = "btnSymbolChoice";
            this.btnSymbolChoice.Size = new System.Drawing.Size(50, 50);
            this.btnSymbolChoice.TabIndex = 38;
            this.btnSymbolChoice.UseVisualStyleBackColor = true;
            this.btnSymbolChoice.Click += new System.EventHandler(this.btnSymbolChoice_Click);
            // 
            // ticTacToeBoard1
            // 
            this.ticTacToeBoard1.AutoSize = true;
            this.ticTacToeBoard1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ticTacToeBoard1.Location = new System.Drawing.Point(22, 84);
            this.ticTacToeBoard1.Name = "ticTacToeBoard1";
            this.ticTacToeBoard1.ServiceProvider = null;
            this.ticTacToeBoard1.Size = new System.Drawing.Size(221, 461);
            this.ticTacToeBoard1.TabIndex = 36;
            this.ticTacToeBoard1.theBoard = null;
            this.ticTacToeBoard1.Load += new System.EventHandler(this.ticTacToeBoard1_Load);
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
            // MMMChatClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1323, 727);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblMySymbol);
            this.Controls.Add(this.btnSymbolChoice);
            this.Controls.Add(this.ticTacToeBoard1);
            this.Controls.Add(this.propertyGrid1);
            this.Controls.Add(this.grpUserList);
            this.Controls.Add(this.grpUserCredentials);
            this.Controls.Add(this.grpMessageWindow);
            this.Name = "MMMChatClient";
            this.Text = "MMMChatClient";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MMMChatClient_FormClosing);
            this.Load += new System.EventHandler(this.MMMChatClient_Load);
            this.grpMessageWindow.ResumeLayout(false);
            this.grpMessageWindow.PerformLayout();
            this.grpUserCredentials.ResumeLayout(false);
            this.grpUserCredentials.PerformLayout();
            this.grpUserList.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private MMManagerTTTButton btnSymbolChoice;
        private System.Windows.Forms.Label lblMySymbol;
        private MMManagerTTTButton mmManagerTTTButton2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private MMManagerTTTButton mmManagerTTTButton1;
        private MMManagerTTTButton mmManagerTTTButton3;
    }
}

