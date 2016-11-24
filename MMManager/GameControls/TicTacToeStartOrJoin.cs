using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MMManager.GameInterfaces;
using MMManager.GameObjects;
using MMManager.Controls;
namespace MMManager.GameControls
{
    public partial class TicTacToeStartOrJoin : UserControl, IGameInfo
    {
        private System.Windows.Media.MediaPlayer mp;
        private ControlStatus _gameMode;
        private SharedTicTacToeBoardData.GameState _gameState;
        public TicTacToeStartOrJoin()
        {
            InitializeComponent();
        }
        public void playSound(int sound)
        {
            mp = new System.Windows.Media.MediaPlayer();
            string currentDir = System.IO.Directory.GetCurrentDirectory() + @"\Sounds\";
            if (sound == 1)
            {
                mp.Open(new System.Uri(currentDir + @"GameStart.mp3"));
            }
            if (sound == 2)
            {
                mp.Open(new System.Uri(currentDir + @"PlayerRemove.mp3"));
            }
            if (sound == 3) // Cat's Game
            {
                mp.Open(new System.Uri(currentDir + @"TomCat.wav"));
            }
            if (sound == 4) // GameOver Game
            {
                mp.Open(new System.Uri(currentDir + @"GameEnd.wav"));
            }
            if (sound == 10) // Random Move
            {
                mp.Open(new System.Uri(currentDir + @"move1.wav"));
            }
            if (sound == 11) // Random Move
            {
                mp.Open(new System.Uri(currentDir + @"move2.wav"));
            }

            if (sound == 12) // Random Move
            {
                mp.Open(new System.Uri(currentDir + @"move3.wav"));
            }

            if (sound == 13) // Random Move
            {
                mp.Open(new System.Uri(currentDir + @"move4.wav"));
            }

            if (sound == 14) // Random Move
            {
                mp.Open(new System.Uri(currentDir + @"move5.wav"));
            }

            if (sound == 15) // Random Move
            {
                mp.Open(new System.Uri(currentDir + @"move6.wav"));
            }

            if (sound == 16) // Random Move
            {
                mp.Open(new System.Uri(currentDir + @"move7.wav"));
            }


            mp.Play();



        }
        public IGameOptions GameOptions
        {
            get
            {
                return this.ticTacToeOptions1;
            }
            set
            {
                //Do nothing.
            }
        }
        public string GameName { get; set; }

        public IGame Game { get; set; }

        public IScore GameScore
        {
            get
            {
                return ticTacToePlayers1.ScoreBoard;
            }
            set
            {
                ticTacToePlayers1.ScoreBoard = value;
            }

        }

        public TicTacToePlayer Player {

            get
            {
                return ticTacToePlayers1.Player;
            }
            set
            {
                ticTacToePlayers1.Player = value;
            }
        }

        public TicTacToePlayers Players
        {
            get
            {
                return ticTacToePlayers1;
            }
            set
            {
                ticTacToePlayers1 = Players;
            }

        }
        public ControlStatus GameMode  
        {
            get
            {
                return _gameMode;
            }

            set
            {
                _gameMode = value;
                switch (_gameMode)
                {
                    case ControlStatus.Unknown:
                        panel1.Visible = false;
                        panel2.Visible = false;
                        break;
                    case ControlStatus.Hosting:
                        panel2.Visible = false;
                        panel1.Visible = true;
                        break;
                    case ControlStatus.Joined:
                        panel1.Visible = false;
                        panel2.Visible = true;
                        break;
                    case ControlStatus.Watching:
                        panel1.Visible = false;
                        panel2.Visible = false;
                        break;
                    default:
                        break;
                }
            }
        }

        public SharedTicTacToeBoardData.GameState GameState
        {
            get
            {
                return _gameState;
            }

            set
            {
                _gameState = value;
                switch (_gameState)
                {
                    case SharedTicTacToeBoardData.GameState.Waiting:
                        btnJoin.Text = "Join";
                        btnWatch.Text = "Watch";
                        Players.Player.PlayerStatus = "Waiting..";
                        rbHost.Enabled = true;
                        break;
                    case SharedTicTacToeBoardData.GameState.Playing:
                        panel1.Visible = false;
                        panel2.Visible = false;
                        btnCreateRemove.Enabled = false;
                        btnStartGame.Enabled = false;
                        break;
                    case SharedTicTacToeBoardData.GameState.GameOver:
                        if (GameMode == ControlStatus.Hosting)
                        {
                            panel2.Visible = false;
                            panel1.Visible = true;
                            btnCreateRemove.Enabled = true;
                            btnStartGame.Enabled = true;
                            btnJoin.Enabled = true;
                            btnWatch.Enabled = true;
                            //Buttons Need to be managed.
                        }
                        if (GameMode == ControlStatus.Joined || GameMode==ControlStatus.Watching)
                        {
                            panel1.Visible = false;
                            panel2.Visible = true;
                        }
                        break;
                    default:
                        break;
                }
            }
        }

