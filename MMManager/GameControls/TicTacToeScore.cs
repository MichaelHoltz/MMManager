using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using MMManager.GameInterfaces;
using MMManager.GameObjects;

namespace MMManager.GameControls
{
    public partial class TicTacToeScore : UserControl, IScore
    {
        private Dictionary<String, int> PlayerScores { get; set; }

        private List<PlayerClass> Players { get; set; }
   
        public TicTacToeScore()
        {
            InitializeComponent();
            PlayerScores = new Dictionary<string, int>();
            Players = new List<PlayerClass>();
            dataGridView1.DataSource = Players.ToList();

        }

        public int GetScore(IPlayer player)
        {
            return Players.Find(x => x.PlayerName == player.PlayerName).PlayerScore;
            //return PlayerScores[player.PlayerName]; // What if the player Name isn't there
            
        }
        public void UpdateScore(IPlayer player, int score)
        {
            Players.Find(x => x.PlayerName == player.PlayerName).PlayerScore = score;
            RefreshData(Players);
        }

        private void TicTacToeScore_Load(object sender, EventArgs e)
        {

        }


        public void RefreshData(List<PlayerClass> players)
        {
            Players = players; // Assign Locally
            dataGridView1.DataSource = players.ToList();
        }
    }
}
