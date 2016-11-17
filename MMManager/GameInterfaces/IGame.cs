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

        IGameInfo GameInfo { get; set; }
        SharedTicTacToeBoardData GenerateNewGame(); //Host Only
        char GetCurrentSymbol();
        void AllButtonsAllowClick(Boolean allow);
        SharedTicTacToeBoardData ResetGame();   //Members and Host
        void ReceiveMessage(string gameName, PlayerClass player, SharedTicTacToeBoardData theSharedBoardData);
        void SendMessage(string gameName, PlayerClass player, SharedTicTacToeBoardData theSharedBoardData);
        IMessageRelay ServiceProvider { get; set; }
        
    }
}