        private void RequestRefreshGame()
        {

            Game.theBoard.Message = SharedTicTacToeBoardData.MessageCode.RefreshGameList; ;
            Game.theBoard.MessageSender = Player.ToClass();
            Game.SendMessage(Game.theBoard.GameName, Player.ToClass(), Game.theBoard);
            //SEND a message to Get Responses from Connected Players

        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RequestRefreshGame();
        }

        private void btnWatch_Click(object sender, EventArgs e)
        {
            //This is for Just Watching the Game.. And allows there to be multiple Games on the same network
            MessageBox.Show("Not implemented yet. - Is just like Join");
            if (btnWatch.Text == "Watch")
            {
                btnJoin.Enabled = false;
                WatchGame(Player);
                Game.theBoard.Message = SharedTicTacToeBoardData.MessageCode.Watch;
                Game.theBoard.MessageSender = Player.ToClass();
                Game.theBoard.MessageString = lbAvailableGames.SelectedItem.ToString();
                Game.SendMessage(lbAvailableGames.SelectedItem.ToString(), Player.ToClass(), Game.theBoard); // Send message to Everyone
                btnWatch.Text = "Leave";
                rbHost.Enabled = false;
            }
            else
            {
                btnJoin.Enabled = true;
                LeaveGame(Player);
                Game.theBoard.Message = SharedTicTacToeBoardData.MessageCode.StopWatching;
                Game.theBoard.MessageSender = Player.ToClass();
                Game.theBoard.MessageString = lbAvailableGames.SelectedItem.ToString();
                Game.SendMessage(lbAvailableGames.SelectedItem.ToString(), Player.ToClass(), Game.theBoard); // Send message to Everyone
                btnWatch.Text = "Watch";
                rbHost.Enabled = true;

            }
        }

        private void btnJoin_Click(object sender, EventArgs e)
        {
            if (btnJoin.Text == "Join") //Join
            {
                btnWatch.Enabled = false;
                //ticTacToePlayers1.PlayerSymbol =  theSharedTicTacToBoardData.NextSymbol; // Need to Get this from the Host.
                Player.PlayerStatus = "Joined Game";
                JoinGame(Player);
                Game.theBoard.Message = SharedTicTacToeBoardData.MessageCode.Join;
                Game.theBoard.MessageSender = Player.ToClass();
                Game.theBoard.MessageString = lbAvailableGames.SelectedItem.ToString();
                Game.SendMessage(lbAvailableGames.SelectedItem.ToString(), Player.ToClass(), Game.theBoard); // Send message to Everyone
                btnJoin.Text = "Leave";
                rbHost.Enabled = false;
            }
            else // Leave
            {
                btnWatch.Enabled = true;
                Player.PlayerStatus = "Left Game";
                LeaveGame(Player);
                Game.theBoard.Message = SharedTicTacToeBoardData.MessageCode.LeaveGame;
                Game.theBoard.MessageSender = Player.ToClass();
                Game.theBoard.MessageString = lbAvailableGames.SelectedItem.ToString();
                Game.SendMessage(lbAvailableGames.SelectedItem.ToString(), Player.ToClass(), Game.theBoard); // Send message to Everyone
                Game.ResetGame(Game.theBoard); // Using as Remove Game.
                btnJoin.Text = "Join";
                rbHost.Enabled = true;
            }
            //Sign up to Play the Game that is selected.
            //Toggle to Leave Game
        }

