using System;
using System.Windows.Forms;
using MMManager.GameInterfaces;
using MMManager.GameObjects;
namespace MMManager.GameControls
{

    public partial class TicTacToePlayer : UserControl, IPlayer
    {
        private string _playerName;
        private int _playerSymbol;
        private string _playerStatus;
        public TicTacToePlayer()
        {

            InitializeComponent();
        }

        /// <summary>
        /// The Players Name
        /// </summary>
        public string PlayerName
        {
            get
            {
                return _playerName;
            }

            set
            {
                _playerName = value;
                lblName.Text = value;
            }
        }
        /// <summary>
        /// The Player's Symbol - which is actually the index for an Image List
        /// </summary>
        public int PlayerSymbol
        {
            get
            {
                return _playerSymbol;
                //if (
                //    lblSymbol.Text.Length > 0)
                //    return Convert.ToInt32(lblSymbol.Text); //.ToCharArray()[0];
                //else
                //    return 0;
            }

            set
            {
                _playerSymbol = value;
             //   lblSymbol.ImageList = ButtonImageList;
                lblSymbol.ImageIndex = value;
               // lblSymbol.Text = value.ToString();
            }
        }
        /// <summary>
        /// The Player's Current Score.
        /// </summary>
        public int PlayerScore { get; set; }
        public string PlayerStatus
        {
            get
            {
                return _playerStatus;
                //return lblStatus.Text;
            }

            set
            {
                _playerStatus = value;
                lblStatus.Text = value;
            }
        }

        public ImageList ButtonImageList
        {
            get { return _ButtonImageList; }
            set {
                _ButtonImageList.ImageSize = new System.Drawing.Size(25, 25);
                foreach (System.Drawing.Image item in value.Images)
                {
                    _ButtonImageList.Images.Add(item);
                }
                
                //_ButtonImageList = value;
                lblSymbol.ImageList = _ButtonImageList;
            }
        }

        /// <summary>
        /// Return the IPlayer as a PlayerClass
        /// </summary>
        /// <returns></returns>
        public PlayerClass ToClass()
        {
            return new PlayerClass() { PlayerName = this.PlayerName, PlayerSymbol = this.PlayerSymbol, PlayerScore = this.PlayerScore, PlayerStatus = this.PlayerStatus, };
        }


        #region Unused Code but may be of interest
        /// <summary>
        /// Creates a snapshot Copy of this IPlayer to PlayerClass - Does not update this control if changed
        /// </summary>
        /// <param name="v"></param>
        //public static implicit operator PlayerClass(TicTacToePlayer v)
        //{
        //    return new PlayerClass() { PlayerName = v.PlayerName, PlayerSymbol = v.PlayerSymbol, PlayerScore = v.PlayerScore, PlayerStatus = v.PlayerStatus, };

        //}
        #endregion
    }
}
