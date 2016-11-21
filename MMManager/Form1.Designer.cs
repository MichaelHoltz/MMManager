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
            this.tbUserName = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnTestFill = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.ticTacToeBoard1 = new MMManager.GameControls.TicTacToeBoard();
            this.button3 = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // tbUserName
            // 
            this.tbUserName.Location = new System.Drawing.Point(22, 22);
            this.tbUserName.Name = "tbUserName";
            this.tbUserName.Size = new System.Drawing.Size(75, 20);
            this.tbUserName.TabIndex = 13;
            this.tbUserName.Text = "Michael";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(782, 10);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(53, 32);
            this.btnUpdate.TabIndex = 14;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(841, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 32);
            this.button1.TabIndex = 16;
            this.button1.Text = "Save Image";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnTestFill
            // 
            this.btnTestFill.Location = new System.Drawing.Point(131, 12);
            this.btnTestFill.Name = "btnTestFill";
            this.btnTestFill.Size = new System.Drawing.Size(69, 33);
            this.btnTestFill.TabIndex = 18;
            this.btnTestFill.Text = "Test Fill";
            this.btnTestFill.UseVisualStyleBackColor = true;
            this.btnTestFill.Click += new System.EventHandler(this.btnTestFill_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(219, 17);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(57, 28);
            this.button2.TabIndex = 20;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ticTacToeBoard1
            // 
            this.ticTacToeBoard1.AutoSize = true;
            this.ticTacToeBoard1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ticTacToeBoard1.Location = new System.Drawing.Point(291, 22);
            this.ticTacToeBoard1.Name = "ticTacToeBoard1";
            this.ticTacToeBoard1.ServiceProvider = null;
            this.ticTacToeBoard1.Size = new System.Drawing.Size(221, 461);
            this.ticTacToeBoard1.TabIndex = 24;
            // 
            // button3
            // 
            this.button3.ImageIndex = 0;
            this.button3.ImageList = this.imageList1;
            this.button3.Location = new System.Drawing.Point(700, 269);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 34);
            this.button3.TabIndex = 25;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "messageboxerror.ico");
            this.imageList1.Images.SetKeyName(1, "ModifiedTelespace.ico");
            this.imageList1.Images.SetKeyName(2, "StatusDoNotDisturb.ico");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1025, 696);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.ticTacToeBoard1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnTestFill);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.tbUserName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbUserName;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnTestFill;
        private System.Windows.Forms.Button button2;
        private GameControls.TicTacToeBoard ticTacToeBoard1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ImageList imageList1;
    }
}

