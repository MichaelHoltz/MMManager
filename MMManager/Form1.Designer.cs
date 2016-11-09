namespace MMManager
{
    partial class Form1
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
            this.ticTacToeStartOrJoin1 = new MMManager.GameControls.TicTacToeStartOrJoin();
            this.ticTacToeBoard1 = new MMManager.GameControls.TicTacToeBoard();
            this.SuspendLayout();
            // 
            // ticTacToeStartOrJoin1
            // 
            this.ticTacToeStartOrJoin1.AutoSize = true;
            this.ticTacToeStartOrJoin1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ticTacToeStartOrJoin1.Location = new System.Drawing.Point(445, 12);
            this.ticTacToeStartOrJoin1.Name = "ticTacToeStartOrJoin1";
            this.ticTacToeStartOrJoin1.Size = new System.Drawing.Size(435, 206);
            this.ticTacToeStartOrJoin1.TabIndex = 11;
            // 
            // ticTacToeBoard1
            // 
            this.ticTacToeBoard1.AutoSize = true;
            this.ticTacToeBoard1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ticTacToeBoard1.Location = new System.Drawing.Point(2, 6);
            this.ticTacToeBoard1.Name = "ticTacToeBoard1";
            this.ticTacToeBoard1.Size = new System.Drawing.Size(387, 343);
            this.ticTacToeBoard1.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(920, 504);
            this.Controls.Add(this.ticTacToeStartOrJoin1);
            this.Controls.Add(this.ticTacToeBoard1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private GameControls.TicTacToeBoard ticTacToeBoard1;
        private GameControls.TicTacToeStartOrJoin ticTacToeStartOrJoin1;
    }
}

