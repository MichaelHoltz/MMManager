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
        SharedTicTacToeBoardData GenerateNewGame(); //Host Only
        SharedTicTacToeBoardData ResetGame();   //Members and Host
        void ReceiveMessage(string gameName, string memberName, SharedTicTacToeBoardData theSharedBoardData);
        void SendMessage(string gameName, string memberName, SharedTicTacToeBoardData theSharedBoardData);
        IMessageRelay ServiceProvider { get; set; }
        
    }
}
