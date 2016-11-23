using System;
using MMManager.GameObjects;
using MMManager.CommInterfaces;
namespace MMManager.GameInterfaces
{
    public interface IGame
    {
        System.Windows.Forms.ImageList ButtonImageList {get; set;}
        IGameInfo GameInfo { get; set; }
        SharedTicTacToeBoardData GenerateNewGame(); //Host Only
        PlayerClass GetNextPlayer(PlayerClass currentPlayer);
        void AllButtonsAllowClick(Boolean allow);
        void AllButtonsEnable(Boolean enable);
        SharedTicTacToeBoardData ResetGame(SharedTicTacToeBoardData theSharedBoardData);   //Members and Host
        void ReceiveMessage(string gameName, PlayerClass player, SharedTicTacToeBoardData theSharedBoardData);
        void SendMessage(string gameName, PlayerClass player, SharedTicTacToeBoardData theSharedBoardData);
        IMessageRelay ServiceProvider { get; set; }
        SharedTicTacToeBoardData theBoard { get; set; }
        
    }
}
