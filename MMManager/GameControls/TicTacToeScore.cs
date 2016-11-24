using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using MMManager.GameInterfaces;
using MMManager.GameObjects;
using MMManager.Controls;
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
            //dataGridView1.BackgroundImage = null;
        }

        public int GetScore(IPlayer player)
        {
            return Players.Find(x => x.PlayerName == player.PlayerName).PlayerScore;
            //return PlayerScores[player.PlayerName]; // What if the player Name isn't there
            
        }
        public void UpdateScore(IPlayer player, int score, SharedTicTacToeBoardData theBoard)
        {
            
            foreach (PlayerClass p in theBoard.Players)
            {
                if (p.PlayerName == player.PlayerName)
                {
                    p.PlayerScore = score; //Update theBoard
                }
                Players.Find(x => x.PlayerName == p.PlayerName).PlayerScore = p.PlayerScore; // This just updates this player
            }
            // Game.theBoard.Players.Find(x => x.PlayerName == player.PlayerName).PlayerScore = currentScore; // Update just the GameBoard Player
            RefreshData(Players);
        }

        private void TicTacToeScore_Load(object sender, EventArgs e)
        {

        }


        public void RefreshData(List<PlayerClass> players)
        {
            Players = players; // Assign Locally
            dataGridView1.DataSource = players.ToList();
            try
            {
                foreach (DataGridViewRow r in dataGridView1.Rows)
                {
                    DataGridViewImageCell ic = r.Cells["IPSymbol"] as DataGridViewImageCell;
                    //DataGridViewImageCell ic2 = r.Cells["IPSymbol"] as DataGridViewImageCell;
                    ic.Value = _ButtonImageList.Images[Convert.ToInt32(r.Cells["PSymbol"].Value)]; //PSymbol or PlayerSymbol
                }
            }
            catch(Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }
        public ImageList ButtonImageList
        {
            get { return _ButtonImageList; }
            set
            {
                _ButtonImageList.ImageSize = new System.Drawing.Size(20, 20);
                foreach (System.Drawing.Image item in value.Images)
                {
                    _ButtonImageList.Images.Add(item);
                }
               // dataGridView1.Columns["pButtonImageList"]
                //_ButtonImageList = value;
                //lblSymbol.ImageList = _ButtonImageList;
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            dataGridView1.ClearSelection();
        }
    }
}
