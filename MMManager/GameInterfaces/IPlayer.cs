using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MMManager.GameInterfaces
{
    /// <summary>
    /// Player Interface that has a score
    /// </summary>
    public interface IPlayer:IScore
    {
        String PlayerName { get; set; }
        Char PlayerSymbol { get; set; }
        bool PlayerTurn { get; set; }
        bool PlayerWon { get; set; }
    }
}
