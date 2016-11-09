namespace MMManager.GameControls
{
    partial class TicTacToeScore
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
            this.lblPlayer = new System.Windows.Forms.Label();
            this.lblPlayer4Name = new System.Windows.Forms.Label();
            this.lblPlayer3Name = new System.Windows.Forms.Label();
            this.lblPlayer2Name = new System.Windows.Forms.Label();
            this.lblPlayer1Name = new System.Windows.Forms.Label();
            this.lblPlayer4Score = new System.Windows.Forms.Label();
            this.lblPlayer3Score = new System.Windows.Forms.Label();
            this.lblPlayer2Score = new System.Windows.Forms.Label();
            this.lblPlayer1Score = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblPlayer
            // 
            this.lblPlayer.AutoSize = true;
            this.lblPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer.Location = new System.Drawing.Point(6, 5);
            this.lblPlayer.Name = "lblPlayer";
            this.lblPlayer.Size = new System.Drawing.Size(42, 13);
            this.lblPlayer.TabIndex = 0;
            this.lblPlayer.Text = "Player";
            // 
            // lblPlayer4Name
            // 
            this.lblPlayer4Name.AutoSize = true;
            this.lblPlayer4Name.Location = new System.Drawing.Point(6, 103);
            this.lblPlayer4Name.Name = "lblPlayer4Name";
            this.lblPlayer4Name.Size = new System.Drawing.Size(42, 13);
            this.lblPlayer4Name.TabIndex = 7;
            this.lblPlayer4Name.Text = "Player4";
            this.lblPlayer4Name.Visible = false;
            // 
            // lblPlayer3Name
            // 
            this.lblPlayer3Name.AutoSize = true;
            this.lblPlayer3Name.Location = new System.Drawing.Point(6, 77);
            this.lblPlayer3Name.Name = "lblPlayer3Name";
            this.lblPlayer3Name.Size = new System.Drawing.Size(42, 13);
            this.lblPlayer3Name.TabIndex = 6;
            this.lblPlayer3Name.Text = "Player3";
            this.lblPlayer3Name.Visible = false;
            // 
            // lblPlayer2Name
            // 
            this.lblPlayer2Name.AutoSize = true;
            this.lblPlayer2Name.Location = new System.Drawing.Point(6, 52);
            this.lblPlayer2Name.Name = "lblPlayer2Name";
            this.lblPlayer2Name.Size = new System.Drawing.Size(42, 13);
            this.lblPlayer2Name.TabIndex = 5;
            this.lblPlayer2Name.Text = "Player2";
            // 
            // lblPlayer1Name
            // 
            this.lblPlayer1Name.AutoSize = true;
            this.lblPlayer1Name.Location = new System.Drawing.Point(6, 27);
            this.lblPlayer1Name.Name = "lblPlayer1Name";
            this.lblPlayer1Name.Size = new System.Drawing.Size(42, 13);
            this.lblPlayer1Name.TabIndex = 4;
            this.lblPlayer1Name.Text = "Player1";
            // 
            // lblPlayer4Score
            // 
            this.lblPlayer4Score.AutoSize = true;
            this.lblPlayer4Score.Location = new System.Drawing.Point(114, 103);
            this.lblPlayer4Score.Name = "lblPlayer4Score";
            this.lblPlayer4Score.Size = new System.Drawing.Size(42, 13);
            this.lblPlayer4Score.TabIndex = 11;
            this.lblPlayer4Score.Text = "Player4";
            this.lblPlayer4Score.Visible = false;
            // 
            // lblPlayer3Score
            // 
            this.lblPlayer3Score.AutoSize = true;
            this.lblPlayer3Score.Location = new System.Drawing.Point(114, 76);
            this.lblPlayer3Score.Name = "lblPlayer3Score";
            this.lblPlayer3Score.Size = new System.Drawing.Size(42, 13);
            this.lblPlayer3Score.TabIndex = 10;
            this.lblPlayer3Score.Text = "Player3";
            this.lblPlayer3Score.Visible = false;
            // 
            // lblPlayer2Score
            // 
            this.lblPlayer2Score.AutoSize = true;
            this.lblPlayer2Score.Location = new System.Drawing.Point(114, 51);
            this.lblPlayer2Score.Name = "lblPlayer2Score";
            this.lblPlayer2Score.Size = new System.Drawing.Size(42, 13);
            this.lblPlayer2Score.TabIndex = 9;
            this.lblPlayer2Score.Text = "Player2";
            // 
            // lblPlayer1Score
            // 
            this.lblPlayer1Score.AutoSize = true;
            this.lblPlayer1Score.Location = new System.Drawing.Point(114, 26);
            this.lblPlayer1Score.Name = "lblPlayer1Score";
            this.lblPlayer1Score.Size = new System.Drawing.Size(42, 13);
            this.lblPlayer1Score.TabIndex = 8;
            this.lblPlayer1Score.Text = "Player1";
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.Location = new System.Drawing.Point(114, 5);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(40, 13);
            this.lblScore.TabIndex = 12;
            this.lblScore.Text = "Score";
            // 
            // TicTacToeScore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.lblPlayer4Score);
            this.Controls.Add(this.lblPlayer3Score);
            this.Controls.Add(this.lblPlayer2Score);
            this.Controls.Add(this.lblPlayer1Score);
            this.Controls.Add(this.lblPlayer4Name);
            this.Controls.Add(this.lblPlayer3Name);
            this.Controls.Add(this.lblPlayer2Name);
            this.Controls.Add(this.lblPlayer1Name);
            this.Controls.Add(this.lblPlayer);
            this.DoubleBuffered = true;
            this.Name = "TicTacToeScore";
            this.Size = new System.Drawing.Size(160, 121);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPlayer;
        private System.Windows.Forms.Label lblPlayer4Name;
        private System.Windows.Forms.Label lblPlayer3Name;
        private System.Windows.Forms.Label lblPlayer2Name;
        private System.Windows.Forms.Label lblPlayer1Name;
        private System.Windows.Forms.Label lblPlayer4Score;
        private System.Windows.Forms.Label lblPlayer3Score;
        private System.Windows.Forms.Label lblPlayer2Score;
        private System.Windows.Forms.Label lblPlayer1Score;
        private System.Windows.Forms.Label lblScore;
    }
}
