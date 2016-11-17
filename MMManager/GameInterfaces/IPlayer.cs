using System;
using MMManager.GameObjects;

namespace MMManager.GameInterfaces
{
    /// <summary>
    /// Player Interface that has a score
    /// Copy of class Player.. need to fix
    /// </summary>
    public interface IPlayer
    {
        String PlayerName { get; set; }
        Char PlayerSymbol { get; set; }
        int PlayerScore { get; set; }
        String PlayerStatus { get; set; }
        
    }
}
