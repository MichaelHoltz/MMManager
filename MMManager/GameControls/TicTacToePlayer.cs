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

    public partial class TicTacToePlayer : UserControl, IPlayer
    {
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
        public int PlayerSymbol
        {
            get
            {
                if (
                    lblSymbol.Text.Length > 0)
                    return Convert.ToInt32(lblSymbol.Text); //.ToCharArray()[0];
                else
                    return 0;
            }

            set
            {
                lblSymbol.Text = value.ToString();
            }
        }
        public int PlayerScore { get; set; }
        public string PlayerStatus
        {
            get
            {
                return lblStatus.Text;
            }

            set
            {
                lblStatus.Text = value;
            }
        }



        
        /// <summary>
        /// Creates a snapshot Copy of this IPlayer to PlayerClass - Does not update this control if changed
        /// </summary>
        /// <param name="v"></param>
        public static implicit operator PlayerClass(TicTacToePlayer v)
        {
            return new PlayerClass() { PlayerName = v.PlayerName,  PlayerSymbol = v.PlayerSymbol, PlayerScore = v.PlayerScore, PlayerStatus = v.PlayerStatus, };

        }

    }
}
