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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TicTacToePlayers));
            this.btnJoin = new System.Windows.Forms.Button();
            this.btnLeave = new System.Windows.Forms.Button();
            this.ticTacToeScore1 = new MMManager.GameControls.TicTacToeScore();
            this.SuspendLayout();
            // 
            // btnJoin
            // 
            this.btnJoin.Location = new System.Drawing.Point(7, 12);
            this.btnJoin.Name = "btnJoin";
            this.btnJoin.Size = new System.Drawing.Size(60, 23);
            this.btnJoin.TabIndex = 1;
            this.btnJoin.Text = "Join";
            this.btnJoin.UseVisualStyleBackColor = true;
            this.btnJoin.Click += new System.EventHandler(this.btnJoin_Click);
            // 
            // btnLeave
            // 
            this.btnLeave.Location = new System.Drawing.Point(7, 41);
            this.btnLeave.Name = "btnLeave";
            this.btnLeave.Size = new System.Drawing.Size(60, 23);
            this.btnLeave.TabIndex = 2;
            this.btnLeave.Text = "Leave";
            this.btnLeave.UseVisualStyleBackColor = true;
            this.btnLeave.Click += new System.EventHandler(this.btnLeave_Click);
            // 
            // ticTacToeScore1
            // 
            this.ticTacToeScore1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ticTacToeScore1.Location = new System.Drawing.Point(123, 12);
            this.ticTacToeScore1.Name = "ticTacToeScore1";
            this.ticTacToeScore1.PlayerScores = ((System.Collections.Generic.Dictionary<string, int>)(resources.GetObject("ticTacToeScore1.PlayerScores")));
            this.ticTacToeScore1.Size = new System.Drawing.Size(160, 121);
            this.ticTacToeScore1.TabIndex = 0;
            // 
            // TicTacToePlayers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnLeave);
            this.Controls.Add(this.btnJoin);
            this.Controls.Add(this.ticTacToeScore1);
            this.Name = "TicTacToePlayers";
            this.Size = new System.Drawing.Size(296, 150);
            this.ResumeLayout(false);

        }

        #endregion

        private TicTacToeScore ticTacToeScore1;
        private System.Windows.Forms.Button btnJoin;
        private System.Windows.Forms.Button btnLeave;
    }
}
