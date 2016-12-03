namespace MMManager
{
    partial class frmTesting
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTesting));
            this.button1 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btnGenerateGrid = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.toolTipForm = new System.Windows.Forms.ToolTip(this.components);
            this.button5 = new System.Windows.Forms.Button();
            this.pbBackGround = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this._ButtonImageList = new System.Windows.Forms.ImageList(this.components);
            this.BBomb = new MMManager.MMManagerTTTButton();
            this.mmmGroupBox1 = new MMManager.Controls.MMMGroupBox();
            this.mmManagerTTTButton1 = new MMManager.MMManagerTTTButton();
            this.bgGame = new MMManager.Controls.MMMGroupBox();
            this.mmManagerTTTButton2 = new MMManager.MMManagerTTTButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBackGround)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(61, 30);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Image Files|*.png|All files|*.*";
            this.openFileDialog1.InitialDirectory = "c:\\MMManager\\";
            this.openFileDialog1.Title = "Select Image";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(103, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.mmManagerTTTButton2);
            this.groupBox1.Location = new System.Drawing.Point(673, 191);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(226, 204);
            this.groupBox1.TabIndex = 44;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(41, 138);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 45;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(128, 83);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 44;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // btnGenerateGrid
            // 
            this.btnGenerateGrid.Location = new System.Drawing.Point(12, 111);
            this.btnGenerateGrid.Name = "btnGenerateGrid";
            this.btnGenerateGrid.Size = new System.Drawing.Size(75, 41);
            this.btnGenerateGrid.TabIndex = 46;
            this.btnGenerateGrid.Text = "Generate Grid";
            this.btnGenerateGrid.UseVisualStyleBackColor = true;
            this.btnGenerateGrid.Click += new System.EventHandler(this.btnGenerateGrid_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(372, 85);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 52;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // pbBackGround
            // 
            this.pbBackGround.BackgroundImage = global::MMManager.Properties.Resources.Metal_plate_HD_pictures_9_40832_250x250;
            this.pbBackGround.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbBackGround.Location = new System.Drawing.Point(109, 98);
            this.pbBackGround.Name = "pbBackGround";
            this.pbBackGround.Size = new System.Drawing.Size(250, 250);
            this.pbBackGround.TabIndex = 53;
            this.pbBackGround.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox2.Location = new System.Drawing.Point(673, 18);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(194, 167);
            this.pictureBox2.TabIndex = 45;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::MMManager.Properties.Resources.BrushedPlat;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(103, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(344, 61);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // _ButtonImageList
            // 
            this._ButtonImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("_ButtonImageList.ImageStream")));
            this._ButtonImageList.TransparentColor = System.Drawing.Color.Transparent;
            this._ButtonImageList.Images.SetKeyName(0, "Blank0.png");
            this._ButtonImageList.Images.SetKeyName(1, "Blank1.png");
            this._ButtonImageList.Images.SetKeyName(2, "Blank2.png");
            this._ButtonImageList.Images.SetKeyName(3, "Blank3.png");
            this._ButtonImageList.Images.SetKeyName(4, "Blank4.png");
            this._ButtonImageList.Images.SetKeyName(5, "Blank5.png");
            this._ButtonImageList.Images.SetKeyName(6, "Blank6.png");
            this._ButtonImageList.Images.SetKeyName(7, "Blank7.png");
            this._ButtonImageList.Images.SetKeyName(8, "Blank8.png");
            this._ButtonImageList.Images.SetKeyName(9, "Blank9.png");
            this._ButtonImageList.Images.SetKeyName(10, "3DWireFrame.png");
            this._ButtonImageList.Images.SetKeyName(11, "32WireFrame2.png");
            this._ButtonImageList.Images.SetKeyName(12, "Anna.png");
            this._ButtonImageList.Images.SetKeyName(13, "BraveBrothers1.png");
            this._ButtonImageList.Images.SetKeyName(14, "BraveBrothers2.png");
            this._ButtonImageList.Images.SetKeyName(15, "BraveBrothers3.png");
            this._ButtonImageList.Images.SetKeyName(16, "Coffee-Cup1.png");
            this._ButtonImageList.Images.SetKeyName(17, "Creeper.png");
            this._ButtonImageList.Images.SetKeyName(18, "cupcake1.png");
            this._ButtonImageList.Images.SetKeyName(19, "cupcake2.png");
            this._ButtonImageList.Images.SetKeyName(20, "DarthVader.png");
            this._ButtonImageList.Images.SetKeyName(21, "deadpool-logo.png");
            this._ButtonImageList.Images.SetKeyName(22, "DeathStar.png");
            this._ButtonImageList.Images.SetKeyName(23, "Elsa1.png");
            this._ButtonImageList.Images.SetKeyName(24, "fiona.png");
            this._ButtonImageList.Images.SetKeyName(25, "HappyStar.png");
            this._ButtonImageList.Images.SetKeyName(26, "HappySun.png");
            this._ButtonImageList.Images.SetKeyName(27, "HappySun2.png");
            this._ButtonImageList.Images.SetKeyName(28, "Luigi1.png");
            this._ButtonImageList.Images.SetKeyName(29, "Luigi2.png");
            this._ButtonImageList.Images.SetKeyName(30, "Mario1.png");
            this._ButtonImageList.Images.SetKeyName(31, "Mario2.png");
            this._ButtonImageList.Images.SetKeyName(32, "maximus.png");
            this._ButtonImageList.Images.SetKeyName(33, "MikeWazowski1.png");
            this._ButtonImageList.Images.SetKeyName(34, "MikeWazowski2.png");
            this._ButtonImageList.Images.SetKeyName(35, "Olaf.png");
            this._ButtonImageList.Images.SetKeyName(36, "Olaf2.png");
            this._ButtonImageList.Images.SetKeyName(37, "qbert.png");
            this._ButtonImageList.Images.SetKeyName(38, "RainbowStar.png");
            this._ButtonImageList.Images.SetKeyName(39, "Rapunzel_pose.png");
            this._ButtonImageList.Images.SetKeyName(40, "Shrek.png");
            this._ButtonImageList.Images.SetKeyName(41, "SpongeBob.png");
            this._ButtonImageList.Images.SetKeyName(42, "SpongeBob2.png");
            this._ButtonImageList.Images.SetKeyName(43, "Steve.png");
            this._ButtonImageList.Images.SetKeyName(44, "SunWoman.png");
            this._ButtonImageList.Images.SetKeyName(45, "Sven.png");
            this._ButtonImageList.Images.SetKeyName(46, "yoshi.png");
            this._ButtonImageList.Images.SetKeyName(47, "Yoshi2.png");
            // 
            // BBomb
            // 
            this.BBomb.allowClick = true;
            this.BBomb.customEnable = true;
            this.BBomb.Location = new System.Drawing.Point(455, 152);
            this.BBomb.Name = "BBomb";
            this.BBomb.Size = new System.Drawing.Size(50, 50);
            this.BBomb.TabIndex = 54;
            this.BBomb.UseVisualStyleBackColor = true;
            this.BBomb.Click += new System.EventHandler(this.BBomb_Click);
            // 
            // mmmGroupBox1
            // 
            this.mmmGroupBox1.Location = new System.Drawing.Point(27, 242);
            this.mmmGroupBox1.Name = "mmmGroupBox1";
            this.mmmGroupBox1.Size = new System.Drawing.Size(76, 87);
            this.mmmGroupBox1.TabIndex = 50;
            this.mmmGroupBox1.TabStop = false;
            this.mmmGroupBox1.Text = "mmmGroupBox1";
            // 
            // mmManagerTTTButton1
            // 
            this.mmManagerTTTButton1.allowClick = true;
            this.mmManagerTTTButton1.BackColor = System.Drawing.Color.DarkViolet;
            this.mmManagerTTTButton1.customEnable = true;
            this.mmManagerTTTButton1.FlatAppearance.BorderSize = 0;
            this.mmManagerTTTButton1.Location = new System.Drawing.Point(12, 170);
            this.mmManagerTTTButton1.Margin = new System.Windows.Forms.Padding(0);
            this.mmManagerTTTButton1.Name = "mmManagerTTTButton1";
            this.mmManagerTTTButton1.Size = new System.Drawing.Size(75, 33);
            this.mmManagerTTTButton1.TabIndex = 49;
            this.mmManagerTTTButton1.Text = "mmManagerTTTButton1";
            this.mmManagerTTTButton1.UseVisualStyleBackColor = true;
            this.mmManagerTTTButton1.Click += new System.EventHandler(this.mmManagerTTTButton1_Click);
            // 
            // bgGame
            // 
            this.bgGame.AutoSize = true;
            this.bgGame.Location = new System.Drawing.Point(109, 354);
            this.bgGame.Name = "bgGame";
            this.bgGame.Size = new System.Drawing.Size(452, 215);
            this.bgGame.TabIndex = 47;
            this.bgGame.TabStop = false;
            this.bgGame.Text = "Button Grid";
            // 
            // mmManagerTTTButton2
            // 
            this.mmManagerTTTButton2.allowClick = true;
            this.mmManagerTTTButton2.customEnable = true;
            this.mmManagerTTTButton2.Location = new System.Drawing.Point(22, 19);
            this.mmManagerTTTButton2.Name = "mmManagerTTTButton2";
            this.mmManagerTTTButton2.Size = new System.Drawing.Size(50, 50);
            this.mmManagerTTTButton2.TabIndex = 42;
            this.mmManagerTTTButton2.Text = "mmManagerTTTButton2";
            this.mmManagerTTTButton2.UseVisualStyleBackColor = true;
            // 
            // frmTesting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 701);
            this.Controls.Add(this.BBomb);
            this.Controls.Add(this.pbBackGround);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.mmmGroupBox1);
            this.Controls.Add(this.mmManagerTTTButton1);
            this.Controls.Add(this.bgGame);
            this.Controls.Add(this.btnGenerateGrid);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Name = "frmTesting";
            this.Text = "frmTesting";
            this.Load += new System.EventHandler(this.frmTesting_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbBackGround)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private MMManagerTTTButton mmManagerTTTButton2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnGenerateGrid;
        private Controls.MMMGroupBox bgGame;
        private System.Windows.Forms.Timer timer1;
        private MMManagerTTTButton mmManagerTTTButton1;
        private System.Windows.Forms.ToolTip toolTipForm;
        private Controls.MMMGroupBox mmmGroupBox1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.PictureBox pbBackGround;
        private MMManagerTTTButton BBomb;
        public System.Windows.Forms.ImageList _ButtonImageList;
    }
}