        private void processGameSelection()
        {
            RequestRefreshGame();
            if (lbAvailableGames.Items.Count > 0 && lbAvailableGames.SelectedItem != null)
            {
                if (lbAvailableGames.SelectedItem.ToString() != "No Games Found")
                {
                    if (Game.theBoard.State != SharedTicTacToeBoardData.GameState.Playing)
                    {
                        btnJoin.Enabled = true;
                    }
                    btnWatch.Enabled = true;
                    GameName = Game.theBoard.GameName;
                    foreach (var item in Game.theBoard.Players)
                    {
                        Players.JoinGame(item); //Show the Players already Joined to the Game
                    }

                }
                else
                {
                    GameName = string.Empty; // Set to empty Game name.
                    btnJoin.Enabled = false;
                    btnWatch.Enabled = false;
                    //Add Players from the game.


                }
            }
            else
            {
                btnJoin.Enabled = false;
                btnWatch.Enabled = false;

            }

        }

        private void lbAvailableGames_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Enable or Disable the Join and Watch buttons
            //processGameSelection();
        }
        private void lbAvailableGames_Click(object sender, EventArgs e)
        {
            processGameSelection();
        }
        private void btnCreateRemove_Click(object sender, EventArgs e)
        {
            //Create a game - if a game has been created but hasn't been started it can be removed.
            if (btnCreateRemove.Text == "Create Game")
            {

                btnCreateRemove.Text = "Remove Game";

                GameName = Player.PlayerName + "'s Game";      // Must Be Set Before GeneratingNewGame Should allow modification eventually 
                Game.theBoard = GenerateNewGame(); // Get a blank board after generating the game.
                Player.PlayerStatus = "Created Game";
                AddGame(GameName);
                JoinGame(Player);
                
                rbJoinGame.Enabled = false;
                Game.SendMessage(GameName, Player.ToClass(), Game.theBoard); // Send message to Everyone

            }
            else // Remove Game
            {
                //ControlStatus.Unknown
                btnCreateRemove.Text = "Create Game";
                Player.PlayerStatus = "Removed Game";
                //ticTacToePlayers1.Player.PlayerStatus = "Removed Game";
                btnStartGame.Enabled = false; // Can't start a game if there isn't one.
                LeaveGame(Player);
                Players.ClearAllPlayers(); // Clear all scores.
                Game.theBoard.Players.Clear();
                RemoveGame(GameName);
                rbJoinGame.Enabled = true;


                Game.theBoard.Message = SharedTicTacToeBoardData.MessageCode.RemoveGame;
                Game.theBoard.MessageString = GameName;
                Game.SendMessage(GameName, Player.ToClass(), Game.theBoard); // Send message to Everyone
                Game.ResetGame(Game.theBoard);

                //DO Housekeeping to remove the game.
            }
        }

        private void btnStartGame_Click(object sender, EventArgs e)
        {
            GameState = SharedTicTacToeBoardData.GameState.Playing; // Manage Buttons and Panels
            if (btnStartGame.Text == "Start New Game") // Generate New Board with same settings
            {
                Game.theBoard = Game.GenerateNewGame();
            }
            else // First game and re-set Score.
            {
                foreach (var item in Players.PlayerList) 
                {
                    GameScore.UpdateScore(item, 0, Game.theBoard);
                }
            }
            Game.theBoard.MessageSender = Player.ToClass();
            Game.theBoard.Message = SharedTicTacToeBoardData.MessageCode.Start; //Set Message to Start the game
            Game.theBoard.MessageString = GameName;

            Random r = new Random(DateTime.Now.Millisecond);
            bool myTurn = false;
            Game.theBoard.WhosTurn = Game.GetNextPlayer(Players.PlayerList[r.Next(0, Players.PlayerList.Count)]);
            if (Game.theBoard.WhosTurn.PlayerName == Player.PlayerName)
                myTurn = true; // What if there is a +x?
            else
                myTurn = false;
            Game.AllButtonsAllowClick(myTurn);
            //Who's Turn is it?
            //            theSharedTicTacToBoardData.WhosTurn = Player.ToClass(); // Make it my turn
            //            Game.AllButtonsAllowClick(true); //The Host can click
            playSound(1); // Game Start
            Game.SendMessage(GameName, Player.ToClass(), Game.theBoard); // Send message to Everyone
        }




