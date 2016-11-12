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

        public IScore GameScore { get; set; }

        public IPlayer Player { get; set; }
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
                        break;
                    case SharedTicTacToeBoardData.GameState.Playing:
                        panel1.Visible = false;
                        panel2.Visible = false;

                        break;
                    case SharedTicTacToeBoardData.GameState.GameOver:
                        if (GameMode == ControlStatus.Hosting)
                        {
                            panel2.Visible = false;
                            panel1.Visible = true;
                        }
                        if(GameMode == ControlStatus.Joined || GameMode==ControlStatus.Watching)
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

        public List<IPlayer> Players { get; set; }

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

        private void btnRefresh_Click(object sender, EventArgs e)
        {
           
           // Game.SendMessage("Looking for Games", PlayerName, )
            //SEND a message to Get Responses from Connected Players
        }

        private void btnWatch_Click(object sender, EventArgs e)
        {
            //This is for Just Watching the Game.. And allows there to be multiple Games on the same network
            MessageBox.Show("Not implemented yet.");
        }

        private void btnJoin_Click(object sender, EventArgs e)
        {
            if (btnJoin.Text == "Join")
            {

                JoinGame(Player.PlayerName, 0);
                theSharedTicTacToBoardData.Message = SharedTicTacToeBoardData.MessageCode.Join;
                theSharedTicTacToBoardData.MessageSender = Player.PlayerName;
                theSharedTicTacToBoardData.MessageString = lbAvailableGames.SelectedItem.ToString();
                Game.SendMessage(lbAvailableGames.SelectedItem.ToString(), Player.PlayerName, theSharedTicTacToBoardData); // Send message to Everyone
                btnJoin.Text = "Leave";
                rbHost.Enabled = false;
            }
            else
            {
                LeaveGame(Player.PlayerName);
                theSharedTicTacToBoardData.Message = SharedTicTacToeBoardData.MessageCode.LeaveGame;
                theSharedTicTacToBoardData.MessageSender = Player.PlayerName;
                theSharedTicTacToBoardData.MessageString = lbAvailableGames.SelectedItem.ToString();
                Game.SendMessage(lbAvailableGames.SelectedItem.ToString(), Player.PlayerName, theSharedTicTacToBoardData); // Send message to Everyone
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
                    foreach (var item in theSharedTicTacToBoardData.Players)
                    {
                        ticTacToePlayers1.JoinGame(item.PlayerName, 0);
                    }

                }
                else
                {
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
                //this.GameName = this.pl
                GameName = this.Player.PlayerName + "'s Game";
                theSharedTicTacToBoardData = GenerateNewGame(); // Get a blank board after generating the game.
                AddGame(GameName);
                JoinGame(Player.PlayerName, 0);
                btnStartGame.Enabled = true; // Allow the game to be started.. want to wait for other players usually.
                rbJoinGame.Enabled = false;
                Game.SendMessage(GameName, Player.PlayerName, theSharedTicTacToBoardData); // Send message to Everyone

            }
            else
            {
                btnCreateRemove.Text = "Create Game";
                btnStartGame.Enabled = false; // Can't start a game if there isn't one.
                LeaveGame(Player.PlayerName);
                GameScore.ClearAllPlayers();
                RemoveGame(GameName);
                rbJoinGame.Enabled = true;


                theSharedTicTacToBoardData.Message = SharedTicTacToeBoardData.MessageCode.RemoveGame;
                theSharedTicTacToBoardData.MessageString = GameName;
                Game.SendMessage(GameName, Player.PlayerName, theSharedTicTacToBoardData); // Send message to Everyone
                

                //DO Housekeeping to remove the game.
            }
        }

        private void btnStartGame_Click(object sender, EventArgs e)
        {
            if (btnStartGame.Text == "Start Game")
            {
                panel1.Visible = false; // Need these to be Setable or the Joiner will be stuck looking at Joinig
                panel2.Visible = false;
                btnCreateRemove.Enabled = false;
                btnStartGame.Enabled = false;
                //btnStartGame.Text = "Playing Game";
                theSharedTicTacToBoardData.MessageSender = Player.PlayerName;
                theSharedTicTacToBoardData.Message = SharedTicTacToeBoardData.MessageCode.Start;
                theSharedTicTacToBoardData.MessageString = GameName;
                Game.SendMessage(GameName, Player.PlayerName, theSharedTicTacToBoardData); // Send message to Everyone
            }
            //Should have Play Again?
            //This button can be enabled if one or more players have joined.
//            _gameInfo.GameName = _gameInfo.PlayerName + "'s Game";
//            _gameInfo.StartGame(_gameInfo.GameName);
        }

        private void lbAvailableGames_Click(object sender, EventArgs e)
        {

        }
  


        public void StartGame(string gameName)
        {
            //this.lbAvailableGames.Items.Add(gameName);

        }
        public void AddGame(string gameName)
        {
            if (lbAvailableGames.Items.Count == 1)
            {
                lbAvailableGames.Items.Remove("No Games Found");
            }
            lbAvailableGames.Items.Add(gameName);
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

        public void WatchGame()
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
            //Need to Check if Hosting, Joined, or Watching.
            GameState = SharedTicTacToeBoardData.GameState.GameOver;
            if (btnStartGame.Text == "Playing Game")
            {
                btnCreateRemove.Enabled = true;
                btnStartGame.Enabled = false;
                btnStartGame.Text = "Start Game";
            }

        }
        public void JoinGame(string playerName, int startingScore)
        {
            //IPlayer p = new TicTacToePlayers();
            //p.
            //Players.Add(new IPlayer())
            MMManager.GameObjects.Player p = new GameObjects.Player();
            p.PlayerName = Player.PlayerName;
            p.PlayerSymbol = Player.PlayerSymbol;
            p.PlayerTurn = Player.PlayerTurn;
            p.PlayerWon = Player.PlayerWon;
            theSharedTicTacToBoardData.Players.Add(p); // Add this Player.
            GameScore.JoinGame(playerName, startingScore);
            //throw new NotImplementedException();
        }

        public void LeaveGame(string playerName)
        {
            MMManager.GameObjects.Player p = new GameObjects.Player();
            p.PlayerName = Player.PlayerName;
            p.PlayerSymbol = Player.PlayerSymbol;
            p.PlayerTurn = Player.PlayerTurn;
            p.PlayerWon = Player.PlayerWon;
            theSharedTicTacToBoardData.Players.Remove(p); // Remove this Player.
            GameScore.LeaveGame(playerName);
            //throw new NotImplementedException();
        }

        public void UpdateScore(string playerName, int currentScore)
        {
            GameScore.UpdateScore(playerName, currentScore);
        }

        public int GetScore(string playerName)
        {
            return GameScore.GetScore(playerName);
        }

        private void TicTacToeStartOrJoin_Load(object sender, EventArgs e)
        {
            Player = this.ticTacToePlayers1;
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


    }
}
