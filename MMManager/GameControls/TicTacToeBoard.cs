﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Media;
using MMManager.GameInterfaces;

namespace MMManager.GameControls
{
    public partial class TicTacToeBoard : UserControl,IGame
    {
        private MMManagerTTTButton theButton;
        private String[] letters = new String[5] { "J", "K", "M", "L", "N" };
        private const int PCOUNT = 2;
        private char[] symbols = new char[PCOUNT] { 'X', 'O' };
        private int SymbolPos = 0;
        private int TurnPos = 0;
        private int letterPos = 0;
        private int TotalNumMoves = 0;
        int maxY = 4;
        int maxX = 4;
        int maxBombCount = 2;
        private char[,] grid;
        MMManagerTTTButton[,] b;
        private Color bColor;
        private string playerName;

        public string PlayerName
        {
            get { return playerName; }
            set
            {
                playerName = value;
                GameInfo.PlayerName = value;
            }
        }

        public IGameInfo GameInfo
        {
            get
            {
                return this.ticTacToeStartOrJoin1; 
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public TicTacToeBoard()
        {
            InitializeComponent();

            bColor = Color.FromKnownColor(KnownColor.Control);
            
        }
        public void GenerateNewGame()
        {
            
            bgGame.Controls.Clear();
            bgGame.Enabled = true;
            SymbolPos = 0; // Reset to start with X or the first symbol
            maxX = Convert.ToInt32(GameInfo.GameOptions.GridSize);
            maxY = maxX; // Keep Symetry
            int y = 0;
            int x = 0;
            int bombCount = 0;
            Random r = new Random(DateTime.Now.Second);

            b = new MMManagerTTTButton[maxY, maxX];
            grid = new char[maxY, maxX];
            for (y = 0; y < maxY; y++)
            {
                for (x = 0; x < maxX; x++)
                {
                    b[y, x] = new MMManagerTTTButton();
                    b[y, x].Name = "B" + y + x;
                    b[y, x].Text = '\0'.ToString(); //Clear Button
                    grid[y, x] = '\0';//Clear Grid
                    b[y, x].Font = new Font("Microsoft Sans Serif", 12);
                    b[y, x].Visible = true;
                    b[y, x].Width = 40;
                    b[y, x].Height = 40;
                    b[y, x].Left = (x * 40) + 10;
                    b[y, x].Top = (y * 40) + 20;
                    b[y, x].Click += Button_Click;
                    b[y, x].Tag = "0";
                    bgGame.Controls.Add(b[y, x]);
                }
            }
            maxBombCount = maxY - 1;
            while (bombCount <= maxBombCount)
            {
                y = r.Next(0, (maxY - 1));
                x = r.Next(0, (maxX - 1));
                if (b[y, x].Tag.ToString() != "1")
                {
                    bombCount++;
                    b[y, x].Tag = "1";
                }
            }
            getCurrentTurn(); //Show Who's Turn it is
            JoinGame(PlayerName, 0);
            //_game.JoinGame(_game.PlayerName, 0);
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
            #region Load Grid - Can be done dynamically
            TotalNumMoves = 0; //Rest for counting again
            for (y = 0; y < maxY; y++)
            {
                for (x = 0; x < maxX; x++)
                {
                    btn = (bgGame.Controls.Find("B" + y + x, false).First() as Button); //Find the Button
                    //This is a reset
                    btn.BackColor = bColor; 
                    btn.UseVisualStyleBackColor = true;
                    grid[y, x] = btn.Text.ToCharArray(0, 1)[0];
                    for (int i = 0; i < PCOUNT; i++)
                    {
                        if (grid[y, x] == symbols[i])
                        {
                            TotalNumMoves++;
                        }
                    }
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
                        if (win == false)
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
                        if (win == false)
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
            if (win != true)
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
                GameInfo.GameOver(label1.Text);
            }
            //Check for Draw
            if (TotalNumMoves == maxX * maxY) // All spaces are filled
            {
                label1.Text = "Cat's Game";
                GameInfo.GameOver(label1.Text);
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
        /// <summary>
        /// Function to get the next person's turn by symbol
        /// </summary>
        /// <returns></returns>
        private char getCurrentTurn()
        {
            char currentTurn = '\0';
            if (TurnPos + 1 > symbols.Count())
                TurnPos = 0;

            currentTurn = symbols[TurnPos++]; // Go to next Symbol
            label1.Text = "It's " + currentTurn.ToString() + "'s Turn";
            return currentTurn;
        }
        /// <summary>
        /// All game buttons Event Handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Click(object sender, EventArgs e)
        {
            theButton = (sender as MMManagerTTTButton);
            string s = getCurrentSymbol().ToString(); // Use the Current Symbol
            getCurrentTurn(); //Show Who's Turn it is
            if (theButton.Tag.ToString() != "1") // Normal Move
            {
                theButton.Text = s;
                theButton.Font = new Font("Microsoft Sans Serif", 12);
                theButton.customEnable = false; //This button is taken - No more clicks
                CheckForWinOrDraw();
            }
            else //Bomb Move
            {
                theButton.Tag = "0";
                AllButtonsAllowClick(false); //Temp Dissallow Clicks
                timer2.Enabled = true;
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            string currentDir = System.IO.Directory.GetCurrentDirectory();
            if (letterPos == 0)
            {
                theButton.Font = new Font("Wingdings", 20);
                
                SoundPlayer simpleSound = new SoundPlayer(currentDir +@"\Sounds\Incoming_Suspense.wav");
                simpleSound.Play();

            }
            theButton.Text = letters[letterPos++];
            if (letterPos > 4)
            {
                SoundPlayer simpleSound = new SoundPlayer(currentDir + @"\Sounds\Bomb_Exploding.wav");
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

  
        private void ticTacToeStartOrJoin1_Load(object sender, EventArgs e)
        {
            
          //  _gameInfo = this.ticTacToeStartOrJoin1;
          //  _gameInfo.Game = this;
        }





        public void JoinGame(string playerName, int startingScore)
        {
            GameInfo.JoinGame(playerName, startingScore);
            //_game.JoinGame(playerName, startingScore);
        }

        public void LeaveGame(string playerName)
        {
            GameInfo.LeaveGame(playerName);

        }

        public void UpdateScore(string playerName, int currentScore)
        {
            GameInfo.UpdateScore(playerName, currentScore);
        }

        public int GetScore(string playerName)
        {
            throw new NotImplementedException();
        }



        private void TicTacToeBoard_Load(object sender, EventArgs e)
        {
            GameInfo.Game = this; //Set the Child control to see parent.
            //_game = this;
            
        }
    }
}
