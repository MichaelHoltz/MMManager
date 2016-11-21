using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MMManager.GameObjects;
namespace MMManager.CommInterfaces
{
    /// <summary>
    /// Contract for having a form configured to send messages and being able to send as it.
    /// </summary>
    public interface IMessageRelay
    {
        void SendTicTacToeMessage(string gameName, PlayerClass player, SharedTicTacToeBoardData generatedBoardData);
    }
}
