namespace MMManager
{
    partial class frmModsSelect
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.cbMods = new System.Windows.Forms.CheckedListBox();
            this.lblModInfo = new System.Windows.Forms.Label();
            this.lblModState = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.cbMods);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.lblModState);
            this.splitContainer1.Panel2.Controls.Add(this.lblModInfo);
            this.splitContainer1.Size = new System.Drawing.Size(417, 526);
            this.splitContainer1.SplitterDistance = 425;
            this.splitContainer1.TabIndex = 0;
            // 
            // cbMods
            // 
            this.cbMods.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbMods.FormattingEnabled = true;
            this.cbMods.Items.AddRange(new object[] {
            "Mod1",
            "Mod2",
            "Mod3"});
            this.cbMods.Location = new System.Drawing.Point(0, 0);
            this.cbMods.Name = "cbMods";
            this.cbMods.Size = new System.Drawing.Size(417, 425);
            this.cbMods.TabIndex = 0;
            this.cbMods.SelectedIndexChanged += new System.EventHandler(this.cbMods_SelectedIndexChanged);
            // 
            // lblModInfo
            // 
            this.lblModInfo.AutoSize = true;
            this.lblModInfo.Location = new System.Drawing.Point(3, 32);
            this.lblModInfo.Name = "lblModInfo";
            this.lblModInfo.Size = new System.Drawing.Size(83, 13);
            this.lblModInfo.TabIndex = 0;
            this.lblModInfo.Text = "Mod Information";
            // 
            // lblModState
            // 
            this.lblModState.AutoSize = true;
            this.lblModState.Location = new System.Drawing.Point(6, 16);
            this.lblModState.Name = "lblModState";
            this.lblModState.Size = new System.Drawing.Size(48, 13);
            this.lblModState.TabIndex = 1;
            this.lblModState.Text = "Disabled";
            // 
            // frmModsSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 526);
            this.Controls.Add(this.splitContainer1);
            this.Name = "frmModsSelect";
            this.Text = "Mods Selector";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.CheckedListBox cbMods;
        private System.Windows.Forms.Label lblModInfo;
        private System.Windows.Forms.Label lblModState;
    }
}