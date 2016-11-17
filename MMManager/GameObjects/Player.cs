using System;
using MMManager.GameControls;
using MMManager.GameInterfaces;
namespace MMManager.GameObjects
{
    public class PlayerClass: IPlayer
    {
        public String PlayerName { get; set; }
        public Char PlayerSymbol { get; set; }
        public int PlayerScore { get; set; }
        public String PlayerStatus { get; set; }


    }
}
