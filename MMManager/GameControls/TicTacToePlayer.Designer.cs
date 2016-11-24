namespace MMManager.GameControls
{
    partial class TicTacToePlayer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TicTacToePlayer));
            this.lblNameLabel = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblSymbolLabel = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblSymbol = new System.Windows.Forms.Label();
            this._ButtonImageList = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // lblNameLabel
            // 
            this.lblNameLabel.AutoSize = true;
            this.lblNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.lblNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameLabel.Location = new System.Drawing.Point(5, 6);
            this.lblNameLabel.Name = "lblNameLabel";
            this.lblNameLabel.Size = new System.Drawing.Size(39, 13);
            this.lblNameLabel.TabIndex = 0;
            this.lblNameLabel.Text = "Name";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Location = new System.Drawing.Point(5, 19);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(53, 13);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Unknown";
            // 
            // lblSymbolLabel
            // 
            this.lblSymbolLabel.AutoSize = true;
            this.lblSymbolLabel.BackColor = System.Drawing.Color.Transparent;
            this.lblSymbolLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSymbolLabel.Location = new System.Drawing.Point(126, 6);
            this.lblSymbolLabel.Name = "lblSymbolLabel";
            this.lblSymbolLabel.Size = new System.Drawing.Size(47, 13);
            this.lblSymbolLabel.TabIndex = 2;
            this.lblSymbolLabel.Text = "Symbol";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.BackColor = System.Drawing.Color.Transparent;
            this.lblStatus.Location = new System.Drawing.Point(5, 56);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(53, 13);
            this.lblStatus.TabIndex = 4;
            this.lblStatus.Text = "Unknown";
            // 
            // lblSymbol
            // 
            this.lblSymbol.BackColor = System.Drawing.Color.Transparent;
            this.lblSymbol.Location = new System.Drawing.Point(137, 25);
            this.lblSymbol.Name = "lblSymbol";
            this.lblSymbol.Size = new System.Drawing.Size(25, 25);
            this.lblSymbol.TabIndex = 6;
            // 
            // _ButtonImageList
            // 
            this._ButtonImageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this._ButtonImageList.ImageSize = new System.Drawing.Size(25, 25);
            this._ButtonImageList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // TicTacToePlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.lblSymbol);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblSymbolLabel);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblNameLabel);
            this.DoubleBuffered = true;
            this.Name = "TicTacToePlayer";
            this.Size = new System.Drawing.Size(179, 77);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNameLabel;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblSymbolLabel;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblSymbol;
        internal System.Windows.Forms.ImageList _ButtonImageList;
    }
}
