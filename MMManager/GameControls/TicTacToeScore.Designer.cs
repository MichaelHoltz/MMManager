namespace MMManager.GameControls
{
    partial class TicTacToeScore
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblScoreBoard = new System.Windows.Forms.Label();
            this._ButtonImageList = new System.Windows.Forms.ImageList(this.components);
            this.PName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IPSymbol = new System.Windows.Forms.DataGridViewImageColumn();
            this.PScore = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PSymbol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PButtonImageList = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PName,
            this.IPSymbol,
            this.PScore,
            this.PSymbol,
            this.PStatus,
            this.PButtonImageList});
            this.dataGridView1.Location = new System.Drawing.Point(2, 18);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 3, 0, 0);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView1.Size = new System.Drawing.Size(180, 143);
            this.dataGridView1.TabIndex = 13;
            // 
            // lblScoreBoard
            // 
            this.lblScoreBoard.AutoSize = true;
            this.lblScoreBoard.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScoreBoard.Location = new System.Drawing.Point(3, 3);
            this.lblScoreBoard.Name = "lblScoreBoard";
            this.lblScoreBoard.Size = new System.Drawing.Size(77, 13);
            this.lblScoreBoard.TabIndex = 14;
            this.lblScoreBoard.Text = "Score Board";
            // 
            // _ButtonImageList
            // 
            this._ButtonImageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this._ButtonImageList.ImageSize = new System.Drawing.Size(10, 10);
            this._ButtonImageList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // PName
            // 
            this.PName.DataPropertyName = "PlayerName";
            this.PName.FillWeight = 158.53F;
            this.PName.HeaderText = "Player";
            this.PName.Name = "PName";
            this.PName.ReadOnly = true;
            this.PName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // IPSymbol
            // 
            this.IPSymbol.DataPropertyName = "IPlayerSymbol";
            this.IPSymbol.FillWeight = 55.19345F;
            this.IPSymbol.HeaderText = "Sym";
            this.IPSymbol.Name = "IPSymbol";
            this.IPSymbol.ReadOnly = true;
            this.IPSymbol.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.IPSymbol.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // PScore
            // 
            this.PScore.DataPropertyName = "PlayerScore";
            this.PScore.FillWeight = 72.69507F;
            this.PScore.HeaderText = "Score";
            this.PScore.Name = "PScore";
            this.PScore.ReadOnly = true;
            this.PScore.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // PSymbol
            // 
            this.PSymbol.DataPropertyName = "PlayerSymbol";
            this.PSymbol.HeaderText = "SymNum";
            this.PSymbol.Name = "PSymbol";
            this.PSymbol.ReadOnly = true;
            this.PSymbol.Visible = false;
            // 
            // PStatus
            // 
            this.PStatus.DataPropertyName = "PlayerStatus";
            this.PStatus.FillWeight = 1F;
            this.PStatus.HeaderText = "Status";
            this.PStatus.Name = "PStatus";
            this.PStatus.ReadOnly = true;
            this.PStatus.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.PStatus.Visible = false;
            // 
            // PButtonImageList
            // 
            this.PButtonImageList.DataPropertyName = "ButtonImageList";
            this.PButtonImageList.HeaderText = "BIL";
            this.PButtonImageList.Name = "PButtonImageList";
            this.PButtonImageList.ReadOnly = true;
            this.PButtonImageList.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.PButtonImageList.Visible = false;
            // 
            // TicTacToeScore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.lblScoreBoard);
            this.Controls.Add(this.dataGridView1);
            this.DoubleBuffered = true;
            this.Name = "TicTacToeScore";
            this.Size = new System.Drawing.Size(182, 161);
            this.Load += new System.EventHandler(this.TicTacToeScore_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblScoreBoard;
        internal System.Windows.Forms.ImageList _ButtonImageList;
        private System.Windows.Forms.DataGridViewTextBoxColumn PName;
        private System.Windows.Forms.DataGridViewImageColumn IPSymbol;
        private System.Windows.Forms.DataGridViewTextBoxColumn PScore;
        private System.Windows.Forms.DataGridViewTextBoxColumn PSymbol;
        private System.Windows.Forms.DataGridViewTextBoxColumn PStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn PButtonImageList;
    }
}
