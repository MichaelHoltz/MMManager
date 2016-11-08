using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Media;
namespace MMManager
{
    public partial class Form1 : Form
    {
        private MMManagerTTTButton theButton;
        private String[] letters = new String[5] {"J", "K", "M", "L", "N"};
        private char[] symbols = new char[2] { 'X','O' };
        private int SymbolPos = 0;
        private int TurnPos = 0;
        private int letterPos = 0;
        int maxY = 4;
        int maxX = 4;
        int maxBombCount = 2;
        private char[,] grid;
        MMManagerTTTButton[,] b;
        private Color bColor;

        public Form1()
        {
            InitializeComponent();
            bColor = button1.BackColor;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.ImageIndex = 1;
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            button1.ImageIndex = 2;
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            groupBox1.Controls.Clear();
            groupBox1.Enabled = true;
            SymbolPos = 0; // Reset to start with X or the first symbol
            maxX = Convert.ToInt32(domainUpDown1.Text);
            maxY = maxX; // Keep Symetry
            int y = 0;
            int x = 0;
            int bombCount = 0;
            Random r = new Random(DateTime.Now.Second);

            b = new MMManagerTTTButton[maxY,maxX];
            grid = new char[maxY, maxX];
            for (y = 0; y < maxY; y++)
            {
                for (x = 0; x < maxX; x++)
                {
                    b[y,x] = new MMManagerTTTButton();
                    b[y, x].Name = "B" + y+x;
                    b[y, x].Text = '\0'.ToString(); //Clear Button
                    grid[y, x] = '\0';//Clear Grid
                    b[y, x].Font = new Font("Microsoft Sans Serif", 12);
                    b[y, x].Visible = true;
                    b[y, x].Width = 40;
                    b[y, x].Height = 40;
                    b[y, x].Left = (x * 40)+10;
                    b[y, x].Top = (y * 40) + 20;
                    b[y, x].Click += Button_Click;
                    b[y, x].Tag = "0";
                    groupBox1.Controls.Add(b[y, x]);
                }
            }
            maxBombCount = maxY - 1;
            while (bombCount <= maxBombCount)
            {
                y = r.Next(0, (maxY - 1));
                x = r.Next(0, (maxX - 1));
                if(b[y, x].Tag.ToString() != "1")
                { 
                    bombCount++;
                    b[y, x].Tag = "1";
                }
            }
            getCurrentTurn(); //Show Who's Turn it is

        }
        private bool CheckWin(int y, int x, int n, ref char winLine, List<Point> winningList)
        {
            bool win = true;
            Point p = new Point(x, y);
            winningList.Add(p);
            if (n == 0)
                winLine = grid[y, x];
            winLine &= grid[y, x];
            if (winLine != grid[y, x] || winLine == '\0')
            {
                win = false;
                //break;
            }
            return win;
        }
        private void CheckForWinOrDraw()
        {
            int y = 0;
            int x = 0;
            Button btn;
            Point p;
            List<Point> winningList = new List<Point>();
            
            char winLine = '\0'; //Null
            bool win = true;
            #region Load Grid
            for (y = 0; y < maxY; y++)
            {
                for (x = 0; x < maxX; x++)
                {
                    btn = (groupBox1.Controls.Find("B" + y + x, false).First() as Button);
                    btn.BackColor = bColor;
                    btn.UseVisualStyleBackColor = true;
                    grid[y, x] = btn.Text.ToCharArray(0,1)[0];
                }
            }
            #endregion
            //Horizontal
            for (y = 0; y < maxY; y++)
            {
                win = true;
                winningList.Clear();
                //winLine = null;
                for (x = 0; x < maxX; x++)
                {
                    win = CheckWin(y, x, x, ref winLine, winningList);
                    if (win == false)
                        break;

                }
                if (win == true)
                    break;
            }
            if (win != true)
            {

                //Vertical
                for (x = 0; x < maxX; x++)
                {
                    win = true;
                    winningList.Clear();
                    //winLine = null;
                    for (y = 0; y < maxY; y++)
                    {
                        win = CheckWin(y, x, y, ref winLine, winningList);
                        if ( win == false)
                            break;
                    }
                    if (win == true)
                        break;
                }
            }
            //Need to do diagonal
            if (win != true)
            {
                win = true;
                winningList.Clear();
              
                //TopLeft to Bottom Right
                for (y = 0; y < maxY;)
                {
                    for (x = 0; x < maxX; x++, y++)
                    {
                        win = CheckWin(y, x, x, ref winLine, winningList);
                        if ( win == false)
                        {
                            y = maxY;
                            break;
                        }

                    }
                    if (win == true)
                    {
                       
                        break;
                    }
                }
            }
            if(win !=true)
            {
                win = true;
                winningList.Clear();
                //Bottom Left to Top Right
                for (y = maxY - 1; y > 0;)
                {
                    for (x = 0; x < maxX; x++, y--)
                    {
                        win = CheckWin(y, x, x, ref winLine, winningList);
                        if (win == false)
                        {
                            y = 0;
                            break;
                        }
                    }
                    if (win == true)
                    {
                        
                        break;
                    }
                }
            }
            if (win == true)
            {
                foreach (Point item in winningList)
                {
                    b[item.Y, item.X].BackColor = Color.Red;
                }
                AllButtonsEnable(false);
                label1.Text = "Game Over";
            }

        }
        /// <summary>
        /// Function to Set all buttons to Enable or Disable (Mostly Disable)
        /// </summary>
        /// <param name="enable"></param>
        private void AllButtonsEnable(Boolean enable)
        {

            for (int y = 0; y < maxY; y++)
            {
                for (int x = 0; x < maxX; x++)
                {
                    
                    b[y, x].customEnable = enable;
                }
            }
        }
        /// <summary>
        /// Function to Allow and Disallow Button Clicking while something happens.
        /// </summary>
        /// <param name="allow"></param>
        private void AllButtonsAllowClick(Boolean allow)
        {
            for (int y = 0; y < maxY; y++)
            {
                for (int x = 0; x < maxX; x++)
                {

                    b[y, x].allowClick = allow;
                }
            }
        }
        private char getCurrentSymbol()
        {
            char currentSymbol = '\0';
            if (SymbolPos + 1 > symbols.Count())
                SymbolPos = 0;

            currentSymbol = symbols[SymbolPos++]; // Go to next Symbol
            label1.Text = "It's " + currentSymbol.ToString() + "'s Turn";
            return currentSymbol;
        }
        private char getCurrentTurn()
        {
            char currentTurn = '\0';
            if (TurnPos + 1 > symbols.Count())
                TurnPos = 0;

            currentTurn = symbols[TurnPos++]; // Go to next Symbol
            label1.Text = "It's " + currentTurn.ToString() + "'s Turn";
            return currentTurn;
        }
        private void Button_Click(object sender, EventArgs e)
        {
                theButton = (sender as MMManagerTTTButton);
                string s = getCurrentSymbol().ToString(); // Use the Current Symbol
                getCurrentTurn(); //Show Who's Turn it is
            if (theButton.Tag.ToString() != "1")
            {

                theButton.Text = s;
                theButton.Font = new Font("Microsoft Sans Serif", 12);
                theButton.customEnable = false; //This button is taken
                CheckForWinOrDraw();
            }
            else
            {
                theButton.Tag = "0";
                AllButtonsAllowClick(false); //Temp Dissallow Clicks
                timer2.Enabled = true;
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (letterPos == 0)
            {
                theButton.Font = new Font("Wingdings", 20);
            }
            theButton.Text = letters[letterPos++];
            if (letterPos > 4)
            {
                SoundPlayer simpleSound = new SoundPlayer(@"c:\Windows\Media\chimes.wav");
                simpleSound.Play();
                letterPos = 0;
                timer2.Enabled = false;
               // theButton.Font = new Font("Microsoft Sans Serif", 12);
                AllButtonsAllowClick(true);
                //theButton.customEnable = true; // Allow this button to be clicked
                //customDisable = false;
                //groupBox1.Enabled = true;
            }

        }


        private void btnSpectator_Click(object sender, EventArgs e)
        {

            groupBox1.Enabled = !groupBox1.Enabled;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (groupBox1.Enabled)
            {
                MessageBox.Show("Button4 Click");
            }
            else
            {
                
            }
        }

        private void mmManagerTTTButton1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Button Clicked");
        }
    }
}
