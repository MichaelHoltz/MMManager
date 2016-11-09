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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("");
            this.lbAvailableGames = new System.Windows.Forms.ListBox();
            this.lblAvailableGames = new System.Windows.Forms.Label();
            this.btnJoin = new System.Windows.Forms.Button();
            this.btnWatch = new System.Windows.Forms.Button();
            this.scALL = new System.Windows.Forms.SplitContainer();
            this.scNewOrJoin = new System.Windows.Forms.SplitContainer();
            this.btnStartGame = new System.Windows.Forms.Button();
            this.btnCreateRemove = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.ticTacToeOptions1 = new MMManager.GameControls.TicTacToeOptions();
            ((System.ComponentModel.ISupportInitialize)(this.scALL)).BeginInit();
            this.scALL.Panel1.SuspendLayout();
            this.scALL.Panel2.SuspendLayout();
            this.scALL.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scNewOrJoin)).BeginInit();
            this.scNewOrJoin.Panel1.SuspendLayout();
            this.scNewOrJoin.Panel2.SuspendLayout();
            this.scNewOrJoin.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbAvailableGames
            // 
            this.lbAvailableGames.FormattingEnabled = true;
            this.lbAvailableGames.Items.AddRange(new object[] {
            "No Games Found"});
            this.lbAvailableGames.Location = new System.Drawing.Point(6, 20);
            this.lbAvailableGames.Name = "lbAvailableGames";
            this.lbAvailableGames.Size = new System.Drawing.Size(191, 82);
            this.lbAvailableGames.TabIndex = 0;
            // 
            // lblAvailableGames
            // 
            this.lblAvailableGames.AutoSize = true;
            this.lblAvailableGames.Location = new System.Drawing.Point(3, 4);
            this.lblAvailableGames.Name = "lblAvailableGames";
            this.lblAvailableGames.Size = new System.Drawing.Size(86, 13);
            this.lblAvailableGames.TabIndex = 2;
            this.lblAvailableGames.Text = "Available Games";
            // 
            // btnJoin
            // 
            this.btnJoin.Enabled = false;
            this.btnJoin.Location = new System.Drawing.Point(207, 48);
            this.btnJoin.Name = "btnJoin";
            this.btnJoin.Size = new System.Drawing.Size(67, 25);
            this.btnJoin.TabIndex = 3;
            this.btnJoin.Text = "Join";
            this.btnJoin.UseVisualStyleBackColor = true;
            // 
            // btnWatch
            // 
            this.btnWatch.Enabled = false;
            this.btnWatch.Location = new System.Drawing.Point(207, 76);
            this.btnWatch.Name = "btnWatch";
            this.btnWatch.Size = new System.Drawing.Size(67, 25);
            this.btnWatch.TabIndex = 4;
            this.btnWatch.Text = "Watch";
            this.btnWatch.UseVisualStyleBackColor = true;
            // 
            // scALL
            // 
            this.scALL.IsSplitterFixed = true;
            this.scALL.Location = new System.Drawing.Point(3, 3);
            this.scALL.Name = "scALL";
            // 
            // scALL.Panel1
            // 
            this.scALL.Panel1.Controls.Add(this.ticTacToeOptions1);
            this.scALL.Panel1MinSize = 120;
            // 
            // scALL.Panel2
            // 
            this.scALL.Panel2.Controls.Add(this.scNewOrJoin);
            this.scALL.Panel2MinSize = 275;
            this.scALL.Size = new System.Drawing.Size(429, 200);
            this.scALL.SplitterDistance = 149;
            this.scALL.TabIndex = 5;
            // 
            // scNewOrJoin
            // 
            this.scNewOrJoin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scNewOrJoin.IsSplitterFixed = true;
            this.scNewOrJoin.Location = new System.Drawing.Point(0, 0);
            this.scNewOrJoin.Name = "scNewOrJoin";
            this.scNewOrJoin.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // scNewOrJoin.Panel1
            // 
            this.scNewOrJoin.Panel1.Controls.Add(this.listView1);
            this.scNewOrJoin.Panel1.Controls.Add(this.btnStartGame);
            this.scNewOrJoin.Panel1.Controls.Add(this.btnCreateRemove);
            // 
            // scNewOrJoin.Panel2
            // 
            this.scNewOrJoin.Panel2.Controls.Add(this.btnRefresh);
            this.scNewOrJoin.Panel2.Controls.Add(this.lblAvailableGames);
            this.scNewOrJoin.Panel2.Controls.Add(this.lbAvailableGames);
            this.scNewOrJoin.Panel2.Controls.Add(this.btnJoin);
            this.scNewOrJoin.Panel2.Controls.Add(this.btnWatch);
            this.scNewOrJoin.Panel2MinSize = 109;
            this.scNewOrJoin.Size = new System.Drawing.Size(276, 200);
            this.scNewOrJoin.SplitterDistance = 87;
            this.scNewOrJoin.TabIndex = 0;
            // 
            // btnStartGame
            // 
            this.btnStartGame.Location = new System.Drawing.Point(150, 3);
            this.btnStartGame.Name = "btnStartGame";
            this.btnStartGame.Size = new System.Drawing.Size(95, 21);
            this.btnStartGame.TabIndex = 1;
            this.btnStartGame.Text = "StartGame";
            this.btnStartGame.UseVisualStyleBackColor = true;
            // 
            // btnCreateRemove
            // 
            this.btnCreateRemove.Location = new System.Drawing.Point(29, 3);
            this.btnCreateRemove.Name = "btnCreateRemove";
            this.btnCreateRemove.Size = new System.Drawing.Size(95, 21);
            this.btnCreateRemove.TabIndex = 0;
            this.btnCreateRemove.Text = "Create Game";
            this.btnCreateRemove.UseVisualStyleBackColor = true;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(207, 20);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(67, 25);
            this.btnRefresh.TabIndex = 5;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.listView1.Location = new System.Drawing.Point(28, 28);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(216, 53);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // ticTacToeOptions1
            // 
            this.ticTacToeOptions1.AutoSize = true;
            this.ticTacToeOptions1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ticTacToeOptions1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ticTacToeOptions1.Location = new System.Drawing.Point(0, 0);
            this.ticTacToeOptions1.Name = "ticTacToeOptions1";
            this.ticTacToeOptions1.Size = new System.Drawing.Size(149, 200);
            this.ticTacToeOptions1.TabIndex = 1;
            // 
            // TicTacToeStartOrJoin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.scALL);
            this.DoubleBuffered = true;
            this.Name = "TicTacToeStartOrJoin";
            this.Size = new System.Drawing.Size(435, 206);
            this.scALL.Panel1.ResumeLayout(false);
            this.scALL.Panel1.PerformLayout();
            this.scALL.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scALL)).EndInit();
            this.scALL.ResumeLayout(false);
            this.scNewOrJoin.Panel1.ResumeLayout(false);
            this.scNewOrJoin.Panel2.ResumeLayout(false);
            this.scNewOrJoin.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scNewOrJoin)).EndInit();
            this.scNewOrJoin.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbAvailableGames;
        private TicTacToeOptions ticTacToeOptions1;
        private System.Windows.Forms.Label lblAvailableGames;
        private System.Windows.Forms.Button btnJoin;
        private System.Windows.Forms.Button btnWatch;
        private System.Windows.Forms.SplitContainer scALL;
        private System.Windows.Forms.SplitContainer scNewOrJoin;
        private System.Windows.Forms.Button btnCreateRemove;
        private System.Windows.Forms.Button btnStartGame;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.ListView listView1;
    }
}
