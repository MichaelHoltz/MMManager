using System;
using System.Windows.Forms;
using MMManager.GameControls;
using MMManager.GameInterfaces;

namespace MMManager.GameObjects
{
    [Serializable]
    public class PlayerClass: IPlayer
    {
        public String PlayerName { get; set; }
        public int PlayerSymbol { get; set; }
        public int PlayerScore { get; set; }
        public String PlayerStatus { get; set; }
        public ImageList ButtonImageList { get; set; }
        public PlayerClass ToClass()
        {
            return this;
        }
    }
}
