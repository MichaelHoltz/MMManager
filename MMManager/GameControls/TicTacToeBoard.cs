﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Media;
using MMManager.GameInterfaces;
using MMManager.GameObjects;
using MMManager.CommInterfaces;

namespace MMManager.GameControls
{
    [Serializable]
    public partial class TicTacToeBoard : UserControl,IGame
    {
        private SharedTicTacToeBoardData _stttbd; //Contains all neeeded
        private MMManagerTTTButton theButton; //Shared Button Object
        private int messagesReceivedCount = 0;
        private String[] letters = new String[3] {"M", "N", "\0" };
        private int letterPos = 0;
        private int TotalNumMoves = 0;

        int maxY = 0;
        int maxX = 0;
        private int lastGridSize = 0;
        int maxBombCount = 2;
        private int[,] grid;
        MMManagerTTTButton[,] b;
        private Color bColor;
        private Boolean myTurn = true; // Default to my Turn.
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

        public ImageList ButtonImageList
        {
            get
            {
                return _ButtonImageList;
            }

            set
            {
                _ButtonImageList = value;
            }
        }

        public SharedTicTacToeBoardData theBoard
        {
            get
            {
                return _stttbd;
            }

            set
            {
                _stttbd = value;
                //throw new NotImplementedException();
            }
        }

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
            if (lastGridSize > 0)
                maxX = lastGridSize;
            else
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
                    //sharedTicTacToeBoardData.GameBoard[index++] = '\0'; //Clear 1d Grid
                    //if (grid != null)
                    //{
                    //    grid[y, x] = '\0';
                    //}
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
            lastGridSize = maxX; // Save for later
            maxY = maxX; // Keep Symetry
            int y = 0;
            int x = 0;
            int index = 0;

            
            b = new MMManagerTTTButton[maxY, maxX]; //2d array of buttons.
            grid = new int[maxY, maxX];
            if(GameInfo.GameMode == ControlStatus.Hosting)
                sharedTicTacToeBoardData.GameBoard = new int[maxX * maxY];

