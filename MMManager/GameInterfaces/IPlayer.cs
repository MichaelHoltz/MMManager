using System;
using System.Windows.Forms;
using MMManager.GameObjects;

namespace MMManager.GameInterfaces
{
    /// <summary>
    /// Player Interface that has a score
    /// Copy of class Player.. need to fix
    /// </summary>
    public interface IPlayer
        {
        PlayerClass ToClass();
        String PlayerName { get; set; }
        int PlayerSymbol { get; set; }
        int PlayerScore { get; set; }
        String PlayerStatus { get; set; }
        ImageList ButtonImageList { get; set; }
    }
}
