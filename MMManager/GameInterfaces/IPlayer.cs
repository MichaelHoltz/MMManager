using System;


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
        bool PlayerTurn { get; set; }
        bool PlayerWon { get; set; }
       // IScore ScoreBoard { get; set; }
    }
}