            for (y = 0; y < maxY; y++)
            {
                for (x = 0; x < maxX; x++)
                {
                    b[y, x] = new MMManagerTTTButton();
                    b[y, x].Name = "B" + y + x;
                    b[y, x].Text = String.Empty;                     //Clear Button
                    b[y, x].ImageIndex = 0;                         //Clear Images
                    if (GameInfo.GameMode == ControlStatus.Hosting)
                    {
                        sharedTicTacToeBoardData.GameBoard[index++] = 0; //Clear 1d Grid
                        grid[y, x] = 0;                                  //Clear 2d Grid
                        b[y, x].Tag = "0";
                    }
                    else
                    {
                        grid[y, x] = sharedTicTacToeBoardData.GameBoard[index]; //Set the 2d Grid
                        b[y, x].Tag = sharedTicTacToeBoardData.GameBoard[index++]; // Set tag from shared Board.
                    }
                    b[y, x].Font = new Font("Microsoft Sans Serif", 12);
                    b[y, x].Visible = true;
                    b[y, x].Width = 50;
                    b[y, x].Height = 50;
                    b[y, x].Left = (x * 50) + 10;
                    b[y, x].Top = (y * 50) + 20;
                    b[y, x].Click += Button_Click;
                    b[y, x].ImageList = ButtonImageList;
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
                    if (b[y, x].Tag.ToString() == "1") // Using the Button Tag
                    {
                        sharedTicTacToeBoardData.GameBoard[y * maxY + x] = 1;
                    }
                    //What about moves?
                }
            }
            return sharedTicTacToeBoardData;
        }
        /// <summary>
        /// Go from One Dimensional Array to 2.
        /// </summary>
        /// <param name="sharedTicTacToeBoardData"></param>
        /// <returns></returns>
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
                if (sharedTicTacToeBoardData.GameBoard[i] == 1)
                {
                    y = i / maxY;
                    x = i % maxX;
                    b[y, x].Text = string.Empty;
                    b[y, x].ImageIndex = 0;
                  //  b[y, x].Text = "b"; // Display's the Bombs For Debugging 
                    b[y, x].Tag = "1";
                    grid[y, x] = 1; // Put it in the local Grid
                }
                else
                {
                    y = i / maxY;
                    x = i % maxX;
                    b[y, x].Text = string.Empty;
                    b[y, x].ImageIndex = 0;
                    b[y, x].Tag = "0";
                    grid[y, x] = 0; //Put it in the local Grid
                }

            }
            return sharedTicTacToeBoardData;
        }
        public SharedTicTacToeBoardData GenerateNewGame()
        {
            if (_stttbd == null)
            {
                _stttbd = new SharedTicTacToeBoardData(); //Nothing here! - There will be no players here
            }
            _stttbd.GameSize = GameInfo.GameOptions.GridSize; // Set Grid Size to shared
            _stttbd.MessageSender = GameInfo.Player.ToClass();
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

//            _stttbd.Players.Add(GameInfo.Player); // Add the Host to the list of players when Generating a New Game
//            SymbolPos = 0; // Reset to start with X or the first symbol


//            getCurrentTurn(); //Show Who's Turn it is
            return _stttbd;
        }
        public SharedTicTacToeBoardData ResetGame(SharedTicTacToeBoardData sharedTicTacToeBoardData)
        {
            //Clear the Board and do the same logic as Generating the Game.. 
            return RemoveGameButtons(sharedTicTacToeBoardData);

        }
        private bool CheckWin(int y, int x, int n, ref int winLine, List<Point> winningList)
        {
            bool win = true;
            Point p = new Point(x, y);
            winningList.Add(p);
            if (n == 0) // Set first Symbol in the line
                winLine = grid[y, x];
            //winLine &= grid[y, x]; // Anding them together. but that is limiting.
            if (winLine != grid[y, x] || winLine == 0)
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

            int winLine = 0; //Null
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
                    //grid[y, x] = btn.Text.ToCharArray(0, 1)[0];
                    grid[y, x] = btn.ImageIndex; //.Text.ToCharArray(0, 1)[0];
                    for (int i = 0; i < _stttbd.Players.Count; i++) // Was PCOUNT
                    {
                        if (grid[y, x] == _stttbd.Players[i].PlayerSymbol) // was symbols[i]
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

        /// <summary>
        /// Figure Out who's turn it is
        /// </summary>
        /// <returns></returns>
        public int GetCurrentSymbol()
        {
            //need a shared index so that the players can take turns
            label1.Text = "It's " + _stttbd.Players[0].PlayerName + "'s Turn";
            return _stttbd.Players[0].PlayerSymbol;
        }
        /// <summary>
        /// Function to get the next person's turn by symbol
        /// </summary>
        /// <returns></returns>
        private int getCurrentTurn()
        {
            label1.Text = "It's " + _stttbd.Players[0].PlayerName + "'s Turn";
            return _stttbd.Players[0].PlayerSymbol;
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
            int s = GameInfo.Player.PlayerSymbol; //  GetCurrentSymbol().ToString(); // Use the Current Symbol
            //Show Who's Turn it is

            _stttbd.MessageSender = GameInfo.Player.ToClass();
            _stttbd.Message = SharedTicTacToeBoardData.MessageCode.Move;
            _stttbd.MessageValue = theButton.Name;
            _stttbd.MessageString = s.ToString(); 
            SendMessage(GameInfo.GameName, GameInfo.Player.ToClass(), _stttbd);
            //In normal play it can't be my turn again.. but with +1 it can be.
            if (_stttbd.WhosTurn.PlayerName == GameInfo.Player.PlayerName)
                myTurn = true; // What if there is a +x?
            else
                myTurn = false;
            DoButtonClick(theButton, s);

        }
        private void DoButtonClick(MMManagerTTTButton theButtonClicked, int s)
        {
           // int currentSymbol = getCurrentTurn();

            theButton = theButtonClicked; // set for timer
            if (theButton.Tag.ToString() != "1") // Normal Move
            {
                //theButton.Text = s;
                theButton.ImageIndex = s;
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
            if (myTurn)
            {
                AllButtonsAllowClick(true);
            }
            else
            {
                AllButtonsAllowClick(false);
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            string currentDir = System.IO.Directory.GetCurrentDirectory();
            SoundPlayer simpleSound = new SoundPlayer(currentDir + @"\Sounds\Bomb_Exploding.wav");
            if (letterPos == 0)
            {
                theButton.Font = new Font("Wingdings", 20);
                
                simpleSound.Play();

            }
            theButton.Text = letters[letterPos++];
            if (letterPos > 2) // Max
            {
                letterPos = 0; // Reset for next time
                timer2.Enabled = false;
                theButton.Font = new Font("Microsoft Sans Serif", 12);
                simpleSound.Stop();
                theButton.Text = string.Empty;
                theButton.ImageIndex = 0;
                //ONly If it's their Turn
                if (myTurn)
                {
                    AllButtonsAllowClick(true);
                }
                else
                {
                    AllButtonsAllowClick(false);
                }

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
            GameInfo.Player.PlayerStatus = messagesReceivedCount++.ToString(); // Debugging
            #region Not GameName Specific
            //Someone is sending out a request looking for Games
            if (tsbd.Message == SharedTicTacToeBoardData.MessageCode.RefreshGameList)
            {
                if (GameInfo.GameMode == ControlStatus.Hosting)
                {
                    //Must have a game Generated for this to make sense.
                    if (_stttbd != null && _stttbd.Players.Count > 0)
                    {
                        tsbd = _stttbd; // Set to what is being Hosted
                        tsbd.MessageSender = GameInfo.Player.ToClass();
                        tsbd.Message = SharedTicTacToeBoardData.MessageCode.NewGame;
                        tsbd.MessageString = GameInfo.GameName;
                        SendMessage(GameInfo.GameName, GameInfo.Player.ToClass(), tsbd); // Send message to Everyone
                    }
                }
            }
            //A new Game has been published
            if (tsbd.Message == SharedTicTacToeBoardData.MessageCode.NewGame)
            {
                GameInfo.BoardData = tsbd;
                GameInfo.AddGame(tsbd.MessageString);

            }
            //A game has be removed
            if (tsbd.Message == SharedTicTacToeBoardData.MessageCode.RemoveGame)
            {
                GameInfo.GameState = SharedTicTacToeBoardData.GameState.Waiting;
                tsbd.Players.Clear(); // THis is the received Message and doesn't do anything but for the next message..
                theBoard.Players.Clear(); // This removes the internal players.
                GameInfo.RemoveGame(tsbd.MessageString);
                GameInfo.Players.ClearAllPlayers();
                ResetGame(tsbd);

            }
            #endregion 

            if (tsbd.GameName != GameInfo.GameName)
            {
                //Want to return to filter messages
                //Debugging Message Only
                if (tsbd.Message == SharedTicTacToeBoardData.MessageCode.RefreshGameList 
                    || tsbd.Message == SharedTicTacToeBoardData.MessageCode.NewGame
                    || tsbd.Message == SharedTicTacToeBoardData.MessageCode.RemoveGame)
                {
                    //Don't do anything
                }
                else
                {
                    MessageBox.Show("\"" + tsbd.GameName + "\" doesn't equal \"" + GameInfo.GameName + "\" - Message=" + tsbd.Message.ToString());
                }
                return; // Get out
            }


            //Message Received to start TicTacToe
            if (tsbd.Message == SharedTicTacToeBoardData.MessageCode.Start)
            {
                
                _stttbd = tsbd; // Sync with what the Host Sent
                GameInfo.BoardData = tsbd;
                if (GameInfo.GameMode != ControlStatus.Hosting)
                {
                    ResetGame(tsbd);
                    GenerateGameButtons(tsbd); // The board is alread Decoded.
                }
                AllButtonsAllowClick(true); //ALLOW anyone to click for now
                //Update the Score View and set all scores to zero.
                foreach (var item in GameInfo.Players.PlayerList)
                {
                    GameInfo.GameScore.UpdateScore(item, 0);
                }
                //GameInfo.BoardData = theSharedBoardData;
                GameInfo.StartGame(GameInfo.GameName);
            }
            //Someone Joined
            if (tsbd.Message == SharedTicTacToeBoardData.MessageCode.Join)
            {
                GameInfo.Players.JoinGame(tsbd.MessageSender);
                if (_stttbd.Players.Find(x => x.PlayerName == tsbd.MessageSender.PlayerName) == null)
                {
                    _stttbd.Players.Add(tsbd.MessageSender);
                }
                tsbd.Message = SharedTicTacToeBoardData.MessageCode.SyncBoard;
                tsbd.MessageSender = GameInfo.Player.ToClass();
                tsbd.GameSize = GameInfo.GameOptions.GridSize;
                SendMessage(GameInfo.GameName, GameInfo.Player.ToClass(), tsbd);
                GameInfo.PlayersChanged(); // Allow the Start Button if there are more than 1 players.
            }
            //Watch Only mode
            if (tsbd.Message == SharedTicTacToeBoardData.MessageCode.Watch)
            {
                GameInfo.Players.WatchGame(tsbd.MessageSender);
                //GameInfo.Players.WatchGame(tsbd.MessageSender);
                tsbd.Message = SharedTicTacToeBoardData.MessageCode.SyncBoard;
                tsbd.MessageSender = GameInfo.Player.ToClass();
                tsbd.GameSize = GameInfo.GameOptions.GridSize;
                SendMessage(GameInfo.GameName, GameInfo.Player.ToClass(), tsbd);
                //Watching should not count for PlayersChanged.
            }
            //Should be only someone not hosting the game
            //SyncBoard is actually generate game buttons from the Host generated game
            if (tsbd.Message == SharedTicTacToeBoardData.MessageCode.SyncBoard)
            {
                //Only need to sync the board if not hosting
                if (GameInfo.GameMode != ControlStatus.Hosting)
                {
                    _stttbd = tsbd; // Sync local with what the Host Sent
                    ResetGame(tsbd);
                    GenerateGameButtons(tsbd); // The board is alread Decoded.
                }
            }
            if (tsbd.Message == SharedTicTacToeBoardData.MessageCode.LeaveGame)
            {
                PlayerClass p = _stttbd.Players.Find(x => x.PlayerName == tsbd.MessageSender.PlayerName);
                if (p != null)
                {
                    _stttbd.Players.Remove(p);
                }

                GameInfo.Players.LeaveGame(tsbd.MessageSender); //tsbd already accounts for the player who left..
                GameInfo.PlayersChanged(); // Only allow the Start Button if more than 1 player
                //TODO Remove the Board now.
            }
            if (tsbd.Message == SharedTicTacToeBoardData.MessageCode.Move)
            {
                
                IPlayer p = tsbd.MessageSender;
                string btnName = tsbd.MessageValue;
                int symbol = Convert.ToInt32(tsbd.MessageString);
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
                if (_stttbd.WhosTurn.PlayerName == GameInfo.Player.PlayerName)
                    myTurn = true; // What if there is a +x?
                else
                    myTurn = false;
                
            }
            if (tsbd.Message == SharedTicTacToeBoardData.MessageCode.GameOver)
            {
                if (GameInfo.GameMode != ControlStatus.Hosting)
                {
                   // GameInfo.GameOver("unknown"); // Just acknowledging the Game Over Message.
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
