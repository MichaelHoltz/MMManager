namespace MMManager
{
    partial class frmSymbolSelector
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSymbolSelector));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.ilSelectButtons = new System.Windows.Forms.ImageList(this.components);
            this.btnSelect = new System.Windows.Forms.Button();
            this.lblInfo = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1008, 322);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // ilSelectButtons
            // 
            this.ilSelectButtons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ilSelectButtons.ImageStream")));
            this.ilSelectButtons.TransparentColor = System.Drawing.Color.Transparent;
            this.ilSelectButtons.Images.SetKeyName(0, "Blank0.png");
            this.ilSelectButtons.Images.SetKeyName(1, "Blank1.png");
            this.ilSelectButtons.Images.SetKeyName(2, "Blank2.png");
            this.ilSelectButtons.Images.SetKeyName(3, "Blank3.png");
            this.ilSelectButtons.Images.SetKeyName(4, "Blank4.png");
            this.ilSelectButtons.Images.SetKeyName(5, "Blank5.png");
            this.ilSelectButtons.Images.SetKeyName(6, "Blank6.png");
            this.ilSelectButtons.Images.SetKeyName(7, "Blank7.png");
            this.ilSelectButtons.Images.SetKeyName(8, "Blank8.png");
            this.ilSelectButtons.Images.SetKeyName(9, "Blank9.png");
            this.ilSelectButtons.Images.SetKeyName(10, "3DWireFrame.png");
            this.ilSelectButtons.Images.SetKeyName(11, "32WireFrame2.png");
            this.ilSelectButtons.Images.SetKeyName(12, "Anna.png");
            this.ilSelectButtons.Images.SetKeyName(13, "BraveBrothers1.png");
            this.ilSelectButtons.Images.SetKeyName(14, "BraveBrothers2.png");
            this.ilSelectButtons.Images.SetKeyName(15, "BraveBrothers3.png");
            this.ilSelectButtons.Images.SetKeyName(16, "Coffee-Cup1.png");
            this.ilSelectButtons.Images.SetKeyName(17, "Creeper.png");
            this.ilSelectButtons.Images.SetKeyName(18, "cupcake1.png");
            this.ilSelectButtons.Images.SetKeyName(19, "cupcake2.png");
            this.ilSelectButtons.Images.SetKeyName(20, "DarthVader.png");
            this.ilSelectButtons.Images.SetKeyName(21, "deadpool-logo.png");
            this.ilSelectButtons.Images.SetKeyName(22, "DeathStar.png");
            this.ilSelectButtons.Images.SetKeyName(23, "Elsa1.png");
            this.ilSelectButtons.Images.SetKeyName(24, "fiona.png");
            this.ilSelectButtons.Images.SetKeyName(25, "HappyStar.png");
            this.ilSelectButtons.Images.SetKeyName(26, "HappySun.png");
            this.ilSelectButtons.Images.SetKeyName(27, "HappySun2.png");
            this.ilSelectButtons.Images.SetKeyName(28, "Luigi1.png");
            this.ilSelectButtons.Images.SetKeyName(29, "Luigi2.png");
            this.ilSelectButtons.Images.SetKeyName(30, "Mario1.png");
            this.ilSelectButtons.Images.SetKeyName(31, "Mario2.png");
            this.ilSelectButtons.Images.SetKeyName(32, "maximus.png");
            this.ilSelectButtons.Images.SetKeyName(33, "MikeWazowski1.png");
            this.ilSelectButtons.Images.SetKeyName(34, "MikeWazowski2.png");
            this.ilSelectButtons.Images.SetKeyName(35, "Olaf.png");
            this.ilSelectButtons.Images.SetKeyName(36, "Olaf2.png");
            this.ilSelectButtons.Images.SetKeyName(37, "qbert.png");
            this.ilSelectButtons.Images.SetKeyName(38, "RainbowStar.png");
            this.ilSelectButtons.Images.SetKeyName(39, "Rapunzel_pose.png");
            this.ilSelectButtons.Images.SetKeyName(40, "Shrek.png");
            this.ilSelectButtons.Images.SetKeyName(41, "SpongeBob.png");
            this.ilSelectButtons.Images.SetKeyName(42, "SpongeBob2.png");
            this.ilSelectButtons.Images.SetKeyName(43, "Steve.png");
            this.ilSelectButtons.Images.SetKeyName(44, "SunWoman.png");
            this.ilSelectButtons.Images.SetKeyName(45, "Sven.png");
            this.ilSelectButtons.Images.SetKeyName(46, "yoshi.png");
            this.ilSelectButtons.Images.SetKeyName(47, "Yoshi2.png");
            // 
            // btnSelect
            // 
            this.btnSelect.BackColor = System.Drawing.SystemColors.Control;
            this.btnSelect.ImageIndex = 0;
            this.btnSelect.ImageList = this.ilSelectButtons;
            this.btnSelect.Location = new System.Drawing.Point(3, 30);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(100, 100);
            this.btnSelect.TabIndex = 35;
            this.toolTip1.SetToolTip(this.btnSelect, "Select a Symbol below and then click me to confirm your selection.");
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(6, 14);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(104, 13);
            this.lblInfo.TabIndex = 0;
            this.lblInfo.Text = "Click here to Confirm";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btnSelect);
            this.splitContainer1.Panel1.Controls.Add(this.lblInfo);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.flowLayoutPanel1);
            this.splitContainer1.Size = new System.Drawing.Size(1008, 462);
            this.splitContainer1.SplitterDistance = 136;
            this.splitContainer1.TabIndex = 36;
            // 
            // frmSymbolSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 462);
            this.Controls.Add(this.splitContainer1);
            this.DoubleBuffered = true;
            this.Name = "frmSymbolSelector";
            this.Text = "Select Your Symbol";
            this.Load += new System.EventHandler(this.frmSymbolSelector_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.ImageList ilSelectButtons;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.SplitContainer splitContainer1;
    }
}