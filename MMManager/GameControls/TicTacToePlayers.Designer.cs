namespace MMManager.GameControls
{
    partial class TicTacToePlayers
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
            this.ticTacToePlayer1 = new MMManager.GameControls.TicTacToePlayer();
            this.ticTacToeScore1 = new MMManager.GameControls.TicTacToeScore();
            this.SuspendLayout();
            // 
            // ticTacToePlayer1
            // 
            this.ticTacToePlayer1.AutoSize = true;
            this.ticTacToePlayer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ticTacToePlayer1.Location = new System.Drawing.Point(3, 1);
            this.ticTacToePlayer1.Name = "ticTacToePlayer1";
            this.ticTacToePlayer1.PlayerName = "MyName";
            this.ticTacToePlayer1.PlayerScore = 0;
            this.ticTacToePlayer1.PlayerSymbol = 0;
            this.ticTacToePlayer1.PlayerStatus = "Unknown";
            this.ticTacToePlayer1.Size = new System.Drawing.Size(184, 90);
            this.ticTacToePlayer1.TabIndex = 5;
            // 
            // ticTacToeScore1
            // 
            this.ticTacToeScore1.AutoSize = true;
            this.ticTacToeScore1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ticTacToeScore1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ticTacToeScore1.Location = new System.Drawing.Point(3, 93);
            this.ticTacToeScore1.Name = "ticTacToeScore1";
            this.ticTacToeScore1.Size = new System.Drawing.Size(184, 163);
            this.ticTacToeScore1.TabIndex = 4;
            // 
            // TicTacToePlayers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.ticTacToePlayer1);
            this.Controls.Add(this.ticTacToeScore1);
            this.DoubleBuffered = true;
            this.Name = "TicTacToePlayers";
            this.Size = new System.Drawing.Size(190, 259);
            this.Load += new System.EventHandler(this.TicTacToePlayers_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TicTacToeScore ticTacToeScore1;
        private TicTacToePlayer ticTacToePlayer1;
    }
}
