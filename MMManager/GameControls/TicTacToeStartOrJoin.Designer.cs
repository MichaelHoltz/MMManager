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
            this.btnHostGame = new System.Windows.Forms.Button();
            this.btnJoinGame = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.ticTacToeScore3 = new MMManager.GameControls.TicTacToeScore();
            this.ticTacToeScore2 = new MMManager.GameControls.TicTacToeScore();
            this.ticTacToeScore1 = new MMManager.GameControls.TicTacToeScore();
            this.ticTacToeOptions1 = new MMManager.GameControls.TicTacToeOptions();
            this.lblGameStatus = new System.Windows.Forms.Label();
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
            this.btnStartGame.Location = new System.Drawing.Point(267, 17);
            this.btnStartGame.Name = "btnStartGame";
            this.btnStartGame.Size = new System.Drawing.Size(81, 21);
            this.btnStartGame.TabIndex = 1;
            this.btnStartGame.Text = "Start Game";
            this.btnStartGame.UseVisualStyleBackColor = true;
            this.btnStartGame.Click += new System.EventHandler(this.btnStartGame_Click);
            // 
            // btnCreateRemove
            // 
            this.btnCreateRemove.Location = new System.Drawing.Point(166, 17);
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
            // btnHostGame
            // 
            this.btnHostGame.Location = new System.Drawing.Point(5, 8);
            this.btnHostGame.Name = "btnHostGame";
            this.btnHostGame.Size = new System.Drawing.Size(111, 25);
            this.btnHostGame.TabIndex = 8;
            this.btnHostGame.Text = "Host New Game";
            this.btnHostGame.UseVisualStyleBackColor = true;
            this.btnHostGame.Click += new System.EventHandler(this.btnHostGame_Click);
            // 
            // btnJoinGame
            // 
            this.btnJoinGame.Location = new System.Drawing.Point(143, 8);
            this.btnJoinGame.Name = "btnJoinGame";
            this.btnJoinGame.Size = new System.Drawing.Size(111, 25);
            this.btnJoinGame.TabIndex = 9;
            this.btnJoinGame.Text = "Join A Game";
            this.btnJoinGame.UseVisualStyleBackColor = true;
            this.btnJoinGame.Click += new System.EventHandler(this.btnJoinGame_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.ticTacToeScore1);
            this.panel1.Controls.Add(this.ticTacToeOptions1);
            this.panel1.Controls.Add(this.btnCreateRemove);
            this.panel1.Controls.Add(this.btnStartGame);
            this.panel1.Location = new System.Drawing.Point(6, 45);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(369, 222);
            this.panel1.TabIndex = 10;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.ticTacToeScore2);
            this.panel2.Controls.Add(this.lbAvailableGames);
            this.panel2.Controls.Add(this.lblAvailableGames);
            this.panel2.Controls.Add(this.btnJoin);
            this.panel2.Controls.Add(this.btnWatch);
            this.panel2.Controls.Add(this.btnRefresh);
            this.panel2.Location = new System.Drawing.Point(390, 43);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(369, 222);
            this.panel2.TabIndex = 11;
            this.panel2.Visible = false;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.lblGameStatus);
            this.panel3.Controls.Add(this.ticTacToeScore3);
            this.panel3.Location = new System.Drawing.Point(767, 41);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(192, 223);
            this.panel3.TabIndex = 12;
            this.panel3.Visible = false;
            // 
            // ticTacToeScore3
            // 
            this.ticTacToeScore3.AutoSize = true;
            this.ticTacToeScore3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ticTacToeScore3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ticTacToeScore3.Location = new System.Drawing.Point(3, 69);
            this.ticTacToeScore3.Name = "ticTacToeScore3";
            this.ticTacToeScore3.Size = new System.Drawing.Size(181, 144);
            this.ticTacToeScore3.TabIndex = 8;
            // 
            // ticTacToeScore2
            // 
            this.ticTacToeScore2.AutoSize = true;
            this.ticTacToeScore2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ticTacToeScore2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ticTacToeScore2.Location = new System.Drawing.Point(187, 20);
            this.ticTacToeScore2.Name = "ticTacToeScore2";
            this.ticTacToeScore2.Size = new System.Drawing.Size(181, 144);
            this.ticTacToeScore2.TabIndex = 7;
            // 
            // ticTacToeScore1
            // 
            this.ticTacToeScore1.AutoSize = true;
            this.ticTacToeScore1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ticTacToeScore1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ticTacToeScore1.Location = new System.Drawing.Point(167, 64);
            this.ticTacToeScore1.Name = "ticTacToeScore1";
            this.ticTacToeScore1.Size = new System.Drawing.Size(181, 144);
            this.ticTacToeScore1.TabIndex = 6;
            // 
            // ticTacToeOptions1
            // 
            this.ticTacToeOptions1.AutoSize = true;
            this.ticTacToeOptions1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ticTacToeOptions1.Location = new System.Drawing.Point(0, -1);
            this.ticTacToeOptions1.Name = "ticTacToeOptions1";
            this.ticTacToeOptions1.Size = new System.Drawing.Size(160, 209);
            this.ticTacToeOptions1.TabIndex = 1;
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
            // TicTacToeStartOrJoin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnJoinGame);
            this.Controls.Add(this.btnHostGame);
            this.DoubleBuffered = true;
            this.Name = "TicTacToeStartOrJoin";
            this.Size = new System.Drawing.Size(962, 270);
            this.Load += new System.EventHandler(this.TicTacToeStartOrJoin_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

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
        private TicTacToeScore ticTacToeScore1;
        private System.Windows.Forms.Button btnHostGame;
        private System.Windows.Forms.Button btnJoinGame;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private TicTacToeScore ticTacToeScore2;
        private System.Windows.Forms.Panel panel3;
        private TicTacToeScore ticTacToeScore3;
        private System.Windows.Forms.Label lblGameStatus;
    }
}
