using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MMManager.GameInterfaces;
using MMManager.GameObjects;
namespace MMManager.GameControls
{
    public partial class TicTacToePlayers : UserControl, IPlayers, IScore
    {

        public TicTacToePlayers()
        {
            InitializeComponent();
        }
        //*********************************************************************************
        #region IPlayer interface
        //*********************************************************************************
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
        //*********************************************************************************
        #endregion
        //*********************************************************************************

        public IScore ScoreBoard { get; set; }
        //*********************************************************************************
        #region IPlayers Interface
        //*********************************************************************************
        public List<PlayerClass> Players { get; set; }
        //{
        //    get
        //    {
        //        throw new NotImplementedException();
        //    }

        //    set
        //    {
        //        throw new NotImplementedException();
        //    }
        //}

        public PlayerClass Player { get; set; }
        //{
        //    get
        //    {
        //        throw new NotImplementedException();
        //    }

        //    set
        //    {
        //        throw new NotImplementedException();
        //    }
        //}

        //*********************************************************************************
        #endregion
        //*********************************************************************************

        //*********************************************************************************
        #region IScore Interface
        //*********************************************************************************
        public void JoinGame(string playerName, int startingScore)
        {
            
            //Players.Add(playerName);
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
        public void ClearAllPlayers()
        {
            ScoreBoard.ClearAllPlayers();

        }

        public void WatchGame(string playerName)
        {
            ScoreBoard.WatchGame(playerName);
        }

        //*********************************************************************************
        #endregion IScore
        //*********************************************************************************





        private void TicTacToePlayers_Load(object sender, EventArgs e)
        {
            ScoreBoard = ticTacToeScore1;
            Player = ticTacToePlayer1.Player;
            Players = new List<PlayerClass>();
        }
    }
}
