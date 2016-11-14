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
    public partial class TicTacToeScore : UserControl, IScore
    {
        private Dictionary<String, int> PlayerScores { get; set; }
        public TicTacToeScore()
        {
            InitializeComponent();
            PlayerScores = new Dictionary<string, int>();
            
            dataGridView1.DataSource = PlayerScores.ToList();

            dataGridView1.Columns[1].Visible = false; // Default to Hiding the Score.

        }
        /// <summary>
        /// Add Player Name to Score Board and Sets Score to zero
        /// </summary>
        /// <param name="playerName"></param>
        /// <returns></returns>
        public void JoinGame(string playerName, int startingScore)
        {
            try
            {
                PlayerScores.Add(playerName, 0);
                dataGridView1.DataSource = PlayerScores.ToList();
               // dataGridView1.Refresh();
            }
            catch
            {
                MessageBox.Show( playerName + " Already Taken");
            }
            //return result;
            return;
        }
        /// <summary>
        /// Adds a Person as a watcher.
        /// </summary>
        /// <param name="playerName"></param>
        public void WatchGame(string playerName)
        {
            try
            {
                PlayerScores.Add(playerName, 0);
                dataGridView1.DataSource = PlayerScores.ToList();
                // dataGridView1.Refresh();
            }
            catch
            {
                MessageBox.Show(playerName + " Already Taken");
            }
            //return result;
            return;

        }
        public void LeaveGame(string playerName)
        {
            PlayerScores.Remove(playerName);
            dataGridView1.DataSource = PlayerScores.ToList();
        }

        public int GetScore(string playerName)
        {
            return PlayerScores[playerName]; // What if the player Name isn't there
            
        }
        public void UpdateScore(string playerName, int score)
        {
            dataGridView1.Columns[1].Visible = true; // Show the Score if setting it.
            PlayerScores[playerName] = score;
            dataGridView1.DataSource = PlayerScores.ToList();
        }

        private void TicTacToeScore_Load(object sender, EventArgs e)
        {

        }

        public void ClearAllPlayers()
        {
            PlayerScores.Clear();
            dataGridView1.Columns[1].Visible = false; // Show the Score if setting it.
            dataGridView1.DataSource = PlayerScores.ToList();

        }
    }
}
