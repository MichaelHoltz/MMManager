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
    [Serializable]
    public partial class TicTacToePlayer : UserControl, IPlayer
    {
        private bool playerTurn;
        private bool playerWon;
        public TicTacToePlayer()
        {
            InitializeComponent();
        }

        public string PlayerName
        {
            get
            {
                return lblName.Text;
            }

            set
            {
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
                playerWon = value;
                if (value)
                    lblState.Text = "You Won!";
                else
                    lblState.Text = "Waiting..";
            }
        }
        //
        public IScore ScoreBoard { get; set; }

    }
}
