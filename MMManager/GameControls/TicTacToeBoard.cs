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
        private SharedTicTacToeBoardData _stttbd; //Contains all neeeded
        private MMManagerTTTButton theButton; //Shared Button Object
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

        public IGameInfo GameInfo
        {
            get
            {
                return (IGameInfo)this.ticTacToeStartOrJoin1; 
                
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
        /// Remove the Buttons and clear the game grid and array
        /// </summary>
        /// <param name="sharedTicTacToeBoardData"></param>
        /// <returns></returns>
        private SharedTicTacToeBoardData RemoveGameButtons(SharedTicTacToeBoardData sharedTicTacToeBoardData)
        {
            maxX = Convert.ToInt32(sharedTicTacToeBoardData.GameSize);
            maxY = maxX; // Keep Symetry
            int y = 0;
            int x = 0;
            int index = 0;
            for (y = 0; y < maxY; y++)
            {
                for (x = 0; x < maxX; x++)
                {
                    if (b != null)
                    {
                        if (bgGame.Controls.Contains(b[y, x]))
                        {
                            bgGame.Controls.Remove(b[y, x]);
                        }
                    }
                    sharedTicTacToeBoardData.GameBoard[index++] = '\0'; //Clear 1d Grid
                    if (grid != null)
                    {
                        grid[y, x] = '\0';
                    }
                }
            }
            return sharedTicTacToeBoardData;
        }


        /// <summary>
        /// Generate the Button Grid and game Grid and 1d Grid
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

            
            b = new MMManagerTTTButton[maxY, maxX]; //2d array of buttons.
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
                    
                    if (GameInfo.GameMode == ControlStatus.Hosting)
                    {
                        sharedTicTacToeBoardData.GameBoard[index++] = '\0'; //Clear 1d Grid
                        grid[y, x] = '\0';                                  //Clear 2d Grid
                        b[y, x].Tag = "0";
                    }
                    else
                    {
                        grid[y, x] = sharedTicTacToeBoardData.GameBoard[index]; //Set the 2d Grid
                        b[y, x].Tag = sharedTicTacToeBoardData.GameBoard[index++]; // Set tag from shared Board.
                    }
                    b[y, x].Font = new Font("Microsoft Sans Serif", 12);
                    b[y, x].Visible = true;
                    b[y, x].Width = 40;
                    b[y, x].Height = 40;
                    b[y, x].Left = (x * 40) + 10;
                    b[y, x].Top = (y * 40) + 20;
                    b[y, x].Click += Button_Click;
                    
                    bgGame.Controls.Add(b[y, x]);

                }
            }
            AllButtonsAllowClick(false); //No Click for Anyone
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
                //Check for Bombs
                if (sharedTicTacToeBoardData.GameBoard[i] == '1')
                {
                    y = i / maxY;
                    x = i % maxX;
                    b[y, x].Text = "b"; // Display's the Bombs For Debugging 
                    b[y, x].Tag = "1";
                }
                else
                {
                    y = i / maxY;
                    x = i % maxX;
                    b[y, x].Text = " ";

                }

            }
            return sharedTicTacToeBoardData;
        }
        public SharedTicTacToeBoardData GenerateNewGame()
        {

            _stttbd = new SharedTicTacToeBoardData(); //Nothing here!
            _stttbd.GameSize = GameInfo.GameOptions.GridSize; // Set Grid Size to shared
            _stttbd.MessageSender = GameInfo.Player;
            _stttbd.Message = SharedTicTacToeBoardData.MessageCode.NewGame;
            _stttbd.GameName = GameInfo.GameName; // Set the Game Name for filtering
            _stttbd.MessageString = GameInfo.GameName; //Seems redundant..

            //Remove all Buttons
            bgGame.Controls.Clear();
            bgGame.Enabled = true;

            _stttbd = GenerateGameButtons(_stttbd);
            _stttbd = GenerateRandomOptions(_stttbd);
            _stttbd = EncodeGameBoard(_stttbd);
            _stttbd = DecodeGameBoard(_stttbd);

            SymbolPos = 0; // Reset to start with X or the first symbol
            getCurrentTurn(); //Show Who's Turn it is
            return _stttbd;
        }
        public SharedTicTacToeBoardData ResetGame(SharedTicTacToeBoardData sharedTicTacToeBoardData)
        {
            //Clear the Board and do the same logic as Generating the Game.. 
            return RemoveGameButtons(sharedTicTacToeBoardData);

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
        public void AllButtonsEnable(Boolean enable)
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
        public void AllButtonsAllowClick(Boolean allow)
        {
            for (int y = 0; y < maxY; y++)
            {
                for (int x = 0; x < maxX; x++)
                {

                    this.b[y, x].allowClick = allow;
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

            _stttbd.MessageSender = GameInfo.Player;
            _stttbd.Message = SharedTicTacToeBoardData.MessageCode.Move;
            _stttbd.MessageValue = theButton.Name;
            _stttbd.MessageString = s.ToString(); 
            SendMessage(GameInfo.GameName, GameInfo.Player, _stttbd);
            DoButtonClick(theButton, s);
            //Need some way to identify this button.. Name = BYX
            //Check for Bombs 

        }
        private void DoButtonClick(MMManagerTTTButton theButtonClicked, string s)
        {
            theButton = theButtonClicked; // set for timer
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
            //GameInfo.Player = ticTacToeStartOrJoin1.Player;
            //GameInfo.GameScore = ticTacToeStartOrJoin1.GameScore;
           
        }

        public void ReceiveMessage(string gameName, PlayerClass player, SharedTicTacToeBoardData tsbd)
        {
            //Don't process your own messages EVER
            if (player.PlayerName == GameInfo.Player.PlayerName)
                return;
            #region Not GameName Specific
            //Someone is sending out a request looking for Games
            if (tsbd.Message == SharedTicTacToeBoardData.MessageCode.RefreshGameList)
            {
                if (GameInfo.GameMode == ControlStatus.Hosting)
                {
                    tsbd = _stttbd; // Set to what is being Hosted
                    tsbd.MessageSender = GameInfo.Player;
                    tsbd.Message = SharedTicTacToeBoardData.MessageCode.NewGame;
                    tsbd.MessageString = GameInfo.GameName;
                    SendMessage(GameInfo.GameName, GameInfo.Player, tsbd); // Send message to Everyone
                }
            }
            //A new Game has been published
            if (tsbd.Message == SharedTicTacToeBoardData.MessageCode.NewGame)
            {
                GameInfo.BoardData = tsbd;
                GameInfo.AddGame(tsbd.MessageString);

            }

            #endregion 

            if (tsbd.GameName != GameInfo.GameName)
            {
                //Want to return to filter messages
                //Debugging Message Only
                MessageBox.Show("\"" + tsbd.GameName + "\" doesn't equal \"" + GameInfo.GameName + "\" - Message=" + tsbd.Message.ToString());
                return; // Get out
            }

            //A game has be removed
            if (tsbd.Message == SharedTicTacToeBoardData.MessageCode.RemoveGame)
            {
                GameInfo.GameState = SharedTicTacToeBoardData.GameState.Waiting;
                tsbd.Players.Clear();
                GameInfo.RemoveGame(tsbd.MessageString);
                GameInfo.GameScore.ClearAllPlayers();
                ResetGame(tsbd);
                //GameInfo.GameScore.LeaveGame()

            }
            //Message Received to start TicTacToe
            if (tsbd.Message == SharedTicTacToeBoardData.MessageCode.Start)
            {
                ResetGame(tsbd);
                _stttbd = tsbd; // Sync with what the Host Sent
                GameInfo.BoardData = tsbd;
                if (GameInfo.GameMode != ControlStatus.Hosting)
                {
                    GenerateGameButtons(tsbd); // The board is alread Decoded.
                }
                //Update the Score View and set all scores to zero.
                foreach (var item in GameInfo.Players.Players)
                {
                    GameInfo.GameScore.UpdateScore(item, 0);
                }
                //GameInfo.BoardData = theSharedBoardData;
                GameInfo.StartGame(GameInfo.GameName);
            }
            //Someone Joined
            if (tsbd.Message == SharedTicTacToeBoardData.MessageCode.Join)
            {
                GameInfo.Players.JoinGame(tsbd.MessageSender); ;
                tsbd.Message = SharedTicTacToeBoardData.MessageCode.SyncBoard;
                tsbd.MessageSender = GameInfo.Player;
                tsbd.GameSize = GameInfo.GameOptions.GridSize;
                SendMessage(GameInfo.GameName, GameInfo.Player, tsbd);
                GameInfo.PlayersChanged(); // Allow the Start Button if there are more than 1 players.
            }
            //Watch Only mode
            if (tsbd.Message == SharedTicTacToeBoardData.MessageCode.Watch)
            {
                GameInfo.Players.WatchGame(tsbd.MessageSender);
                tsbd.Message = SharedTicTacToeBoardData.MessageCode.SyncBoard;
                tsbd.MessageSender = GameInfo.Player;
                tsbd.GameSize = GameInfo.GameOptions.GridSize;
                SendMessage(GameInfo.GameName, GameInfo.Player, tsbd);
                //Watching should not count for PlayersChanged.
            }
            //Should be only someone not hosting the game
            //SyncBoard is actually generate game buttons from the Host generated game
            if (tsbd.Message == SharedTicTacToeBoardData.MessageCode.SyncBoard)
            {
                //Only need to sync the board if not hosting
                if (GameInfo.GameMode != ControlStatus.Hosting)
                {
                    GenerateGameButtons(tsbd); // The board is alread Decoded.
                }
            }
            if (tsbd.Message == SharedTicTacToeBoardData.MessageCode.LeaveGame)
            {
                GameInfo.Players.LeaveGame(tsbd.MessageSender);
                GameInfo.PlayersChanged(); // Only allow the Start Button if more than 1 player
                //TODO Remove the Board now.
            }
            if (tsbd.Message == SharedTicTacToeBoardData.MessageCode.Move)
            {
                
                IPlayer p = tsbd.MessageSender;
                string btnName = tsbd.MessageValue;
                string symbol = tsbd.MessageString;
                //Do Everything that happens when Clicking a button except resending the Move.
                //Button b = null;
                foreach (Control item in bgGame.Controls)
                {
                    if (item.Name == tsbd.MessageValue)
                    {
                        DoButtonClick((item as MMManagerTTTButton), symbol);
                    }

                }
                _stttbd = tsbd; // Sync with what the Host Sent
            }
            if (tsbd.Message == SharedTicTacToeBoardData.MessageCode.GameOver)
            {
                if (GameInfo.GameMode != ControlStatus.Hosting)
                {
                    GameInfo.GameOver("unknown"); // Just acknowledging the Game Over Message.
                }
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
