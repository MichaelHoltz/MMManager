using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MMManager.GameControls
{
    public partial class TicTacToeScore : UserControl
    {
        private Dictionary<String, int> PlayerScores { get; set; }
        public TicTacToeScore()
        {
            InitializeComponent();
            PlayerScores = new Dictionary<string, int>();
        }
        /// <summary>
        /// Add Player Name to Score Board and Sets Score to zero
        /// </summary>
        /// <param name="playerName"></param>
        /// <returns></returns>
        public bool AddPlayer(string playerName)
        {
            bool result = false;
            try
            {
                PlayerScores.Add(playerName, 0);
                result = true;
            }
            catch
            {
                result = false;
            }
            return result;
        }

        public void UpdatePlayerScore(string playerName, int score)
        {
            PlayerScores[playerName] = score;
        }
    }
}
