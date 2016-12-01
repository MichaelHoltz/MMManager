﻿namespace MMManager
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
            this.button1 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btnGenerateGrid = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.toolTipForm = new System.Windows.Forms.ToolTip(this.components);
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.mmmGroupBox1 = new MMManager.Controls.MMMGroupBox();
            this.mmManagerTTTButton1 = new MMManager.MMManagerTTTButton();
            this.bgGame = new MMManager.Controls.MMMGroupBox();
            this.mmManagerTTTButton2 = new MMManager.MMManagerTTTButton();
            this.groupBox1.SuspendLayout();
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
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(453, 41);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 51;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(545, 49);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 52;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
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
            // 
            // bgGame
            // 
            this.bgGame.AutoSize = true;
            this.bgGame.Location = new System.Drawing.Point(106, 170);
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
            this.ClientSize = new System.Drawing.Size(932, 542);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button2);
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
            this.groupBox1.ResumeLayout(false);
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
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button5;
    }
}