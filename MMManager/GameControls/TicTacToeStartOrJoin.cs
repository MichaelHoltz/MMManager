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
    public partial class TicTacToeStartOrJoin : UserControl
    {
        public TicTacToeStartOrJoin()
        {
            InitializeComponent();
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
        }

        private void btnStartGame_Click(object sender, EventArgs e)
        {
            //This button can be enabled if one or more players have joined.
        }

        private void lbAvailableGames_Click(object sender, EventArgs e)
        {

        }
    }
}
