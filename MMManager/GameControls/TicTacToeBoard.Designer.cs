namespace MMManager.GameControls
{
    partial class TicTacToeBoard
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.ticTacToeScore1 = new MMManager.GameControls.TicTacToeScore();
            this.ticTacToeOptions1 = new MMManager.GameControls.TicTacToeOptions();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label1.Location = new System.Drawing.Point(0, 409);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "label1";
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox1.Location = new System.Drawing.Point(3, 190);
            this.groupBox1.MinimumSize = new System.Drawing.Size(150, 150);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(150, 150);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tic Tac Toe";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(224, 161);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(101, 23);
            this.btnStart.TabIndex = 9;
            this.btnStart.Text = "Start / Reset";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.button2_Click);
            // 
            // timer2
            // 
            this.timer2.Interval = 500;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // ticTacToeScore1
            // 
            this.ticTacToeScore1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ticTacToeScore1.Location = new System.Drawing.Point(172, 3);
            this.ticTacToeScore1.Name = "ticTacToeScore1";
            this.ticTacToeScore1.Size = new System.Drawing.Size(212, 98);
            this.ticTacToeScore1.TabIndex = 14;
            // 
            // ticTacToeOptions1
            // 
            this.ticTacToeOptions1.AutoSize = true;
            this.ticTacToeOptions1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ticTacToeOptions1.Location = new System.Drawing.Point(0, 0);
            this.ticTacToeOptions1.Name = "ticTacToeOptions1";
            this.ticTacToeOptions1.Size = new System.Drawing.Size(166, 184);
            this.ticTacToeOptions1.TabIndex = 13;
            // 
            // TicTacToeBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.ticTacToeScore1);
            this.Controls.Add(this.ticTacToeOptions1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnStart);
            this.DoubleBuffered = true;
            this.Name = "TicTacToeBoard";
            this.Size = new System.Drawing.Size(387, 422);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Timer timer2;
        private TicTacToeOptions ticTacToeOptions1;
        private TicTacToeScore ticTacToeScore1;
    }
}
