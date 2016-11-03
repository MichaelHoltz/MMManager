namespace MMManager
{
    partial class mainForm
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
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.btnFormTesting = new System.Windows.Forms.Button();
            this.btnModsSelector = new System.Windows.Forms.Button();
            this.gbVersion = new System.Windows.Forms.GroupBox();
            this.cbForgeVersion = new System.Windows.Forms.ComboBox();
            this.cbMCVersion = new System.Windows.Forms.ComboBox();
            this.lblForgeVersion = new System.Windows.Forms.Label();
            this.lblMCVersion = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.lblFileCount1 = new System.Windows.Forms.Label();
            this.lblPath1 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.lblFileCount2 = new System.Windows.Forms.Label();
            this.lblPath2 = new System.Windows.Forms.Label();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.gbArchive = new System.Windows.Forms.GroupBox();
            this.lblArchiveOptions = new System.Windows.Forms.Label();
            this.BtnArchive = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnShowBase = new System.Windows.Forms.Button();
            this.propertyGrid1 = new System.Windows.Forms.PropertyGrid();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.gbVersion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.gbArchive.SuspendLayout();
            this.SuspendLayout();
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.RootFolder = System.Environment.SpecialFolder.ApplicationData;
            this.folderBrowserDialog1.ShowNewFolderButton = false;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer2.Location = new System.Drawing.Point(1, 2);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.button2);
            this.splitContainer2.Panel1.Controls.Add(this.btnFormTesting);
            this.splitContainer2.Panel1.Controls.Add(this.btnModsSelector);
            this.splitContainer2.Panel1.Controls.Add(this.gbVersion);
            this.splitContainer2.Panel1.Controls.Add(this.splitContainer1);
            this.splitContainer2.Panel1.Controls.Add(this.gbArchive);
            this.splitContainer2.Panel1.Controls.Add(this.button1);
            this.splitContainer2.Panel1.Controls.Add(this.btnShowBase);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.propertyGrid1);
            this.splitContainer2.Size = new System.Drawing.Size(1115, 497);
            this.splitContainer2.SplitterDistance = 857;
            this.splitContainer2.TabIndex = 7;
            // 
            // btnFormTesting
            // 
            this.btnFormTesting.Location = new System.Drawing.Point(443, 44);
            this.btnFormTesting.Name = "btnFormTesting";
            this.btnFormTesting.Size = new System.Drawing.Size(82, 33);
            this.btnFormTesting.TabIndex = 12;
            this.btnFormTesting.Text = "Testing Form";
            this.btnFormTesting.UseVisualStyleBackColor = true;
            this.btnFormTesting.Click += new System.EventHandler(this.btnFormTesting_Click);
            // 
            // btnModsSelector
            // 
            this.btnModsSelector.Location = new System.Drawing.Point(441, 15);
            this.btnModsSelector.Name = "btnModsSelector";
            this.btnModsSelector.Size = new System.Drawing.Size(85, 23);
            this.btnModsSelector.TabIndex = 11;
            this.btnModsSelector.Text = "ModsSelector";
            this.btnModsSelector.UseVisualStyleBackColor = true;
            this.btnModsSelector.Click += new System.EventHandler(this.btnModsSelector_Click);
            // 
            // gbVersion
            // 
            this.gbVersion.Controls.Add(this.cbForgeVersion);
            this.gbVersion.Controls.Add(this.cbMCVersion);
            this.gbVersion.Controls.Add(this.lblForgeVersion);
            this.gbVersion.Controls.Add(this.lblMCVersion);
            this.gbVersion.Location = new System.Drawing.Point(6, 5);
            this.gbVersion.Name = "gbVersion";
            this.gbVersion.Size = new System.Drawing.Size(429, 72);
            this.gbVersion.TabIndex = 10;
            this.gbVersion.TabStop = false;
            this.gbVersion.Text = "Version Options";
            // 
            // cbForgeVersion
            // 
            this.cbForgeVersion.FormattingEnabled = true;
            this.cbForgeVersion.Location = new System.Drawing.Point(224, 36);
            this.cbForgeVersion.Name = "cbForgeVersion";
            this.cbForgeVersion.Size = new System.Drawing.Size(195, 21);
            this.cbForgeVersion.TabIndex = 3;
            // 
            // cbMCVersion
            // 
            this.cbMCVersion.FormattingEnabled = true;
            this.cbMCVersion.Items.AddRange(new object[] {
            "1.7.10",
            "1.10.7",
            "1.6.0"});
            this.cbMCVersion.Location = new System.Drawing.Point(10, 36);
            this.cbMCVersion.Name = "cbMCVersion";
            this.cbMCVersion.Size = new System.Drawing.Size(208, 21);
            this.cbMCVersion.TabIndex = 2;
            // 
            // lblForgeVersion
            // 
            this.lblForgeVersion.AutoSize = true;
            this.lblForgeVersion.Location = new System.Drawing.Point(221, 20);
            this.lblForgeVersion.Name = "lblForgeVersion";
            this.lblForgeVersion.Size = new System.Drawing.Size(72, 13);
            this.lblForgeVersion.TabIndex = 1;
            this.lblForgeVersion.Text = "Forge Version";
            // 
            // lblMCVersion
            // 
            this.lblMCVersion.AutoSize = true;
            this.lblMCVersion.Location = new System.Drawing.Point(7, 20);
            this.lblMCVersion.Name = "lblMCVersion";
            this.lblMCVersion.Size = new System.Drawing.Size(61, 13);
            this.lblMCVersion.TabIndex = 0;
            this.lblMCVersion.Text = "MC Version";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Location = new System.Drawing.Point(6, 208);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.splitContainer1.Panel1.Controls.Add(this.lblFileCount1);
            this.splitContainer1.Panel1.Controls.Add(this.lblPath1);
            this.splitContainer1.Panel1.Controls.Add(this.listBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.splitContainer1.Panel2.Controls.Add(this.lblFileCount2);
            this.splitContainer1.Panel2.Controls.Add(this.lblPath2);
            this.splitContainer1.Panel2.Controls.Add(this.listBox2);
            this.splitContainer1.Size = new System.Drawing.Size(849, 270);
            this.splitContainer1.SplitterDistance = 391;
            this.splitContainer1.TabIndex = 9;
            // 
            // lblFileCount1
            // 
            this.lblFileCount1.AutoSize = true;
            this.lblFileCount1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblFileCount1.Location = new System.Drawing.Point(0, 255);
            this.lblFileCount1.Name = "lblFileCount1";
            this.lblFileCount1.Size = new System.Drawing.Size(31, 13);
            this.lblFileCount1.TabIndex = 2;
            this.lblFileCount1.Text = "Files:";
            // 
            // lblPath1
            // 
            this.lblPath1.AutoSize = true;
            this.lblPath1.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblPath1.Location = new System.Drawing.Point(0, 0);
            this.lblPath1.Name = "lblPath1";
            this.lblPath1.Size = new System.Drawing.Size(0, 13);
            this.lblPath1.TabIndex = 1;
            // 
            // listBox1
            // 
            this.listBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(0, 20);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(390, 212);
            this.listBox1.TabIndex = 0;
            // 
            // lblFileCount2
            // 
            this.lblFileCount2.AutoSize = true;
            this.lblFileCount2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblFileCount2.Location = new System.Drawing.Point(0, 255);
            this.lblFileCount2.Name = "lblFileCount2";
            this.lblFileCount2.Size = new System.Drawing.Size(34, 13);
            this.lblFileCount2.TabIndex = 3;
            this.lblFileCount2.Text = "Files: ";
            // 
            // lblPath2
            // 
            this.lblPath2.AutoSize = true;
            this.lblPath2.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblPath2.Location = new System.Drawing.Point(0, 0);
            this.lblPath2.Name = "lblPath2";
            this.lblPath2.Size = new System.Drawing.Size(0, 13);
            this.lblPath2.TabIndex = 2;
            // 
            // listBox2
            // 
            this.listBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(0, 20);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(453, 212);
            this.listBox2.TabIndex = 0;
            // 
            // gbArchive
            // 
            this.gbArchive.Controls.Add(this.lblArchiveOptions);
            this.gbArchive.Controls.Add(this.BtnArchive);
            this.gbArchive.Location = new System.Drawing.Point(12, 109);
            this.gbArchive.Name = "gbArchive";
            this.gbArchive.Size = new System.Drawing.Size(390, 49);
            this.gbArchive.TabIndex = 8;
            this.gbArchive.TabStop = false;
            this.gbArchive.Text = "Archive Options";
            // 
            // lblArchiveOptions
            // 
            this.lblArchiveOptions.AutoSize = true;
            this.lblArchiveOptions.Location = new System.Drawing.Point(115, 20);
            this.lblArchiveOptions.Name = "lblArchiveOptions";
            this.lblArchiveOptions.Size = new System.Drawing.Size(166, 13);
            this.lblArchiveOptions.TabIndex = 5;
            this.lblArchiveOptions.Text = "Automatically Copy all current files";
            // 
            // BtnArchive
            // 
            this.BtnArchive.Location = new System.Drawing.Point(6, 19);
            this.BtnArchive.Name = "BtnArchive";
            this.BtnArchive.Size = new System.Drawing.Size(75, 23);
            this.BtnArchive.TabIndex = 4;
            this.BtnArchive.Text = "Archive";
            this.BtnArchive.UseVisualStyleBackColor = true;
            this.BtnArchive.Click += new System.EventHandler(this.BtnArchive_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 164);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnShowBase
            // 
            this.btnShowBase.Location = new System.Drawing.Point(127, 164);
            this.btnShowBase.Name = "btnShowBase";
            this.btnShowBase.Size = new System.Drawing.Size(75, 23);
            this.btnShowBase.TabIndex = 6;
            this.btnShowBase.Text = "Show Base";
            this.btnShowBase.UseVisualStyleBackColor = true;
            this.btnShowBase.Click += new System.EventHandler(this.btnShowBase_Click);
            // 
            // propertyGrid1
            // 
            this.propertyGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.propertyGrid1.Location = new System.Drawing.Point(0, 0);
            this.propertyGrid1.Name = "propertyGrid1";
            this.propertyGrid1.PropertySort = System.Windows.Forms.PropertySort.Alphabetical;
            this.propertyGrid1.SelectedObject = this.folderBrowserDialog1;
            this.propertyGrid1.Size = new System.Drawing.Size(254, 497);
            this.propertyGrid1.TabIndex = 7;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(567, 63);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(92, 33);
            this.button2.TabIndex = 13;
            this.button2.Text = "Save JSON";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1118, 511);
            this.Controls.Add(this.splitContainer2);
            this.DoubleBuffered = true;
            this.Name = "mainForm";
            this.Text = "MMManager";
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.gbVersion.ResumeLayout(false);
            this.gbVersion.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.gbArchive.ResumeLayout(false);
            this.gbArchive.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label lblPath1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label lblPath2;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.GroupBox gbArchive;
        private System.Windows.Forms.Button BtnArchive;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnShowBase;
        private System.Windows.Forms.PropertyGrid propertyGrid1;
        private System.Windows.Forms.Label lblFileCount1;
        private System.Windows.Forms.Label lblFileCount2;
        private System.Windows.Forms.GroupBox gbVersion;
        private System.Windows.Forms.ComboBox cbForgeVersion;
        private System.Windows.Forms.ComboBox cbMCVersion;
        private System.Windows.Forms.Label lblForgeVersion;
        private System.Windows.Forms.Label lblMCVersion;
        private System.Windows.Forms.Button btnModsSelector;
        private System.Windows.Forms.Label lblArchiveOptions;
        private System.Windows.Forms.Button btnFormTesting;
        private System.Windows.Forms.Button button2;
    }
}

