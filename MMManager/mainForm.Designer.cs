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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.btnSoloTicTacToe = new System.Windows.Forms.Button();
            this.btnChatForm = new System.Windows.Forms.Button();
            this.btnApplicationSettings = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbMinecraftProfiles = new System.Windows.Forms.ComboBox();
            this.lblMinecraftProfiles = new System.Windows.Forms.Label();
            this.btnBrowseInstance = new System.Windows.Forms.Button();
            this.lblInstanceName = new System.Windows.Forms.Label();
            this.cbInstanceName = new System.Windows.Forms.ComboBox();
            this.tbPeerLocation = new System.Windows.Forms.TextBox();
            this.lblPeerLocation = new System.Windows.Forms.Label();
            this.tbPeerName = new System.Windows.Forms.TextBox();
            this.lblPeerName = new System.Windows.Forms.Label();
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
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lblArchiveOptions = new System.Windows.Forms.Label();
            this.BtnArchive = new System.Windows.Forms.Button();
            this.propertyGrid1 = new System.Windows.Forms.PropertyGrid();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
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
            this.splitContainer2.Panel1.Controls.Add(this.btnSoloTicTacToe);
            this.splitContainer2.Panel1.Controls.Add(this.btnChatForm);
            this.splitContainer2.Panel1.Controls.Add(this.btnApplicationSettings);
            this.splitContainer2.Panel1.Controls.Add(this.label2);
            this.splitContainer2.Panel1.Controls.Add(this.label1);
            this.splitContainer2.Panel1.Controls.Add(this.cbMinecraftProfiles);
            this.splitContainer2.Panel1.Controls.Add(this.lblMinecraftProfiles);
            this.splitContainer2.Panel1.Controls.Add(this.btnBrowseInstance);
            this.splitContainer2.Panel1.Controls.Add(this.lblInstanceName);
            this.splitContainer2.Panel1.Controls.Add(this.cbInstanceName);
            this.splitContainer2.Panel1.Controls.Add(this.tbPeerLocation);
            this.splitContainer2.Panel1.Controls.Add(this.lblPeerLocation);
            this.splitContainer2.Panel1.Controls.Add(this.tbPeerName);
            this.splitContainer2.Panel1.Controls.Add(this.lblPeerName);
            this.splitContainer2.Panel1.Controls.Add(this.btnFormTesting);
            this.splitContainer2.Panel1.Controls.Add(this.btnModsSelector);
            this.splitContainer2.Panel1.Controls.Add(this.gbVersion);
            this.splitContainer2.Panel1.Controls.Add(this.splitContainer1);
            this.splitContainer2.Panel1.Controls.Add(this.gbArchive);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.propertyGrid1);
            this.splitContainer2.Size = new System.Drawing.Size(1115, 752);
            this.splitContainer2.SplitterDistance = 857;
            this.splitContainer2.TabIndex = 7;
            // 
            // btnSoloTicTacToe
            // 
            this.btnSoloTicTacToe.Location = new System.Drawing.Point(527, 56);
            this.btnSoloTicTacToe.Name = "btnSoloTicTacToe";
            this.btnSoloTicTacToe.Size = new System.Drawing.Size(110, 35);
            this.btnSoloTicTacToe.TabIndex = 30;
            this.btnSoloTicTacToe.Text = "TicTacToeSolo";
            this.btnSoloTicTacToe.UseVisualStyleBackColor = true;
            this.btnSoloTicTacToe.Click += new System.EventHandler(this.btnSoloTicTacToe_Click);
            // 
            // btnChatForm
            // 
            this.btnChatForm.Location = new System.Drawing.Point(527, 14);
            this.btnChatForm.Name = "btnChatForm";
            this.btnChatForm.Size = new System.Drawing.Size(110, 35);
            this.btnChatForm.TabIndex = 29;
            this.btnChatForm.Text = "Chat Tic Tac Toe";
            this.btnChatForm.UseVisualStyleBackColor = true;
            this.btnChatForm.Click += new System.EventHandler(this.btnChatForm_Click);
            // 
            // btnApplicationSettings
            // 
            this.btnApplicationSettings.Location = new System.Drawing.Point(738, 14);
            this.btnApplicationSettings.Name = "btnApplicationSettings";
            this.btnApplicationSettings.Size = new System.Drawing.Size(114, 33);
            this.btnApplicationSettings.TabIndex = 28;
            this.btnApplicationSettings.Text = "Application Settings";
            this.btnApplicationSettings.UseVisualStyleBackColor = true;
            this.btnApplicationSettings.Click += new System.EventHandler(this.btnApplicationSettings_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 186);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "label1";
            // 
            // cbMinecraftProfiles
            // 
            this.cbMinecraftProfiles.FormattingEnabled = true;
            this.cbMinecraftProfiles.Location = new System.Drawing.Point(17, 133);
            this.cbMinecraftProfiles.Name = "cbMinecraftProfiles";
            this.cbMinecraftProfiles.Size = new System.Drawing.Size(170, 21);
            this.cbMinecraftProfiles.TabIndex = 25;
            this.cbMinecraftProfiles.SelectedIndexChanged += new System.EventHandler(this.cbMinecraftProfiles_SelectedIndexChanged);
            // 
            // lblMinecraftProfiles
            // 
            this.lblMinecraftProfiles.AutoSize = true;
            this.lblMinecraftProfiles.Location = new System.Drawing.Point(14, 116);
            this.lblMinecraftProfiles.Name = "lblMinecraftProfiles";
            this.lblMinecraftProfiles.Size = new System.Drawing.Size(88, 13);
            this.lblMinecraftProfiles.TabIndex = 24;
            this.lblMinecraftProfiles.Text = "Minecraft Profiles";
            // 
            // btnBrowseInstance
            // 
            this.btnBrowseInstance.Location = new System.Drawing.Point(177, 61);
            this.btnBrowseInstance.Name = "btnBrowseInstance";
            this.btnBrowseInstance.Size = new System.Drawing.Size(28, 23);
            this.btnBrowseInstance.TabIndex = 23;
            this.btnBrowseInstance.Text = "...";
            this.toolTip1.SetToolTip(this.btnBrowseInstance, "Open Folder in Explorer");
            this.btnBrowseInstance.UseVisualStyleBackColor = true;
            this.btnBrowseInstance.Click += new System.EventHandler(this.btnBrowseInstance_Click);
            // 
            // lblInstanceName
            // 
            this.lblInstanceName.AutoSize = true;
            this.lblInstanceName.Location = new System.Drawing.Point(13, 47);
            this.lblInstanceName.Name = "lblInstanceName";
            this.lblInstanceName.Size = new System.Drawing.Size(79, 13);
            this.lblInstanceName.TabIndex = 22;
            this.lblInstanceName.Text = "Instance Name";
            // 
            // cbInstanceName
            // 
            this.cbInstanceName.FormattingEnabled = true;
            this.cbInstanceName.Location = new System.Drawing.Point(17, 63);
            this.cbInstanceName.Name = "cbInstanceName";
            this.cbInstanceName.Size = new System.Drawing.Size(154, 21);
            this.cbInstanceName.TabIndex = 21;
            // 
            // tbPeerLocation
            // 
            this.tbPeerLocation.Location = new System.Drawing.Point(261, 11);
            this.tbPeerLocation.Name = "tbPeerLocation";
            this.tbPeerLocation.Size = new System.Drawing.Size(127, 20);
            this.tbPeerLocation.TabIndex = 20;
            this.tbPeerLocation.TextChanged += new System.EventHandler(this.tbPeerLocation_TextChanged);
            // 
            // lblPeerLocation
            // 
            this.lblPeerLocation.AutoSize = true;
            this.lblPeerLocation.Location = new System.Drawing.Point(206, 14);
            this.lblPeerLocation.Name = "lblPeerLocation";
            this.lblPeerLocation.Size = new System.Drawing.Size(48, 13);
            this.lblPeerLocation.TabIndex = 19;
            this.lblPeerLocation.Text = "Location";
            // 
            // tbPeerName
            // 
            this.tbPeerName.Location = new System.Drawing.Point(54, 8);
            this.tbPeerName.Name = "tbPeerName";
            this.tbPeerName.Size = new System.Drawing.Size(133, 20);
            this.tbPeerName.TabIndex = 16;
            this.tbPeerName.TextChanged += new System.EventHandler(this.tbPeerName_TextChanged);
            // 
            // lblPeerName
            // 
            this.lblPeerName.AutoSize = true;
            this.lblPeerName.Location = new System.Drawing.Point(14, 11);
            this.lblPeerName.Name = "lblPeerName";
            this.lblPeerName.Size = new System.Drawing.Size(35, 13);
            this.lblPeerName.TabIndex = 15;
            this.lblPeerName.Text = "Name";
            // 
            // btnFormTesting
            // 
            this.btnFormTesting.Location = new System.Drawing.Point(738, 102);
            this.btnFormTesting.Name = "btnFormTesting";
            this.btnFormTesting.Size = new System.Drawing.Size(114, 33);
            this.btnFormTesting.TabIndex = 12;
            this.btnFormTesting.Text = "Testing Form";
            this.btnFormTesting.UseVisualStyleBackColor = true;
            this.btnFormTesting.Click += new System.EventHandler(this.btnFormTesting_Click);
            // 
            // btnModsSelector
            // 
            this.btnModsSelector.Location = new System.Drawing.Point(738, 58);
            this.btnModsSelector.Name = "btnModsSelector";
            this.btnModsSelector.Size = new System.Drawing.Size(114, 33);
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
            this.gbVersion.Location = new System.Drawing.Point(17, 218);
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
            this.splitContainer1.Location = new System.Drawing.Point(6, 497);
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
            this.splitContainer1.Size = new System.Drawing.Size(849, 236);
            this.splitContainer1.SplitterDistance = 391;
            this.splitContainer1.TabIndex = 9;
            // 
            // lblFileCount1
            // 
            this.lblFileCount1.AutoSize = true;
            this.lblFileCount1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblFileCount1.Location = new System.Drawing.Point(0, 221);
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
            this.lblPath1.Size = new System.Drawing.Size(33, 13);
            this.lblPath1.TabIndex = 1;
            this.lblPath1.Text = "Mods";
            // 
            // listBox1
            // 
            this.listBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(0, 20);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(390, 186);
            this.listBox1.TabIndex = 0;
            // 
            // lblFileCount2
            // 
            this.lblFileCount2.AutoSize = true;
            this.lblFileCount2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblFileCount2.Location = new System.Drawing.Point(0, 221);
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
            this.lblPath2.Size = new System.Drawing.Size(37, 13);
            this.lblPath2.TabIndex = 2;
            this.lblPath2.Text = "Saves";
            // 
            // listBox2
            // 
            this.listBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(0, 20);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(453, 186);
            this.listBox2.TabIndex = 0;
            // 
            // gbArchive
            // 
            this.gbArchive.Controls.Add(this.label3);
            this.gbArchive.Controls.Add(this.button1);
            this.gbArchive.Controls.Add(this.lblArchiveOptions);
            this.gbArchive.Controls.Add(this.BtnArchive);
            this.gbArchive.Location = new System.Drawing.Point(17, 410);
            this.gbArchive.Name = "gbArchive";
            this.gbArchive.Size = new System.Drawing.Size(631, 81);
            this.gbArchive.TabIndex = 8;
            this.gbArchive.TabStop = false;
            this.gbArchive.Text = "Archive Options";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(126, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "label3";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 48);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblArchiveOptions
            // 
            this.lblArchiveOptions.AutoSize = true;
            this.lblArchiveOptions.Location = new System.Drawing.Point(126, 25);
            this.lblArchiveOptions.Name = "lblArchiveOptions";
            this.lblArchiveOptions.Size = new System.Drawing.Size(254, 13);
            this.lblArchiveOptions.TabIndex = 5;
            this.lblArchiveOptions.Text = "Automatically Copy all current files to Dated Location";
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
            // propertyGrid1
            // 
            this.propertyGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.propertyGrid1.Location = new System.Drawing.Point(0, 0);
            this.propertyGrid1.Name = "propertyGrid1";
            this.propertyGrid1.PropertySort = System.Windows.Forms.PropertySort.Alphabetical;
            this.propertyGrid1.Size = new System.Drawing.Size(254, 752);
            this.propertyGrid1.TabIndex = 7;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1118, 766);
            this.Controls.Add(this.splitContainer2);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "mainForm";
            this.Text = "MMManager";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.mainForm_FormClosing);
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
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
        private System.Windows.Forms.Label lblPeerName;
        private System.Windows.Forms.TextBox tbPeerName;
        private System.Windows.Forms.TextBox tbPeerLocation;
        private System.Windows.Forms.Label lblPeerLocation;
        private System.Windows.Forms.Label lblInstanceName;
        private System.Windows.Forms.ComboBox cbInstanceName;
        private System.Windows.Forms.Button btnBrowseInstance;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ComboBox cbMinecraftProfiles;
        private System.Windows.Forms.Label lblMinecraftProfiles;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnApplicationSettings;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnChatForm;
        private System.Windows.Forms.Button btnSoloTicTacToe;
    }
}

