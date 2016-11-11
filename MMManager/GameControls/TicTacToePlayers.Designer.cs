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
            this.ticTacToeScore1 = new MMManager.GameControls.TicTacToeScore();
            this.lblSymbol = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ticTacToeScore1
            // 
            this.ticTacToeScore1.AutoSize = true;
            this.ticTacToeScore1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ticTacToeScore1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ticTacToeScore1.Location = new System.Drawing.Point(3, 34);
            this.ticTacToeScore1.Name = "ticTacToeScore1";
            this.ticTacToeScore1.Size = new System.Drawing.Size(181, 144);
            this.ticTacToeScore1.TabIndex = 4;
            // 
            // lblSymbol
            // 
            this.lblSymbol.AutoSize = true;
            this.lblSymbol.Location = new System.Drawing.Point(9, 9);
            this.lblSymbol.Name = "lblSymbol";
            this.lblSymbol.Size = new System.Drawing.Size(41, 13);
            this.lblSymbol.TabIndex = 5;
            this.lblSymbol.Text = "Symbol";
            // 
            // TicTacToePlayers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblSymbol);
            this.Controls.Add(this.ticTacToeScore1);
            this.Name = "TicTacToePlayers";
            this.Size = new System.Drawing.Size(453, 468);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TicTacToeScore ticTacToeScore1;
        private System.Windows.Forms.Label lblSymbol;
    }
}
