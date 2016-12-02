using System;
using System.Drawing;
using System.Windows.Forms;
using MMManager.GameObjects;
using System.Threading;
using SpriteLibrary;
namespace MMManager
{
    public partial class frmTesting : Form
    {
        SpriteController MySpriteController;
        private int[,] grid;
        private SharedTicTacToeBoardData _stttbd;
        private MMManagerTTTButton theButton; //Shared Button Object
        private MMManagerTTTButton[,] b;
        public frmTesting()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                pictureBox1.Load(openFileDialog1.FileName);
                label1.Text = openFileDialog1.FileName;
            }

        }
        /// <summary>
        /// Temporary Copy of what is used in the actual game - just here for testing Buttons.
        /// </summary>
        /// <param name="sharedTicTacToeBoardData"></param>
        /// <returns></returns>
        private SharedTicTacToeBoardData GenerateGameButtons(SharedTicTacToeBoardData sharedTicTacToeBoardData)
        {
            int maxX = 10; // Convert.ToInt32(sharedTicTacToeBoardData.GameSize);
            int maxY = maxX; // Keep Symetry
            sharedTicTacToeBoardData.GameBoard = new int[maxX * maxY];
            int y = 0;
            int x = 0;
            int index = 0;


            b = new MMManagerTTTButton[maxY, maxX]; //2d array of buttons.
            grid = new int[maxY, maxX];

            for (y = 0; y < maxY; y++)
            {
                for (x = 0; x < maxX; x++)
                {
                    b[y, x] = new MMManagerTTTButton();
                    b[y, x].Name = "B" + y + x;
                    b[y, x].Font = new Font("Microsoft Sans Serif", 12);
                    b[y, x].Text = index.ToString(); // String.Empty;                     //Clear Button
                    b[y, x].ImageIndex = 0;                         //Clear Images
                    sharedTicTacToeBoardData.GameBoard[index++] = 0; //Clear 1d Grid
                    grid[y, x] = 0;                                  //Clear 2d Grid
                    b[y, x].Tag = "0";
                    b[y, x].Width = 50;
                    b[y, x].Height = 50;
                    b[y, x].Left = (x * 50) + 10; //Offset 10 pixels from left
                    b[y, x].Top = (y * 50) + 20; //Offset 20 pixels from Top
                    b[y, x].Visible = true;
                    b[y, x].Click += Button_Click;
                    b[y, x].myGridX = x;
                    b[y, x].myGridY = y;
                    b[y, x].maxGridX = maxX;
                    b[y, x].maxGridY = maxY;
                    b[y, x].ToolTip(b[y, x].Name + " [" + y + "," + x + "]");
                    b[y, x].Padding = Padding.Empty;
                    b[y, x].Margin = Padding.Empty;
                    //b[y, x].ImageList = ButtonImageList;
                   
                    bgGame.Controls.Add(b[y, x]);

                }
            }
            return sharedTicTacToeBoardData;
        }

        private void btnGenerateGrid_Click(object sender, EventArgs e)
        {
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            _stttbd = new SharedTicTacToeBoardData();
            _stttbd = GenerateGameButtons(_stttbd);
            
        }
        private void Button_Click(object sender, EventArgs e)
        {
            theButton = (sender as MMManagerTTTButton);
            theButton.explode();
            //Because the buttons are in a group box, and they have an odd border there is a visual annomoly from the falling buttons.
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Sprite OneSprite;
            MySpriteController = new SpriteController(pbBackGround);
            //MySpriteController.ReplaceOriginalImage(pictureBox1.BackgroundImage);
            OneSprite = new Sprite(MySpriteController, Properties.Resources.explode, 50, 50, 25);
            OneSprite.SetSize(new Size(50, 50));
            OneSprite.SetName(SpriteNames.GreyButton.ToString());
            //OneSprite.UnhideSprite();
            //The function to run when the explosion animation completes
            OneSprite.SpriteAnimationComplete += ExplosionCompletes;
        }
        public void ExplosionCompletes(object sender, EventArgs e)
        {
            Sprite tSprite = (Sprite)sender;
            tSprite.Destroy();
            // CountMonsters();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Sprite nSprite = MySpriteController.DuplicateSprite(SpriteNames.GreyButton.ToString());
            nSprite.PutBaseImageLocation(50, 50);
            nSprite.SetSize(new Size(50, 50));
            

            nSprite.MoveTo(new Point(50, 50));
            nSprite.MovementSpeed = 5;
            nSprite.CannotMoveOutsideBox = true;
            
            nSprite.AutomaticallyMoves = true;
            //nSprite.AnimateOnce(0);
        }

        private void BBomb_Click(object sender, EventArgs e)
        {
            //BBomb.TurnToPicture();
            BBomb.explode();
        }
    }
}
