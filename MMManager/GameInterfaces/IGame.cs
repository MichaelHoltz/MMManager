using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MMManager.GameInterfaces;
using MMManager.GameObjects;
namespace MMManager.GameInterfaces
{
    public interface IGame
    {
      //  IPlayer MyPlayer { get; set; }
        IGameInfo GameInfo { get; set; }
        SharedTicTacToeBoardData GenerateNewGame();
        SharedTicTacToeBoardData ResetGame();
        void ReciveMessage(string gameName, string memberName, SharedTicTacToeBoardData theSharedBoardData);
        void SendMessage(string gameName, string memberName, SharedTicTacToeBoardData theSharedBoardData);
        IMessageRelay ServiceProvider { get; set; }
        
    }
}
