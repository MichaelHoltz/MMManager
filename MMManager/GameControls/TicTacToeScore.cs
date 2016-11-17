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
    public partial class TicTacToeScore : UserControl, IScore
    {
        private Dictionary<String, int> PlayerScores { get; set; }

        public List<PlayerClass> Players { get; }

        public PlayerClass Player { get; set; }

        public string PlayerName { get; set; }

        public char PlayerSymbol { get; set; }
        public int PlayerScore { get; set; }
        public string PlayerStatus { get; set; }

        public TicTacToeScore()
        {
            InitializeComponent();
            PlayerScores = new Dictionary<string, int>();
            Players = new List<PlayerClass>();
            dataGridView1.DataSource = Players.ToList();

        }
        /// <summary>
        /// Add Player Name to Score Board and Sets Score to zero
        /// </summary>
        /// <param name="player"></param>
        /// <returns></returns>
        public void JoinGame(IPlayer player)
        {
            try
            {
                if (Players.Find(x => x.PlayerName == player.PlayerName) == null)
                {
                    Players.Add((PlayerClass)player);
                }
                else
                {
                    MessageBox.Show(player.PlayerName + " Already Taken");
                }
                dataGridView1.DataSource = Players.ToList();
            }
            catch
            {
                MessageBox.Show( player.PlayerName + " Already Taken");
            }
            //return result;
            return;
        }
        /// <summary>
        /// Adds a Person as a watcher.
        /// </summary>
        /// <param name="player"></param>
        public void WatchGame(IPlayer player)
        {
            try
            {
                if (Players.Find(x => x.PlayerName == player.PlayerName) == null)
                {
                    Players.Add((PlayerClass)player);
                }
                else
                {
                    MessageBox.Show(player.PlayerName + " Already Taken");
                }
                dataGridView1.DataSource = Players.ToList();
            }
            catch
            {
                MessageBox.Show(player.PlayerName + " Already Taken");
            }
            //return result;
            return;

        }
        public void LeaveGame(IPlayer player)
        {
            var match = Players.Find(x => x.PlayerName == player.PlayerName);
            if (match != null)
            {
                Players.Remove(match);
            }
            
            dataGridView1.DataSource = Players.ToList();
        }

        public int GetScore(IPlayer player)
        {
            return Players.Find(x => x.PlayerName == player.PlayerName).PlayerScore;
            //return PlayerScores[player.PlayerName]; // What if the player Name isn't there
            
        }
        public void UpdateScore(IPlayer player, int score)
        {
            // dataGridView1.Columns[1].Visible = true; // Show the Score if setting it.
            Players.Find(x => x.PlayerName == player.PlayerName).PlayerScore = score;
            //PlayerScores[player.PlayerName] = score;
          //  dataGridView1.DataSource = PlayerScores.ToList();
        }

        private void TicTacToeScore_Load(object sender, EventArgs e)
        {

        }

        public void ClearAllPlayers()
        {
            Players.Clear();
            PlayerScores.Clear();
            //dataGridView1.Columns[1].Visible = false; // Show the Score if setting it.
            dataGridView1.DataSource = Players.ToList();

        }
    }
}
