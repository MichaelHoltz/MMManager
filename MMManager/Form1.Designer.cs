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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.domainUpDown1 = new System.Windows.Forms.DomainUpDown();
            this.btnSpectator = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.mmManagerTTTButton1 = new MMManager.MMManagerTTTButton();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.ImageIndex = 0;
            this.button1.ImageList = this.imageList1;
            this.button1.Location = new System.Drawing.Point(21, 23);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(30, 30);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "blank.jpg");
            this.imageList1.Images.SetKeyName(1, "fuseBombCrop.jpg");
            this.imageList1.Images.SetKeyName(2, "fuseBombCropExplode.jpg");
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(168, 23);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox1.Location = new System.Drawing.Point(169, 49);
            this.groupBox1.MinimumSize = new System.Drawing.Size(150, 150);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(150, 150);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tic Tac Toe";
            // 
            // timer2
            // 
            this.timer2.Interval = 500;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // domainUpDown1
            // 
            this.domainUpDown1.Items.Add("10");
            this.domainUpDown1.Items.Add("3");
            this.domainUpDown1.Items.Add("4");
            this.domainUpDown1.Items.Add("5");
            this.domainUpDown1.Items.Add("6");
            this.domainUpDown1.Items.Add("7");
            this.domainUpDown1.Items.Add("8");
            this.domainUpDown1.Items.Add("9");
            this.domainUpDown1.Location = new System.Drawing.Point(249, 23);
            this.domainUpDown1.Name = "domainUpDown1";
            this.domainUpDown1.ReadOnly = true;
            this.domainUpDown1.Size = new System.Drawing.Size(38, 20);
            this.domainUpDown1.TabIndex = 4;
            this.domainUpDown1.Text = "3";
            // 
            // btnSpectator
            // 
            this.btnSpectator.Location = new System.Drawing.Point(23, 80);
            this.btnSpectator.Name = "btnSpectator";
            this.btnSpectator.Size = new System.Drawing.Size(107, 28);
            this.btnSpectator.TabIndex = 5;
            this.btnSpectator.Text = "Spectator";
            this.btnSpectator.UseVisualStyleBackColor = true;
            this.btnSpectator.Click += new System.EventHandler(this.btnSpectator_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(23, 114);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(61, 35);
            this.button4.TabIndex = 6;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // mmManagerTTTButton1
            // 
            this.mmManagerTTTButton1.allowClick = true;
            this.mmManagerTTTButton1.customEnable = false;
            this.mmManagerTTTButton1.Location = new System.Drawing.Point(39, 181);
            this.mmManagerTTTButton1.Name = "mmManagerTTTButton1";
            this.mmManagerTTTButton1.Size = new System.Drawing.Size(91, 40);
            this.mmManagerTTTButton1.TabIndex = 7;
            this.mmManagerTTTButton1.Text = "mmManagerTTTButton1";
            this.mmManagerTTTButton1.UseVisualStyleBackColor = true;
            this.mmManagerTTTButton1.Click += new System.EventHandler(this.mmManagerTTTButton1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(166, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(673, 455);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mmManagerTTTButton1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnSpectator);
            this.Controls.Add(this.domainUpDown1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.DomainUpDown domainUpDown1;
        private System.Windows.Forms.Button btnSpectator;
        private System.Windows.Forms.Button button4;
        private MMManagerTTTButton mmManagerTTTButton1;
        private System.Windows.Forms.Label label1;
    }
}

