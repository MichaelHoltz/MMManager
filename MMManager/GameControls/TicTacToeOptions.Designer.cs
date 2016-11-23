namespace MMManager.GameControls
{
    partial class TicTacToeOptions
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
            this.domainUpDown1 = new System.Windows.Forms.DomainUpDown();
            this.lblGridSize = new System.Windows.Forms.Label();
            this.gbRandomOptions = new System.Windows.Forms.GroupBox();
            this.clbRandomOptions = new System.Windows.Forms.CheckedListBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.lblGameOptions = new System.Windows.Forms.Label();
            this.gbRandomOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // domainUpDown1
            // 
            this.domainUpDown1.Items.Add("10");
            this.domainUpDown1.Items.Add("9");
            this.domainUpDown1.Items.Add("8");
            this.domainUpDown1.Items.Add("7");
            this.domainUpDown1.Items.Add("6");
            this.domainUpDown1.Items.Add("5");
            this.domainUpDown1.Items.Add("4");
            this.domainUpDown1.Items.Add("3");
            this.domainUpDown1.Location = new System.Drawing.Point(16, 51);
            this.domainUpDown1.Name = "domainUpDown1";
            this.domainUpDown1.ReadOnly = true;
            this.domainUpDown1.Size = new System.Drawing.Size(56, 20);
            this.domainUpDown1.TabIndex = 12;
            this.domainUpDown1.Text = "3";
            this.domainUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblGridSize
            // 
            this.lblGridSize.AutoSize = true;
            this.lblGridSize.Location = new System.Drawing.Point(13, 35);
            this.lblGridSize.Name = "lblGridSize";
            this.lblGridSize.Size = new System.Drawing.Size(49, 13);
            this.lblGridSize.TabIndex = 13;
            this.lblGridSize.Text = "Grid Size";
            // 
            // gbRandomOptions
            // 
            this.gbRandomOptions.Controls.Add(this.clbRandomOptions);
            this.gbRandomOptions.Location = new System.Drawing.Point(10, 81);
            this.gbRandomOptions.Name = "gbRandomOptions";
            this.gbRandomOptions.Size = new System.Drawing.Size(136, 123);
            this.gbRandomOptions.TabIndex = 17;
            this.gbRandomOptions.TabStop = false;
            this.gbRandomOptions.Text = "Random Options";
            // 
            // clbRandomOptions
            // 
            this.clbRandomOptions.CheckOnClick = true;
            this.clbRandomOptions.FormattingEnabled = true;
            this.clbRandomOptions.Items.AddRange(new object[] {
            "Bombs",
            "Extra Turns",
            "Row / Col Clear",
            "Shuffle"});
            this.clbRandomOptions.Location = new System.Drawing.Point(6, 19);
            this.clbRandomOptions.Name = "clbRandomOptions";
            this.clbRandomOptions.Size = new System.Drawing.Size(124, 94);
            this.clbRandomOptions.TabIndex = 19;
            // 
            // lblGameOptions
            // 
            this.lblGameOptions.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGameOptions.Location = new System.Drawing.Point(4, 5);
            this.lblGameOptions.Name = "lblGameOptions";
            this.lblGameOptions.Size = new System.Drawing.Size(151, 20);
            this.lblGameOptions.TabIndex = 18;
            this.lblGameOptions.Text = "Game Options";
            this.lblGameOptions.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TicTacToeOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.lblGameOptions);
            this.Controls.Add(this.gbRandomOptions);
            this.Controls.Add(this.lblGridSize);
            this.Controls.Add(this.domainUpDown1);
            this.DoubleBuffered = true;
            this.Name = "TicTacToeOptions";
            this.Size = new System.Drawing.Size(159, 215);
            this.gbRandomOptions.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DomainUpDown domainUpDown1;
        private System.Windows.Forms.Label lblGridSize;
        private System.Windows.Forms.GroupBox gbRandomOptions;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.CheckedListBox clbRandomOptions;
        private System.Windows.Forms.Label lblGameOptions;
    }
}
