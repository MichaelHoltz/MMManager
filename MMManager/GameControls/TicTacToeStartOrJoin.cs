using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using MMManager.GameInterfaces;
using MMManager.GameObjects;

namespace MMManager.GameControls
{
    public partial class TicTacToeStartOrJoin : UserControl, IGameInfo
    {
        private ControlStatus _gameMode;
        private SharedTicTacToeBoardData theSharedTicTacToBoardData;
        private SharedTicTacToeBoardData.GameState _gameState;
        public TicTacToeStartOrJoin()
        {
            InitializeComponent();
           // Players = new List<PlayerClass>();
            theSharedTicTacToBoardData = new SharedTicTacToeBoardData(); // Empty Board.
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

        public PlayerClass Player {

            get
            {
                return ticTacToePlayers1.Player;
            }
            set
            {
                ticTacToePlayers1.Player = value;
            }
        }
        List<PlayerClass> IPlayers.Players
        {
            get
            {
                return ticTacToePlayers1.Players;
            }
        }
        public IPlayers Players
        {
            get
            {
                return ticTacToePlayers1;
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
                        ticTacToePlayers1.PlayerStatus = "Waiting..";
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



        public SharedTicTacToeBoardData BoardData
        {
            get
            {
                return theSharedTicTacToBoardData;
            }

            set
            {
                theSharedTicTacToBoardData = value;
            }
        }

        public string PlayerName
        {
            get
            {
                return ticTacToePlayers1.PlayerName;
                
            }

            set
            {
                ticTacToePlayers1.PlayerName = value;
            }
        }

        public int PlayerSymbol
        {
            get
            {
                return ticTacToePlayers1.PlayerSymbol;
                
            }

            set
            {
                ticTacToePlayers1.PlayerSymbol = value;
            }
        }
        public int PlayerScore
        {
            get
            {
                return ticTacToePlayers1.PlayerScore;
            }
            set
            {
                ticTacToePlayers1.PlayerScore = value;
            }
        }
        public string PlayerStatus
        {
            get
            {
                return ticTacToePlayers1.PlayerStatus;
            }

            set
            {
                ticTacToePlayers1.PlayerStatus = value;
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            if (theSharedTicTacToBoardData == null)
            {
                theSharedTicTacToBoardData = new SharedTicTacToeBoardData(); // Make a new empty one 
            }

            theSharedTicTacToBoardData.Message = SharedTicTacToeBoardData.MessageCode.RefreshGameList;
            theSharedTicTacToBoardData.MessageSender = Player;
            Game.SendMessage("Looking For Games", Player, theSharedTicTacToBoardData);

            // Game.SendMessage("Looking for Games", PlayerName, )
            //SEND a message to Get Responses from Connected Players
        }

        private void btnWatch_Click(object sender, EventArgs e)
        {
            //This is for Just Watching the Game.. And allows there to be multiple Games on the same network
            MessageBox.Show("Not implemented yet.");
            if (btnWatch.Text == "Watch")
            {
                btnJoin.Enabled = false;
                WatchGame(Player);
                theSharedTicTacToBoardData.Message = SharedTicTacToeBoardData.MessageCode.Watch;
                theSharedTicTacToBoardData.MessageSender = Player;
                theSharedTicTacToBoardData.MessageString = lbAvailableGames.SelectedItem.ToString();
                Game.SendMessage(lbAvailableGames.SelectedItem.ToString(), Player, theSharedTicTacToBoardData); // Send message to Everyone
                btnWatch.Text = "Leave";
                rbHost.Enabled = false;
            }
            else
            {
                btnJoin.Enabled = true;
                LeaveGame(Player);
                theSharedTicTacToBoardData.Message = SharedTicTacToeBoardData.MessageCode.StopWatching;
                theSharedTicTacToBoardData.MessageSender = Player;
                theSharedTicTacToBoardData.MessageString = lbAvailableGames.SelectedItem.ToString();
                Game.SendMessage(lbAvailableGames.SelectedItem.ToString(), Player, theSharedTicTacToBoardData); // Send message to Everyone
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
                ticTacToePlayers1.PlayerStatus = "Joined Game";
                JoinGame(Player);
                theSharedTicTacToBoardData.Message = SharedTicTacToeBoardData.MessageCode.Join;
                theSharedTicTacToBoardData.MessageSender = Player;
                theSharedTicTacToBoardData.MessageString = lbAvailableGames.SelectedItem.ToString();
                Game.SendMessage(lbAvailableGames.SelectedItem.ToString(), Player, theSharedTicTacToBoardData); // Send message to Everyone
                btnJoin.Text = "Leave";
                rbHost.Enabled = false;
            }
            else // Leave
            {
                btnWatch.Enabled = true;
                ticTacToePlayers1.PlayerStatus = "Left Game";
                LeaveGame(Player);
                theSharedTicTacToBoardData.Message = SharedTicTacToeBoardData.MessageCode.LeaveGame;
                theSharedTicTacToBoardData.MessageSender = Player;
                theSharedTicTacToBoardData.MessageString = lbAvailableGames.SelectedItem.ToString();
                Game.SendMessage(lbAvailableGames.SelectedItem.ToString(), Player, theSharedTicTacToBoardData); // Send message to Everyone
                Game.ResetGame(theSharedTicTacToBoardData); // Using as Remove Game.
                btnJoin.Text = "Join";
                rbHost.Enabled = true;
            }
            //Sign up to Play the Game that is selected.
            //Toggle to Leave Game
        }

        private void lbAvailableGames_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Enable or Disable the Join and Watch buttons
            if (lbAvailableGames.Items.Count > 0 && lbAvailableGames.SelectedItem != null)
            {
                if (lbAvailableGames.SelectedItem.ToString() != "No Games Found")
                {
                    btnJoin.Enabled = true;
                    btnWatch.Enabled = true;
                    GameName = theSharedTicTacToBoardData.GameName;
                    foreach (var item in theSharedTicTacToBoardData.Players)
                    {
                        ticTacToePlayers1.JoinGame(item); //Show the Players already Joined to the Game
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
        private void btnCreateRemove_Click(object sender, EventArgs e)
        {
            //Create a game - if a game has been created but hasn't been started it can be removed.
            if (btnCreateRemove.Text == "Create Game")
            {
                btnCreateRemove.Text = "Remove Game";

                GameName = Player.PlayerName + "'s Game";      // Must Be Set Before GeneratingNewGame Should allow modification eventually 
                theSharedTicTacToBoardData = GenerateNewGame(); // Get a blank board after generating the game.

//                ticTacToePlayers1.PlayerSymbol = Game.GetCurrentSymbol();       //Attempt to Assign Symbols Automatically
//                theSharedTicTacToBoardData.NextSymbol = Game.GetCurrentSymbol();    //Works for Two Player only
                ticTacToePlayers1.PlayerStatus = "Created Game";
                AddGame(GameName);
                JoinGame(Player);
                
                rbJoinGame.Enabled = false;
                Game.SendMessage(GameName, Player, theSharedTicTacToBoardData); // Send message to Everyone

            }
            else // Remove Game
            {
                btnCreateRemove.Text = "Create Game";
                ticTacToePlayers1.PlayerStatus = "Removed Game";
                //btnStartGame.Enabled = false; // Can't start a game if there isn't one.
                LeaveGame(Player);
                GameScore.ClearAllPlayers();
                RemoveGame(GameName);
                rbJoinGame.Enabled = true;


                theSharedTicTacToBoardData.Message = SharedTicTacToeBoardData.MessageCode.RemoveGame;
                theSharedTicTacToBoardData.MessageString = GameName;
                Game.SendMessage(GameName, Player, theSharedTicTacToBoardData); // Send message to Everyone
                Game.ResetGame(theSharedTicTacToBoardData);

                //DO Housekeeping to remove the game.
            }
        }

        private void btnStartGame_Click(object sender, EventArgs e)
        {
            GameState = SharedTicTacToeBoardData.GameState.Playing; // Manage Buttons and Panels
            if (btnStartGame.Text == "Start New Game") // Generate New Board with same settings
            {
                theSharedTicTacToBoardData = Game.GenerateNewGame();
            }
            else // First game and re-set Score.
            {
                foreach (var item in Players.Players) 
                {
                    GameScore.UpdateScore(item, 0);
                }
            }
            theSharedTicTacToBoardData.MessageSender = Player;
            theSharedTicTacToBoardData.Message = SharedTicTacToeBoardData.MessageCode.Start; //Set Message to Start the game
            theSharedTicTacToBoardData.MessageString = GameName;
            //Who's Turn is it?
            
            Game.AllButtonsAllowClick(true); //The Host can click
            Game.SendMessage(GameName, Player, theSharedTicTacToBoardData); // Send message to Everyone
        }

        private void lbAvailableGames_Click(object sender, EventArgs e)
        {

        }


        public void PlayersChanged()
        {
            //Players is null!!
                btnStartGame.Enabled = (Players.Players.Count > 1 && btnCreateRemove.Text == "Remove Game");
            
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
            theSharedTicTacToBoardData.Message = SharedTicTacToeBoardData.MessageCode.GameOver;
            theSharedTicTacToBoardData.MessageSender = Player; // Me
            theSharedTicTacToBoardData.State = SharedTicTacToeBoardData.GameState.GameOver;
            Game.SendMessage(GameName, Player, theSharedTicTacToBoardData);
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
            ticTacToePlayers1.JoinGame(player);
            theSharedTicTacToBoardData.Players.Add(Player); // Add this Player.
        }

        public void LeaveGame(IPlayer player)
        {
            ticTacToePlayers1.LeaveGame(player);
            theSharedTicTacToBoardData.Players.Remove((PlayerClass)player); // Remove this Player.
        }
        public void WatchGame(IPlayer player)
        {
            ticTacToePlayers1.WatchGame(player);
            theSharedTicTacToBoardData.Players.Add((PlayerClass)player); // Remove this Player.
        }

        public void ClearAllPlayers()
        {
            ticTacToePlayers1.ClearAllPlayers();
        }
        public void UpdateScore(IPlayer player, int currentScore)
        {
            ticTacToePlayers1.UpdateScore(player, currentScore);
            theSharedTicTacToBoardData.Players = ticTacToePlayers1.Players; // Update Score by replacing Players completly..
            //GameScore.UpdateScore(player, currentScore);
        }

        public int GetScore(IPlayer player)
        {
            return ticTacToePlayers1.GetScore(player);
        }

        private void TicTacToeStartOrJoin_Load(object sender, EventArgs e)
        {
            //Players = ticTacToePlayers1.Players; // new List<PlayerClass>();
            //Player = ticTacToePlayers1.Player;
            GameScore = this.ticTacToePlayers1.ScoreBoard;
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
            //Player = ticTacToePlayers1.Player;
        }
    }
}