        public void PlayersChanged()
        {
            //Players is null!!
                btnStartGame.Enabled = (Players.PlayerList.Count > 1 && btnCreateRemove.Text == "Remove Game");
            
        }
        /// <summary>
        /// Function Called when the Host has started the game.
        /// </summary>
        /// <param name="gameName"></param>
        public void StartGame(string gameName)
        {
            //gameName is ignored but could be used
            panel1.Visible = false;
            panel2.Visible = false;
            playSound(1); //Game Starting
        }
        public void AddGame(string gameName)
        {
            if (lbAvailableGames.Items.Count == 1)
            {
                lbAvailableGames.Items.Remove("No Games Found");
            }
            //Only add if it's not already on the list.
            if (!lbAvailableGames.Items.Contains(gameName))
            {
                lbAvailableGames.Items.Add(gameName);
            }
        }
        public void RemoveGame(string gameName)
        {
            this.lbAvailableGames.Items.Remove(gameName);
            if (lbAvailableGames.Items.Count == 0)
            {
                lbAvailableGames.Items.Add("No Games Found");
            }
        }

        public void RefreshGameList()
        {
            throw new NotImplementedException();
        }


        public SharedTicTacToeBoardData GenerateNewGame()
        {
            //Game.
            return Game.GenerateNewGame(); // Actually Generates the Game.
        }

        public void GameOver(string results)
        {
            //Need to Know who won.
            //Need to Check if Hosting, Joined, or Watching.
            GameState = SharedTicTacToeBoardData.GameState.GameOver;
            Game.AllButtonsEnable(false);
            //Dangerous because it seems that this is going to be re-sent even if it was already sent and just being responded to.
            Game.theBoard.Message = SharedTicTacToeBoardData.MessageCode.GameOver;
            Game.theBoard.MessageSender = Player.ToClass(); // Me
            Game.theBoard.MessageString = results; // To Update the Status.
            Game.theBoard.State = SharedTicTacToeBoardData.GameState.GameOver;
            Game.SendMessage(GameName, Player.ToClass(), Game.theBoard);
            if (GameMode == ControlStatus.Hosting)
            {
                if (btnStartGame.Text == "Start Game" || btnStartGame.Text == "Start Game")
                {
                    btnStartGame.Text = "Start New Game";
                }
            }



        }
        public void JoinGame(IPlayer player)
        {
            Players.JoinGame(player);
            if (Game.theBoard.Players.Find(x => x.PlayerName == player.PlayerName) == null)
            {
                Game.theBoard.Players.Add(player.ToClass()); // Add this Player.
            }
            else
            {
                int dummy = 1;
            }
        }

        public void LeaveGame(IPlayer player)
        {
            Players.LeaveGame(player);
            //Seems to be removing the first player it finds .. seems wrong
            Game.theBoard.Players.Remove(Game.theBoard.Players.Find(x => x.PlayerName == player.PlayerName)); // Remove this Player.
        }
        public void WatchGame(IPlayer player)
        {
            Players.WatchGame(player);
            if (!Game.theBoard.Players.Contains(Game.theBoard.Players.Find(x => x.PlayerName == player.PlayerName)))
            {
                Game.theBoard.Players.Add(player.ToClass()); // Add this Player.
            }
            else
            {
                int dummy = 1;
            }
        }

        //public void ClearAllPlayers()
        //{
        //    Players.ClearAllPlayers();
        //    Game.theBoard.Players.Clear(); // Removes all players
        //}
        //public void UpdateScore(IPlayer player, int currentScore)
        //{
        //    Players.UpdateScore(player, currentScore);
        //    Game.theBoard.Players.Find(x => x.PlayerName == player.PlayerName).PlayerScore = currentScore; // Update just the GameBoard Player
        //    //Game.theBoard.Players = ticTacToePlayers1.PlayerList; // Update Score by replacing Players completly..
        //    //GameScore.UpdateScore(player, currentScore);
        //}

        //public int GetScore(IPlayer player)
        //{
        //    return Players.GetScore(player);
        //}

        private void TicTacToeStartOrJoin_Load(object sender, EventArgs e)
        {
            //Players = ticTacToePlayers1.Players; // new List<PlayerClass>();
            //Player = ticTacToePlayers1.Player;
           // GameScore = this.ticTacToePlayers1.ScoreBoard;
            panel1.Left = 218;
            panel2.Left = 218;

        }


        private void rbHost_CheckedChanged(object sender, EventArgs e)
        {
            GameMode = ControlStatus.Hosting;
        }

        private void rbJoinGame_CheckedChanged(object sender, EventArgs e)
        {
            GameMode = ControlStatus.Joined;
        }



        private void ticTacToePlayers1_Load(object sender, EventArgs e)
        {
            //Players = ticTacToePlayers1;
            //Player = ticTacToePlayers1.Player;
        }
    }
}
