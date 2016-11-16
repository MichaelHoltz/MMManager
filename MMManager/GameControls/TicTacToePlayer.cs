using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MMManager.GameInterfaces;
using MMManager.GameObjects;
namespace MMManager.GameControls
{
    [Serializable]
    public partial class TicTacToePlayer : UserControl, IPlayer
    {
        private bool playerTurn;
        private bool playerWon;
        public TicTacToePlayer()
        {
            InitializeComponent();
           // player = new PlayerClass();
        }
        private PlayerClass player = new PlayerClass();
        public string PlayerName
        {
            get
            {
                return lblName.Text;
            }

            set
            {
                player.PlayerName = value;
                lblName.Text = value;
            }
        }

        public char PlayerSymbol
        {
            get
            {
                return lblSymbol.Text.ToCharArray()[0];
            }

            set
            {
                lblSymbol.Text = value.ToString();
            }
        }

        public bool PlayerTurn
        {
            get
            {
                return playerTurn;
            }

            set
            {
                player.PlayerTurn = value;
                playerTurn = value;
                if (value)
                    lblState.Text = "Your Turn";
                else
                    lblState.Text = "Waiting..";
            }
        }

        public bool PlayerWon
        {
            get
            {
                return playerWon;
            }

            set
            {
                player.PlayerWon = value;
                playerWon = value;
                if (value)
                    lblState.Text = "You Won!";
                else
                    lblState.Text = "Waiting..";
            }
        }
        //
        public IScore ScoreBoard { get; set; }

        public PlayerClass Player
        {
            get
            {
                return player;
            }

            set
            {
                player = value;
                PlayerName = player.PlayerName;
                PlayerSymbol = player.PlayerSymbol;
                PlayerTurn = player.PlayerTurn;
                PlayerWon = player.PlayerWon;
            }
        }

        private void TicTacToePlayer_Load(object sender, EventArgs e)
        {
            player = new PlayerClass();
        }
    }
}
