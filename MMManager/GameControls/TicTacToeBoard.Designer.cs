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
            this.label1 = new System.Windows.Forms.Label();
            this.bgGame = new System.Windows.Forms.GroupBox();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.ticTacToeStartOrJoin1 = new MMManager.GameControls.TicTacToeStartOrJoin();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label1.Location = new System.Drawing.Point(0, 533);
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
            // ticTacToeStartOrJoin1
            // 
            this.ticTacToeStartOrJoin1.AutoSize = true;
            this.ticTacToeStartOrJoin1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ticTacToeStartOrJoin1.BoardData = null;
            this.ticTacToeStartOrJoin1.Game = null;
            this.ticTacToeStartOrJoin1.GameMode = MMManager.GameInterfaces.ControlStatus.Hosting;
            this.ticTacToeStartOrJoin1.GameName = null;
            this.ticTacToeStartOrJoin1.GameState = MMManager.GameObjects.SharedTicTacToeBoardData.GameState.Waiting;
            this.ticTacToeStartOrJoin1.Location = new System.Drawing.Point(3, 4);
            this.ticTacToeStartOrJoin1.Name = "ticTacToeStartOrJoin1";
            this.ticTacToeStartOrJoin1.Player = ((MMManager.GameObjects.PlayerClass)(resources.GetObject("ticTacToeStartOrJoin1.Player")));
            this.ticTacToeStartOrJoin1.Players = ((System.Collections.Generic.List<MMManager.GameObjects.PlayerClass>)(resources.GetObject("ticTacToeStartOrJoin1.Players")));
            this.ticTacToeStartOrJoin1.Size = new System.Drawing.Size(383, 298);
            this.ticTacToeStartOrJoin1.TabIndex = 13;
            this.ticTacToeStartOrJoin1.Load += new System.EventHandler(this.ticTacToeStartOrJoin1_Load);
            // 
            // TicTacToeBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.ticTacToeStartOrJoin1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bgGame);
            this.DoubleBuffered = true;
            this.Name = "TicTacToeBoard";
            this.Size = new System.Drawing.Size(396, 546);
            this.Load += new System.EventHandler(this.TicTacToeBoard_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox bgGame;
        private System.Windows.Forms.Timer timer2;
        private TicTacToeStartOrJoin ticTacToeStartOrJoin1;
    }
}
