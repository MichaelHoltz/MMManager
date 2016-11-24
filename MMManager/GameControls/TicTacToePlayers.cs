using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MMManager.GameInterfaces;
using MMManager.GameObjects;
namespace MMManager.GameControls
{
    public partial class TicTacToePlayers : UserControl, IPlayers
    {
        private System.Windows.Media.MediaPlayer mp;
        private void P2_MediaEnded(object sender, EventArgs e)
        {
            //(sender as System.Windows.Media.MediaPlayer).Position = TimeSpan.Zero;
            //(sender as System.Windows.Media.MediaPlayer).Play();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            mp = new System.Windows.Media.MediaPlayer();
            mp.MediaEnded += P2_MediaEnded;
            string currentDir = System.IO.Directory.GetCurrentDirectory();
            //SoundPlayer simpleSound = new SoundPlayer(currentDir + @"\Sounds\Bomb_Exploding.wav");
            //mp.Open(new System.Uri(@"C:\Projects\MMManager\MMManager\Sounds\GameWaitingMusic.wav"));
            mp.Open(new System.Uri(@"PlayerAdd.mp3"));
            mp.Play();
        }
        private void playSound(int sound)
        {
            mp = new System.Windows.Media.MediaPlayer();
            string currentDir = System.IO.Directory.GetCurrentDirectory() + @"\Sounds\";
            if (sound == 1)
            {
                mp.Open(new System.Uri(currentDir + @"PlayerAdd.mp3"));
            }
            if (sound == 2)
            {
                mp.Open(new System.Uri(currentDir + @"PlayerRemove.mp3"));
            }

            mp.Play();


        }

        public TicTacToePlayers()
        {


            InitializeComponent();
            PlayerList = new List<PlayerClass>(); // Must create here as it is read only
        }
        private void TicTacToePlayers_Load(object sender, EventArgs e)
        {
          //  ScoreBoard = ticTacToeScore1;
          //  Player = ticTacToePlayer1;
        }

 
        public IScore ScoreBoard {
            get
            {
                return ticTacToeScore1;
            }
            set
            {
                ticTacToeScore1 = (TicTacToeScore)value;
            }
        }
        //*********************************************************************************
        #region IPlayers Interface
        //*********************************************************************************
        public List<PlayerClass> PlayerList { get; set; }

        public MMManager.GameControls.TicTacToePlayer Player
        {
            get
            {
                return ticTacToePlayer1;
            }
            set
            {
                
                if (value != null)
                {
                    ticTacToePlayer1 = value;
                   // ticTacToePlayer1.PlayerName = value.PlayerName;
                   // ticTacToePlayer1.PlayerSymbol = value.PlayerSymbol;
                   // ticTacToePlayer1.PlayerStatus = value.PlayerStatus;
                   // ticTacToePlayer1.PlayerScore = value.PlayerScore;
                }
                
                
            }
                
        }



        public void JoinGame(IPlayer player)
        {
            try
            {
                if (PlayerList.Find(x => x.PlayerName == player.PlayerName) == null)
                {
                    PlayerList.Add(player.ToClass());
                    playSound(1);
                }
                else
                {
                    //MessageBox.Show(player.PlayerName + " Already Taken");
                }
                ScoreBoard.RefreshData(PlayerList);
            }
            catch
            {
                MessageBox.Show(player.PlayerName + " Already Taken");
            }
        }
        public void WatchGame(IPlayer player)
        {
            try
            {
                if (PlayerList.Find(x => x.PlayerName == player.PlayerName) == null)
                {
                    PlayerList.Add((PlayerClass)player);
                }
                else
                {
                    MessageBox.Show(player.PlayerName + " Already Taken");
                }
                ScoreBoard.RefreshData(PlayerList); 
            }
            catch
            {
                MessageBox.Show(player.PlayerName + " Already Taken");
            }
        }
        public void LeaveGame(IPlayer player)
        {
            var match = PlayerList.Find(x => x.PlayerName == player.PlayerName);
            if (match != null)
            {
                PlayerList.Remove(match);
                playSound(2);
            }
            ScoreBoard.RefreshData(PlayerList);
        }
        //*********************************************************************************
        #endregion
        //*********************************************************************************

        //*********************************************************************************
        #region IScore Interface
        //*********************************************************************************


        //public void UpdateScore(IPlayer player, int currentScore)
        //{
        //    ScoreBoard.UpdateScore(player, currentScore);
        //}

        //public int GetScore(IPlayer player)
        //{
        //    return ScoreBoard.GetScore(player);
        //}
        public void ClearAllPlayers()
        {
            PlayerList.Clear();
            ScoreBoard.RefreshData(PlayerList);

        }



        //*********************************************************************************
        #endregion IScore
        //*********************************************************************************

        ///// <summary>
        ///// Creates a snapshot Copy of this IPlayer to PlayerClass - Does not update this control if changed
        ///// </summary>
        ///// <param name="v"></param>
        //public static implicit operator PlayerClass(TicTacToePlayers v)
        //{
        //    return new PlayerClass() { PlayerName = v.Player.PlayerName,  PlayerSymbol = v.Player.PlayerSymbol, PlayerScore= v.Player.PlayerScore, PlayerStatus = v.Player.PlayerStatus };

        //}

        ///// <summary>
        ///// Creates a snapshot Copy of this IPlayer to PlayerClass - Does not update this control if changed
        ///// </summary>
        ///// <param name="v"></param>
        //public static implicit operator List<PlayerClass>(TicTacToePlayers v)
        //{
        //    List<PlayerClass> allPlayers = new List<PlayerClass>();
        //    allPlayers = v.Players;
        //    return allPlayers;

        //}

    }
}
