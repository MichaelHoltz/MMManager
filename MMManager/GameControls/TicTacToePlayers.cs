using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MMManager.GameInterfaces;
namespace MMManager.GameControls
{
    public partial class TicTacToePlayers : UserControl, IPlayer
    {
        int TempCount = 0;



        public TicTacToePlayers()
        {
            InitializeComponent();
        }


        public string PlayerName { get; set; } = "Guest";
        public char PlayerSymbol { get; set; }

        public bool PlayerTurn
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public bool PlayerWon 
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public void JoinGame(string playerName, int startingScore)
        {
            ticTacToeScore1.JoinGame(playerName, 0);
        }

        public void LeaveGame(string playerName)
        {
            ticTacToeScore1.LeaveGame(playerName);
        }

        public void UpdateScore(string playerName, int currentScore)
        {
            ticTacToeScore1.UpdateScore(playerName, currentScore);
        }

        public int GetScore(string playerName)
        {
            return  ticTacToeScore1.GetScore(playerName);
        }
    }
}
