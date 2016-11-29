using System;
using System.Drawing;
using System.Windows.Forms;
using MMManager.Controls;
using MMManager.GameInterfaces;
using MMManager.GameObjects;
using System.Threading;
namespace MMManager
{
    public partial class frmTesting : Form
    {
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
                    b[y, x].Text = index.ToString(); // String.Empty;                     //Clear Button
                    b[y, x].ImageIndex = 0;                         //Clear Images
                    sharedTicTacToeBoardData.GameBoard[index++] = 0; //Clear 1d Grid
                    grid[y, x] = 0;                                  //Clear 2d Grid
                    b[y, x].Tag = "0";

                    b[y, x].Font = new Font("Microsoft Sans Serif", 12);
                    b[y, x].Visible = true;
                    b[y, x].Width = 50;
                    b[y, x].Height = 50;
                    b[y, x].Left = (x * 50) + 10; //Offset 10 pixels from left
                    b[y, x].Top = (y * 50) + 20; //Offset 20 pixels from Top
                    b[y, x].Click += Button_Click;
                    b[y, x].myGridX = x;
                    b[y, x].myGridY = y;
                    b[y, x].maxGridX = maxX;
                    b[y, x].maxGridY = maxY;
                    b[y, x].ToolTip(b[y, x].Name + " [" + y + "," + x + "]");
                    //b[y, x].ImageList = ButtonImageList;
                    bgGame.Controls.Add(b[y, x]);

                }
            }
            //AllButtonsAllowClick(false); //No Click for Anyone
            return sharedTicTacToeBoardData;
        }

        private void btnGenerateGrid_Click(object sender, EventArgs e)
        {
            _stttbd = new SharedTicTacToeBoardData();
            _stttbd = GenerateGameButtons(_stttbd);
            
        }
        private void Button_Click(object sender, EventArgs e)
        {
            theButton = (sender as MMManagerTTTButton);
            theButton.explode();
            bgGame.Invalidate();
           // 
           // theButton.Top = -50;
           // //theButton.myGridY = 0;
           // theButton.Fall(70);
           // timer1.Enabled = true;
           //// Thread.Sleep(300);
           //// b[1, 1].FallToNextButton();
           // //foreach (MMManagerTTTButton item in bgGame.Controls)
           // //{
           // //    item.FallToNextButton();
           // //}
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (MMManagerTTTButton item in bgGame.Controls)
            {
                item.FallToNextButton();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            foreach (MMManagerTTTButton item in bgGame.Controls)
            {
                item.FallToNextButton();
            }
        }
    }
}
