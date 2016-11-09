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
    public partial class TicTacToePlayers : UserControl
    {
        public string PlayerName { get; set; } = "Guest";
        public TicTacToePlayers()
        {
            InitializeComponent();
        }

        private void btnJoin_Click(object sender, EventArgs e)
        {
            JoinGame("Dummy");
        }
        public bool JoinGame(string playerName)
        {
            ticTacToeScore1.AddPlayer(playerName);
            return true;
        }
        private void btnLeave_Click(object sender, EventArgs e)
        {

        }

        public bool LeaveGame(string playerName)
        {
            return true;
        }
    }
}
