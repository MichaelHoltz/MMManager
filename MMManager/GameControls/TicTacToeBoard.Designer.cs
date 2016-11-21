namespace MMManager.GameControls
{
    partial class TicTacToeBoard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TicTacToeBoard));
            MMManager.GameObjects.PlayerClass playerClass1 = new MMManager.GameObjects.PlayerClass();
            this.label1 = new System.Windows.Forms.Label();
            this.bgGame = new System.Windows.Forms.GroupBox();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this._ButtonImageList = new System.Windows.Forms.ImageList(this.components);
            this.ticTacToeStartOrJoin1 = new MMManager.GameControls.TicTacToeStartOrJoin();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label1.Location = new System.Drawing.Point(0, 448);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "label1";
            // 
            // bgGame
            // 
            this.bgGame.AutoSize = true;
            this.bgGame.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bgGame.Location = new System.Drawing.Point(3, 308);
            this.bgGame.MinimumSize = new System.Drawing.Size(150, 150);
            this.bgGame.Name = "bgGame";
            this.bgGame.Size = new System.Drawing.Size(150, 150);
            this.bgGame.TabIndex = 10;
            this.bgGame.TabStop = false;
            this.bgGame.Text = "Tic Tac Toe";
            // 
            // timer2
            // 
            this.timer2.Interval = 500;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
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
            // ticTacToeStartOrJoin1
            // 
            this.ticTacToeStartOrJoin1.AutoSize = true;
            this.ticTacToeStartOrJoin1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ticTacToeStartOrJoin1.BoardData = null;
            this.ticTacToeStartOrJoin1.Game = null;
            this.ticTacToeStartOrJoin1.GameMode = MMManager.GameInterfaces.ControlStatus.Unknown;
            this.ticTacToeStartOrJoin1.GameName = null;
            this.ticTacToeStartOrJoin1.GameState = MMManager.GameObjects.SharedTicTacToeBoardData.GameState.Waiting;
            this.ticTacToeStartOrJoin1.Location = new System.Drawing.Point(3, 4);
            this.ticTacToeStartOrJoin1.Name = "ticTacToeStartOrJoin1";
            playerClass1.PlayerName = "MyName";
            playerClass1.PlayerScore = 0;
            playerClass1.PlayerStatus = "Unknown";
            playerClass1.PlayerSymbol = '\0';
            this.ticTacToeStartOrJoin1.Player = playerClass1;
            this.ticTacToeStartOrJoin1.PlayerName = "MyName";
            this.ticTacToeStartOrJoin1.PlayerScore = 0;
            this.ticTacToeStartOrJoin1.PlayerStatus = "Unknown";
            this.ticTacToeStartOrJoin1.PlayerSymbol = '\0';
            this.ticTacToeStartOrJoin1.Size = new System.Drawing.Size(215, 298);
            this.ticTacToeStartOrJoin1.TabIndex = 13;
            this.ticTacToeStartOrJoin1.Load += new System.EventHandler(this.ticTacToeStartOrJoin1_Load);
            // 
            // TicTacToeBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.ticTacToeStartOrJoin1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bgGame);
            this.DoubleBuffered = true;
            this.Name = "TicTacToeBoard";
            this.Size = new System.Drawing.Size(221, 461);
            this.Load += new System.EventHandler(this.TicTacToeBoard_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox bgGame;
        private System.Windows.Forms.Timer timer2;
        private TicTacToeStartOrJoin ticTacToeStartOrJoin1;
        public System.Windows.Forms.ImageList _ButtonImageList;
    }
}
