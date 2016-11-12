namespace MMManager.GameControls
{
    partial class TicTacToeStartOrJoin
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbAvailableGames = new System.Windows.Forms.ListBox();
            this.lblAvailableGames = new System.Windows.Forms.Label();
            this.btnJoin = new System.Windows.Forms.Button();
            this.btnWatch = new System.Windows.Forms.Button();
            this.btnStartGame = new System.Windows.Forms.Button();
            this.btnCreateRemove = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblGameStatus = new System.Windows.Forms.Label();
            this.rbHost = new System.Windows.Forms.RadioButton();
            this.rbJoinGame = new System.Windows.Forms.RadioButton();
            this.ticTacToePlayers1 = new MMManager.GameControls.TicTacToePlayers();
            this.ticTacToeOptions1 = new MMManager.GameControls.TicTacToeOptions();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbAvailableGames
            // 
            this.lbAvailableGames.FormattingEnabled = true;
            this.lbAvailableGames.Items.AddRange(new object[] {
            "No Games Found"});
            this.lbAvailableGames.Location = new System.Drawing.Point(3, 20);
            this.lbAvailableGames.Name = "lbAvailableGames";
            this.lbAvailableGames.Size = new System.Drawing.Size(181, 82);
            this.lbAvailableGames.TabIndex = 0;
            this.lbAvailableGames.Click += new System.EventHandler(this.lbAvailableGames_Click);
            this.lbAvailableGames.SelectedIndexChanged += new System.EventHandler(this.lbAvailableGames_SelectedIndexChanged);
            // 
            // lblAvailableGames
            // 
            this.lblAvailableGames.AutoSize = true;
            this.lblAvailableGames.Location = new System.Drawing.Point(5, 4);
            this.lblAvailableGames.Name = "lblAvailableGames";
            this.lblAvailableGames.Size = new System.Drawing.Size(86, 13);
            this.lblAvailableGames.TabIndex = 2;
            this.lblAvailableGames.Text = "Available Games";
            // 
            // btnJoin
            // 
            this.btnJoin.Enabled = false;
            this.btnJoin.Location = new System.Drawing.Point(54, 139);
            this.btnJoin.Name = "btnJoin";
            this.btnJoin.Size = new System.Drawing.Size(67, 25);
            this.btnJoin.TabIndex = 3;
            this.btnJoin.Text = "Join";
            this.btnJoin.UseVisualStyleBackColor = true;
            this.btnJoin.Click += new System.EventHandler(this.btnJoin_Click);
            // 
            // btnWatch
            // 
            this.btnWatch.Enabled = false;
            this.btnWatch.Location = new System.Drawing.Point(54, 170);
            this.btnWatch.Name = "btnWatch";
            this.btnWatch.Size = new System.Drawing.Size(67, 25);
            this.btnWatch.TabIndex = 4;
            this.btnWatch.Text = "Watch";
            this.btnWatch.UseVisualStyleBackColor = true;
            this.btnWatch.Click += new System.EventHandler(this.btnWatch_Click);
            // 
            // btnStartGame
            // 
            this.btnStartGame.Enabled = false;
            this.btnStartGame.Location = new System.Drawing.Point(3, 241);
            this.btnStartGame.Name = "btnStartGame";
            this.btnStartGame.Size = new System.Drawing.Size(81, 21);
            this.btnStartGame.TabIndex = 1;
            this.btnStartGame.Text = "Start Game";
            this.btnStartGame.UseVisualStyleBackColor = true;
            this.btnStartGame.Click += new System.EventHandler(this.btnStartGame_Click);
            // 
            // btnCreateRemove
            // 
            this.btnCreateRemove.Location = new System.Drawing.Point(3, 214);
            this.btnCreateRemove.Name = "btnCreateRemove";
            this.btnCreateRemove.Size = new System.Drawing.Size(81, 21);
            this.btnCreateRemove.TabIndex = 0;
            this.btnCreateRemove.Text = "Create Game";
            this.btnCreateRemove.UseVisualStyleBackColor = true;
            this.btnCreateRemove.Click += new System.EventHandler(this.btnCreateRemove_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(54, 108);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(67, 25);
            this.btnRefresh.TabIndex = 5;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.ticTacToeOptions1);
            this.panel1.Controls.Add(this.btnCreateRemove);
            this.panel1.Controls.Add(this.btnStartGame);
            this.panel1.Location = new System.Drawing.Point(218, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(162, 267);
            this.panel1.TabIndex = 10;
            this.panel1.Visible = false;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.lbAvailableGames);
            this.panel2.Controls.Add(this.lblAvailableGames);
            this.panel2.Controls.Add(this.btnJoin);
            this.panel2.Controls.Add(this.btnWatch);
            this.panel2.Controls.Add(this.btnRefresh);
            this.panel2.Location = new System.Drawing.Point(386, 25);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(197, 263);
            this.panel2.TabIndex = 11;
            this.panel2.Visible = false;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.ticTacToePlayers1);
            this.panel3.Controls.Add(this.lblGameStatus);
            this.panel3.Location = new System.Drawing.Point(5, 25);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(207, 270);
            this.panel3.TabIndex = 12;
            // 
            // lblGameStatus
            // 
            this.lblGameStatus.AutoSize = true;
            this.lblGameStatus.Location = new System.Drawing.Point(10, 18);
            this.lblGameStatus.Name = "lblGameStatus";
            this.lblGameStatus.Size = new System.Drawing.Size(68, 13);
            this.lblGameStatus.TabIndex = 9;
            this.lblGameStatus.Text = "Game Status";
            // 
            // rbHost
            // 
            this.rbHost.AutoSize = true;
            this.rbHost.Checked = true;
            this.rbHost.Location = new System.Drawing.Point(5, 0);
            this.rbHost.Name = "rbHost";
            this.rbHost.Size = new System.Drawing.Size(103, 17);
            this.rbHost.TabIndex = 13;
            this.rbHost.TabStop = true;
            this.rbHost.Text = "Host New Game";
            this.rbHost.UseVisualStyleBackColor = true;
            this.rbHost.CheckedChanged += new System.EventHandler(this.rbHost_CheckedChanged);
            // 
            // rbJoinGame
            // 
            this.rbJoinGame.AutoSize = true;
            this.rbJoinGame.Location = new System.Drawing.Point(114, -1);
            this.rbJoinGame.Name = "rbJoinGame";
            this.rbJoinGame.Size = new System.Drawing.Size(84, 17);
            this.rbJoinGame.TabIndex = 14;
            this.rbJoinGame.Text = "Join a Game";
            this.rbJoinGame.UseVisualStyleBackColor = true;
            this.rbJoinGame.CheckedChanged += new System.EventHandler(this.rbJoinGame_CheckedChanged);
            // 
            // ticTacToePlayers1
            // 
            this.ticTacToePlayers1.AutoSize = true;
            this.ticTacToePlayers1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ticTacToePlayers1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ticTacToePlayers1.Location = new System.Drawing.Point(8, 44);
            this.ticTacToePlayers1.Name = "ticTacToePlayers1";
            this.ticTacToePlayers1.PlayerName = "MyName";
            this.ticTacToePlayers1.PlayerSymbol = 'M';
            this.ticTacToePlayers1.PlayerTurn = false;
            this.ticTacToePlayers1.PlayerWon = false;
            this.ticTacToePlayers1.Size = new System.Drawing.Size(189, 218);
            this.ticTacToePlayers1.TabIndex = 10;
            // 
            // ticTacToeOptions1
            // 
            this.ticTacToeOptions1.AutoSize = true;
            this.ticTacToeOptions1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ticTacToeOptions1.Location = new System.Drawing.Point(0, -1);
            this.ticTacToeOptions1.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.ticTacToeOptions1.Name = "ticTacToeOptions1";
            this.ticTacToeOptions1.Size = new System.Drawing.Size(160, 209);
            this.ticTacToeOptions1.TabIndex = 1;
            // 
            // TicTacToeStartOrJoin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.rbJoinGame);
            this.Controls.Add(this.rbHost);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Name = "TicTacToeStartOrJoin";
            this.Size = new System.Drawing.Size(586, 298);
            this.Load += new System.EventHandler(this.TicTacToeStartOrJoin_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbAvailableGames;
        private TicTacToeOptions ticTacToeOptions1;
        private System.Windows.Forms.Label lblAvailableGames;
        private System.Windows.Forms.Button btnJoin;
        private System.Windows.Forms.Button btnWatch;
        private System.Windows.Forms.Button btnCreateRemove;
        private System.Windows.Forms.Button btnStartGame;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblGameStatus;
        private System.Windows.Forms.RadioButton rbHost;
        private System.Windows.Forms.RadioButton rbJoinGame;
        private TicTacToePlayers ticTacToePlayers1;
    }
}
