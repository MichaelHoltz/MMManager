using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Media;
using MMManager.GameInterfaces;
using MMManager.GameObjects;

namespace MMManager.GameControls
{
    [Serializable]
    public partial class TicTacToeBoard : UserControl,IGame
    {
        private SharedTicTacToeBoardData sharedTicTacToeBoardData; //Contains all neeeded
        private MMManagerTTTButton theButton;
        private String[] letters = new String[5] { "J", "K", "M", "L", "N" };
        
        //Control of Player Count
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
       // private IPlayer Player;
        public string PlayerName
        {
            get { return playerName; }
            set
            {
                playerName = value;
                //GameInfo.Player = new PlayerClass() { PlayerName = playerName, PlayerSymbol = '?' };
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

        /// <summary>
        /// This is the host form.. that handles messages in general
        /// </summary>
        public IMessageRelay ServiceProvider { get; set; }



        public TicTacToeBoard()
        {
            InitializeComponent();

            bColor = Color.FromKnownColor(KnownColor.Control);
            
        }
        /// <summary>
        /// Generate the Button Grid and game Grid
        /// </summary>
        /// <param name="sharedTicTacToeBoardData"></param>
        /// <returns></returns>
        private SharedTicTacToeBoardData GenerateGameButtons(SharedTicTacToeBoardData sharedTicTacToeBoardData)
        {
            maxX = Convert.ToInt32(sharedTicTacToeBoardData.GameSize);
            maxY = maxX; // Keep Symetry
            int y = 0;
            int x = 0;
            int index = 0;


            b = new MMManagerTTTButton[maxY, maxX];
            grid = new char[maxY, maxX];
            if(GameInfo.GameMode == ControlStatus.Hosting)
                sharedTicTacToeBoardData.GameBoard = new char[maxX * maxY];

            for (y = 0; y < maxY; y++)
            {
                for (x = 0; x < maxX; x++)
                {
                    b[y, x] = new MMManagerTTTButton();
                    b[y, x].Name = "B" + y + x;
                    b[y, x].Text = '\0'.ToString();                     //Clear Button
                    grid[y, x] = '\0';                                  //Clear 2d Grid
                    if (GameInfo.GameMode == ControlStatus.Hosting)
                        sharedTicTacToeBoardData.GameBoard[index++] = '\0'; //Clear 1d Grid
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
            return sharedTicTacToeBoardData;
        }
        private SharedTicTacToeBoardData GenerateRandomOptions(SharedTicTacToeBoardData sharedTicTacToeBoardData)
        {
            //Must check to see if we are hosting, none of this is needed if we are hosting because the board will be populated already.
            
            int bombCount = 0;
            int ExtraTurnCount = 0;
            int RowColClearCount = 0;
            int ShuffleCount = 0;
            int TotalMaxEvents = Convert.ToInt32(Math.Round(Convert.ToDouble(maxX * maxY) / 2, 0)); // About Half of the Grid
            Random r = new Random(DateTime.Now.Millisecond);
            int y = 0;
            int x = 0;
            maxX = Convert.ToInt32(GameInfo.GameOptions.GridSize);
            maxY = maxX; // Keep Symetry
            //TODO Figure out how to weight so the total events
            float WeightBomb = 0.6f;
            float WeightExtraTurn = 0.1f;
            float WeightRowColClear = 0.1f;
            float WeitghtShuffle = 0.2f;

            if (GameInfo.GameOptions.GenerateBombs)
            {
                maxBombCount = TotalMaxEvents;
            }
            if (GameInfo.GameOptions.GenerateExtraTurns)
            {
                ExtraTurnCount = TotalMaxEvents;
            }
            if (GameInfo.GameOptions.GenerateRowColClear)
            {
                RowColClearCount = TotalMaxEvents;
            }
            if (GameInfo.GameOptions.GenerateShuffle)
            {
                ShuffleCount = TotalMaxEvents;
            }

            //Want to have all randomb options take up 50% of the board
            //IF bombs are wanted.. Set tags on the buttons.. Maybe not what I want.
            if (GameInfo.GameOptions.GenerateBombs)
            {
                //maxBombCount = maxY - 1;
               
                while (bombCount <= maxBombCount)
                {
                    y = r.Next(0, maxY);
                    x = r.Next(0, maxX);
                    if (b[y, x].Tag.ToString() != "1")
                    {
                        bombCount++;
                        b[y, x].Tag = "1";
                    }
                }

            }

            return sharedTicTacToeBoardData;
        }
        private SharedTicTacToeBoardData EncodeGameBoard(SharedTicTacToeBoardData sharedTicTacToeBoardData)
        {
            maxX = Convert.ToInt32(GameInfo.GameOptions.GridSize);
            maxY = maxX; // Keep Symetry
            int y = 0;
            int x = 0;
            int index = 0;
            //Encode to single diminsion
            for (y = 0; y < maxY; y++)
            {
                for (x = 0; x < maxX; x++)
                {
                    if (b[y, x].Tag.ToString() == "1")
                    {
                        sharedTicTacToeBoardData.GameBoard[y * maxY + x] = '1';
                    }
                }
            }
            return sharedTicTacToeBoardData;
        }
        private SharedTicTacToeBoardData DecodeGameBoard(SharedTicTacToeBoardData sharedTicTacToeBoardData)
        {
            maxX = Convert.ToInt32(GameInfo.GameOptions.GridSize);
            maxY = maxX; // Keep Symetry
            int y = 0;
            int x = 0;
            //Decode to two diminsions
            for (int i = 0; i < maxY * maxX; i++)
            {
                if (sharedTicTacToeBoardData.GameBoard[i] == '1')
                {
                    y = i / maxY;
                    x = i % maxX;
                    b[y, x].Text = "b";
                }

            }
            return sharedTicTacToeBoardData;
        }
        public SharedTicTacToeBoardData GenerateNewGame()
        {

            sharedTicTacToeBoardData = new SharedTicTacToeBoardData(); //Nothing here!
            sharedTicTacToeBoardData.GameSize = GameInfo.GameOptions.GridSize; // Set Grid Size to shared
            sharedTicTacToeBoardData.MessageSender = GameInfo.Player;
            sharedTicTacToeBoardData.Message = SharedTicTacToeBoardData.MessageCode.NewGame;
            sharedTicTacToeBoardData.MessageString = GameInfo.GameName;

            //Remove all Buttons
            bgGame.Controls.Clear();
            bgGame.Enabled = true;

            sharedTicTacToeBoardData = GenerateGameButtons(sharedTicTacToeBoardData);
            sharedTicTacToeBoardData = GenerateRandomOptions(sharedTicTacToeBoardData);
            sharedTicTacToeBoardData = EncodeGameBoard(sharedTicTacToeBoardData);
            sharedTicTacToeBoardData = DecodeGameBoard(sharedTicTacToeBoardData);

            SymbolPos = 0; // Reset to start with X or the first symbol
            getCurrentTurn(); //Show Who's Turn it is
            return sharedTicTacToeBoardData;
        }
        public SharedTicTacToeBoardData ResetGame()
        {
            //Need to Clear something!!!
            return sharedTicTacToeBoardData;
            //Clear the Board and do the same logic as Generating the Game.. 
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
        public char GetCurrentSymbol()
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

        /// <summary>
        /// All game buttons Event Handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Click(object sender, EventArgs e)
        {
            theButton = (sender as MMManagerTTTButton);
            string s = GetCurrentSymbol().ToString(); // Use the Current Symbol
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
          // // GameInfo.Players = ticTacToeStartOrJoin1.Players;
          //  GameInfo.Player = ticTacToeStartOrJoin1.Player;
          //  GameInfo.GameScore = ticTacToeStartOrJoin1.GameScore;
          ////  _gameInfo = this.ticTacToeStartOrJoin1;
          ////  _gameInfo.Game = this;
        }


        private void TicTacToeBoard_Load(object sender, EventArgs e)
        {

            GameInfo.Game = this; //Set the Child control to see parent.
            GameInfo.Player = ticTacToeStartOrJoin1.Player;
            GameInfo.GameScore = ticTacToeStartOrJoin1.GameScore;
           
        }

        public void ReceiveMessage(string gameName, PlayerClass player, SharedTicTacToeBoardData theSharedBoardData)
        {
            if (player.PlayerName == GameInfo.Player.PlayerName)
                return;
            GameInfo.BoardData = theSharedBoardData;
            //A new Game has been published
            if (theSharedBoardData.Message == SharedTicTacToeBoardData.MessageCode.NewGame)
            {
                GameInfo.AddGame(theSharedBoardData.MessageString);

            }
            //A game has be removed
            if (theSharedBoardData.Message == SharedTicTacToeBoardData.MessageCode.RemoveGame)
            {
                theSharedBoardData.Players.Clear();
                GameInfo.RemoveGame(theSharedBoardData.MessageString);
                GameInfo.GameScore.ClearAllPlayers();
                //GameInfo.GameScore.LeaveGame()

            }
            //Message REceived to start TickTack Toe
            if (theSharedBoardData.Message == SharedTicTacToeBoardData.MessageCode.Start)
            {
                //Update the Score View and set all scores to zero.
                foreach (var item in GameInfo.Players)
                {
                    GameInfo.GameScore.UpdateScore(item, 0);
                }
            }
            //Someone Joined
            if (theSharedBoardData.Message == SharedTicTacToeBoardData.MessageCode.Join)
            {
                GameInfo.GameScore.JoinGame(theSharedBoardData.MessageSender);
                GameInfo.Players.Add(GameInfo.Player);
                theSharedBoardData.Message = SharedTicTacToeBoardData.MessageCode.SyncBoard;
                theSharedBoardData.MessageSender = GameInfo.Player;
                theSharedBoardData.GameSize = GameInfo.GameOptions.GridSize;
                theSharedBoardData.GameBoard = DecodeGameBoard(theSharedBoardData).GameBoard;

                SendMessage(GameInfo.GameName, GameInfo.Player, theSharedBoardData);

                GameInfo.PlayersChanged();
                //Need to see the BOARD NOW!!!!
            }
            if (theSharedBoardData.Message == SharedTicTacToeBoardData.MessageCode.Watch)
            {
                
                GameInfo.GameScore.WatchGame(theSharedBoardData.MessageSender);
                theSharedBoardData.Message = SharedTicTacToeBoardData.MessageCode.SyncBoard;
                theSharedBoardData.MessageSender = GameInfo.Player;
                theSharedBoardData.GameSize = GameInfo.GameOptions.GridSize;
                theSharedBoardData.GameBoard = EncodeGameBoard(theSharedBoardData).GameBoard;
                SendMessage(GameInfo.GameName, GameInfo.Player, theSharedBoardData);
                //Need to see the BOARD NOW!!!!
            }
            if (theSharedBoardData.Message == SharedTicTacToeBoardData.MessageCode.SyncBoard)
            {
                
                GenerateGameButtons(theSharedBoardData);
               // GenerateRandomOptions(theSharedBoardData);  // Need to see if we are hosting or not hosting.
                DecodeGameBoard(theSharedBoardData);
            }
            if (theSharedBoardData.Message == SharedTicTacToeBoardData.MessageCode.LeaveGame)
            {
                GameInfo.GameScore.LeaveGame(theSharedBoardData.MessageSender);
                GameInfo.PlayersChanged();
                    
                //Remove the Board now.
            }
            if (theSharedBoardData.Message == SharedTicTacToeBoardData.MessageCode.Move)
            {
                //Button b = null;
                //foreach (Control item in gbTicTacToe.Controls)
                //{
                //    if (item.Name == theSharedBoard.MessageString)
                //    {
                //        b = (item as Button);
                //        b.Text = theSharedBoard.MessageValue;
                //        if (theSharedBoard.MessageValue != "B!")
                //            b.Enabled = false;
                //        break;
                //    }

                //}


            }
            if (theSharedBoardData.Message == SharedTicTacToeBoardData.MessageCode.Reset)
            {
                //reset();
            }
        }

        public void SendMessage(string gameName, PlayerClass player, SharedTicTacToeBoardData theSharedBoardData)
        {
            if (ServiceProvider != null)
            {

                ServiceProvider.SendTicTacToeMessage(gameName, player, theSharedBoardData);
            }
            //else
            //{
            //    throw new NotImplementedException("No Service Provider supplied");
            //}
        }


    }
}
