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
            this.cbRowColClear = new System.Windows.Forms.CheckBox();
            this.cbExtraTurns = new System.Windows.Forms.CheckBox();
            this.cbBombs = new System.Windows.Forms.CheckBox();
            this.cbShuffle = new System.Windows.Forms.CheckBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.gbRandomOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // domainUpDown1
            // 
            this.domainUpDown1.Items.Add("3");
            this.domainUpDown1.Items.Add("4");
            this.domainUpDown1.Items.Add("5");
            this.domainUpDown1.Items.Add("6");
            this.domainUpDown1.Items.Add("7");
            this.domainUpDown1.Items.Add("8");
            this.domainUpDown1.Items.Add("9");
            this.domainUpDown1.Items.Add("10");
            this.domainUpDown1.Location = new System.Drawing.Point(33, 30);
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
            this.lblGridSize.Location = new System.Drawing.Point(30, 14);
            this.lblGridSize.Name = "lblGridSize";
            this.lblGridSize.Size = new System.Drawing.Size(49, 13);
            this.lblGridSize.TabIndex = 13;
            this.lblGridSize.Text = "Grid Size";
            // 
            // gbRandomOptions
            // 
            this.gbRandomOptions.Controls.Add(this.cbShuffle);
            this.gbRandomOptions.Controls.Add(this.cbRowColClear);
            this.gbRandomOptions.Controls.Add(this.cbExtraTurns);
            this.gbRandomOptions.Controls.Add(this.cbBombs);
            this.gbRandomOptions.Location = new System.Drawing.Point(3, 56);
            this.gbRandomOptions.Name = "gbRandomOptions";
            this.gbRandomOptions.Size = new System.Drawing.Size(136, 123);
            this.gbRandomOptions.TabIndex = 17;
            this.gbRandomOptions.TabStop = false;
            this.gbRandomOptions.Text = "Random Options";
            // 
            // cbRowColClear
            // 
            this.cbRowColClear.AutoSize = true;
            this.cbRowColClear.Enabled = false;
            this.cbRowColClear.Location = new System.Drawing.Point(6, 69);
            this.cbRowColClear.Name = "cbRowColClear";
            this.cbRowColClear.Size = new System.Drawing.Size(101, 17);
            this.cbRowColClear.TabIndex = 19;
            this.cbRowColClear.Text = "Row / Col Clear";
            this.toolTip1.SetToolTip(this.cbRowColClear, "Uncover Space to Clear Entire Row or Column");
            this.cbRowColClear.UseVisualStyleBackColor = true;
            // 
            // cbExtraTurns
            // 
            this.cbExtraTurns.AutoSize = true;
            this.cbExtraTurns.Enabled = false;
            this.cbExtraTurns.Location = new System.Drawing.Point(6, 45);
            this.cbExtraTurns.Name = "cbExtraTurns";
            this.cbExtraTurns.Size = new System.Drawing.Size(80, 17);
            this.cbExtraTurns.TabIndex = 18;
            this.cbExtraTurns.Text = "Extra Turns";
            this.toolTip1.SetToolTip(this.cbExtraTurns, "Uncover Space to Get Extra Turn");
            this.cbExtraTurns.UseVisualStyleBackColor = true;
            // 
            // cbBombs
            // 
            this.cbBombs.AutoSize = true;
            this.cbBombs.Location = new System.Drawing.Point(6, 21);
            this.cbBombs.Name = "cbBombs";
            this.cbBombs.Size = new System.Drawing.Size(58, 17);
            this.cbBombs.TabIndex = 17;
            this.cbBombs.Text = "Bombs";
            this.toolTip1.SetToolTip(this.cbBombs, "Uncover Space to Lose Turn");
            this.cbBombs.UseVisualStyleBackColor = true;
            // 
            // cbShuffle
            // 
            this.cbShuffle.AutoSize = true;
            this.cbShuffle.Enabled = false;
            this.cbShuffle.Location = new System.Drawing.Point(6, 92);
            this.cbShuffle.Name = "cbShuffle";
            this.cbShuffle.Size = new System.Drawing.Size(59, 17);
            this.cbShuffle.TabIndex = 20;
            this.cbShuffle.Text = "Shuffle";
            this.toolTip1.SetToolTip(this.cbShuffle, "Uncover Space to Shuffle the entire board");
            this.cbShuffle.UseVisualStyleBackColor = true;
            // 
            // TicTacToeOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.gbRandomOptions);
            this.Controls.Add(this.lblGridSize);
            this.Controls.Add(this.domainUpDown1);
            this.DoubleBuffered = true;
            this.Name = "TicTacToeOptions";
            this.Size = new System.Drawing.Size(145, 183);
            this.gbRandomOptions.ResumeLayout(false);
            this.gbRandomOptions.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DomainUpDown domainUpDown1;
        private System.Windows.Forms.Label lblGridSize;
        private System.Windows.Forms.GroupBox gbRandomOptions;
        private System.Windows.Forms.CheckBox cbShuffle;
        private System.Windows.Forms.CheckBox cbRowColClear;
        private System.Windows.Forms.CheckBox cbExtraTurns;
        private System.Windows.Forms.CheckBox cbBombs;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}
