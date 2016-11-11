using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using MMManager.GameInterfaces;
namespace MMManager.GameControls
{
    public partial class TicTacToeStartOrJoin : UserControl, IGameInfo
    {
        private ControlStatus _gameMode;
        private GameFlowStatus _gameStatus;
//        private IGameInfo _gameInfo;
//        private IScore _gameScore;
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
        public string PlayerName { get; set; }
        public char PlayerSymbol { get; set; }

        public bool PlayerTurn { get; set; }

        public bool PlayerWon { get; set; }

        public IGame Game { get; set; }
        //{
        //    get
        //    {

        //        return _game;
        //    }
        //    set
        //    {
                
        //        _game = value;
        //        //_Game.GameOptions = this.ticTacToeOptions1;
        //    }
        //}

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
                        panel3.Visible = false;
                        panel1.Visible = true;
                        break;
                    case ControlStatus.Joined:
                        panel1.Visible = false;
                        panel3.Visible = false;
                        panel2.Visible = true;
                        break;
                    case ControlStatus.Watching:
                        panel1.Visible = false;
                        panel2.Visible = false;
                        panel3.Visible = true;
                        break;
                    default:
                        break;
                }
            }
        }

        public GameFlowStatus GameStatus
        {
            get
            {
                return _gameStatus;
            }

            set
            {
                _gameStatus = value;
                switch (_gameStatus)
                {
                    case GameFlowStatus.Waiting:
                        break;
                    case GameFlowStatus.Playing:
                        panel1.Visible = false;
                        panel2.Visible = false;
                        panel3.Visible = true;

                        break;
                    case GameFlowStatus.GameOver:
                        if (GameMode == ControlStatus.Hosting)
                        {
                            panel2.Visible = false;
                            panel3.Visible = false;
                            panel1.Visible = true;
                        }
                        if(GameMode == ControlStatus.Joined || GameMode==ControlStatus.Watching)
                        {
                            panel1.Visible = false;
                            panel3.Visible = false;
                            panel2.Visible = true;
                        }
                        break;
                    default:
                        break;
                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            //SEND a message to Get Responses from Connected Players
        }

        private void btnWatch_Click(object sender, EventArgs e)
        {
            //This is for Just Watching the Game.. And allows there to be multiple Games on the same network
        }

        private void btnJoin_Click(object sender, EventArgs e)
        {
            //Sign up to Play the Game that is selected.
            //Toggle to Leave Game
        }

        private void lbAvailableGames_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Enable or Disable the Join and Watch buttons
        }

        private void btnCreateRemove_Click(object sender, EventArgs e)
        {
            //Create a game - if a game has been created but hasn't been started it can be removed.
            if (btnCreateRemove.Text == "Create Game")
            {
                btnCreateRemove.Text = "Remove Game";
                //this.GameName = this.pl
                
                GameName = PlayerName + "'s Game";
                GenerateNewGame();
                AddGame(GameName);
                btnStartGame.Enabled = true; // Allow the game to be started.. want to wait for other players usually.
            }
            else
            {
                btnCreateRemove.Text = "Create Game";
                btnStartGame.Enabled = false; // Can't start a game if there isn't one.
                LeaveGame(PlayerName);
                RemoveGame(GameName);

                //DO Housekeeping to remove the game.
            }
        }

        private void btnStartGame_Click(object sender, EventArgs e)
        {
            if (btnStartGame.Text == "Start Game")
            {
                panel1.Visible = false;
                panel2.Visible = false;
                panel3.Visible = true;    
                btnCreateRemove.Enabled = false;
                btnStartGame.Enabled = false;
                btnStartGame.Text = "Playing Game";
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
        public void GenerateNewGame()
        {
            //Game.
            Game.GenerateNewGame(); // Actually Generates the Game.
        }

        public void GameOver(string results)
        {
            //Need to Check if Hosting, Joined, or Watching.
            GameStatus = GameFlowStatus.GameOver;
            if (btnStartGame.Text == "Playing Game")
            {
                btnCreateRemove.Enabled = true;
                btnStartGame.Enabled = false;
                btnStartGame.Text = "Start Game";
            }

        }
        public void JoinGame(string playerName, int startingScore)
        {
            GameScore.JoinGame(playerName, startingScore);
            //throw new NotImplementedException();
        }

        public void LeaveGame(string playerName)
        {
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
            GameScore = this.ticTacToeScore1;
            panel1.Left = 6;
            panel2.Left = 6;
            panel3.Left = 6;

        }

        private void btnHostGame_Click(object sender, EventArgs e)
        {
            GameMode = ControlStatus.Hosting;
        }

        private void btnJoinGame_Click(object sender, EventArgs e)
        {
            GameMode = ControlStatus.Joined;
        }
    }
}
