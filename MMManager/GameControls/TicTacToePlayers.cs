using System;
using System.Windows.Forms;
using MMManager.GameInterfaces;
namespace MMManager.GameControls
{
    public partial class TicTacToePlayers : UserControl, IPlayer, IScore
    {
        public TicTacToePlayers()
        {
            InitializeComponent();
        }
        public string PlayerName
        { 
            get
            {
                return ticTacToePlayer1.PlayerName;
            }

            set
            {
                ticTacToePlayer1.PlayerName = value;
            }
        }

        public char PlayerSymbol
        {
            get
            {
                return ticTacToePlayer1.PlayerSymbol;
            }

            set
            {
                ticTacToePlayer1.PlayerSymbol = value;
            }
        }
        public bool PlayerTurn
        {
            get
            {
                return ticTacToePlayer1.PlayerTurn;
            }

            set
            {
                ticTacToePlayer1.PlayerTurn = value;
            }
        }

        public bool PlayerWon 
        {
            get
            {
                return ticTacToePlayer1.PlayerWon;
            }

            set
            {
                ticTacToePlayer1.PlayerWon = value;
            }
        }

        public IScore ScoreBoard { get; set; }

        public void JoinGame(string playerName, int startingScore)
        {
            ScoreBoard.JoinGame(playerName, 0);
            
        }

        public void LeaveGame(string playerName)
        {
            ScoreBoard.LeaveGame(playerName);
        }

        public void UpdateScore(string playerName, int currentScore)
        {
            ScoreBoard.UpdateScore(playerName, currentScore);
        }

        public int GetScore(string playerName)
        {
            return ScoreBoard.GetScore(playerName);
        }

        private void ticTacToePlayer1_Load(object sender, EventArgs e)
        {
            ScoreBoard = ticTacToeScore1;
        }

        private void TicTacToePlayers_Load(object sender, EventArgs e)
        {
            ScoreBoard = ticTacToeScore1;
        }

        public void ClearAllPlayers()
        {
            ScoreBoard.ClearAllPlayers();

        }

        public void WatchGame(string playerName)
        {
            ScoreBoard.WatchGame(playerName);
        }
    }
}
