using System;
using MMManager.GameInterfaces;
namespace MMManager.GameObjects
{
    [Serializable]
    public class PlayerClass: IPlayer
    {
        public String PlayerName { get; set; }
        public Char PlayerSymbol { get; set; }
        public bool PlayerTurn { get; set; }
        public bool PlayerWon { get; set; }

    }
}
