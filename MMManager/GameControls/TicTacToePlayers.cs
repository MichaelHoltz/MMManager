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
            Players = new List<PlayerClass>(); // Must create here as it is read only
            
        }
        private void TicTacToePlayers_Load(object sender, EventArgs e)
        {
            ScoreBoard = ticTacToeScore1;
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
                ticTacToeScore1.PlayerName = value;
            }
        }

        public int PlayerSymbol
        {
            get
            {
                return ticTacToePlayer1.PlayerSymbol;
            }

            set
            {
                ticTacToePlayer1.PlayerSymbol = value;
                ticTacToeScore1.PlayerSymbol = value;
            }
        }

        public int PlayerScore
        {
            get
            {
                return ticTacToePlayer1.PlayerScore;
            }

            set
            {
                ticTacToePlayer1.PlayerScore = value;
                ticTacToeScore1.PlayerScore = value;
            }
        }

        public string PlayerStatus
        {
            get
            {
                return ticTacToePlayer1.PlayerStatus;
            }
            set
            {
                ticTacToePlayer1.PlayerStatus = value;
                ticTacToeScore1.PlayerStatus = value;
            }
        }
        //*********************************************************************************
        #endregion
        //*********************************************************************************

        public IScore ScoreBoard {
            get
            {
                return ticTacToeScore1;
            }
            set
            {
                ticTacToeScore1 = (TicTacToeScore)value;
            }
        }
        //*********************************************************************************
        #region IPlayers Interface
        //*********************************************************************************
        public List<PlayerClass> Players { get;  }

        public PlayerClass Player
        {
            get
            {
                return this;
            }
            set
            {
                if (value != null)
                {
                    PlayerName = value.PlayerName;
                    PlayerSymbol = value.PlayerSymbol;
                    PlayerStatus = value.PlayerStatus;
                }
                
                
            }
                
        }



        public void JoinGame(IPlayer player)
        {
            Players.Add((PlayerClass)player); //Directly add to a list.
            ScoreBoard.JoinGame(player);
        }
        public void WatchGame(IPlayer player)
        {
            Players.Add((PlayerClass)player);
            ScoreBoard.WatchGame(player);
        }
        public void LeaveGame(IPlayer player)
        {
            if (Players.Find(x => x.PlayerName == player.PlayerName) != null)
            {
                Players.Remove(Players.Find(x => x.PlayerName == player.PlayerName));
            }
            //Players.Remove((PlayerClass)player);
            ScoreBoard.LeaveGame(player);
        }
        //*********************************************************************************
        #endregion
        //*********************************************************************************

        //*********************************************************************************
        #region IScore Interface
        //*********************************************************************************


        public void UpdateScore(IPlayer player, int currentScore)
        {
            ScoreBoard.UpdateScore(player, currentScore);
        }

        public int GetScore(IPlayer player)
        {
            return ScoreBoard.GetScore(player);
        }
        public void ClearAllPlayers()
        {
            ScoreBoard.ClearAllPlayers();

        }



        //*********************************************************************************
        #endregion IScore
        //*********************************************************************************

        /// <summary>
        /// Creates a snapshot Copy of this IPlayer to PlayerClass - Does not update this control if changed
        /// </summary>
        /// <param name="v"></param>
        public static implicit operator PlayerClass(TicTacToePlayers v)
        {
            return new PlayerClass() { PlayerName = v.PlayerName,  PlayerSymbol = v.PlayerSymbol, PlayerScore=v.PlayerScore, PlayerStatus = v.PlayerStatus };

        }

        /// <summary>
        /// Creates a snapshot Copy of this IPlayer to PlayerClass - Does not update this control if changed
        /// </summary>
        /// <param name="v"></param>
        public static implicit operator List<PlayerClass>(TicTacToePlayers v)
        {
            List<PlayerClass> allPlayers = new List<PlayerClass>();
            allPlayers = v.Players;
            return allPlayers;

        }

    }
}
