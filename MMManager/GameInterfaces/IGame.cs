﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MMManager.GameInterfaces;
using MMManager.GameObjects;
using System.Windows.Forms;
namespace MMManager.GameInterfaces
{
    public interface IGame
    {
        System.Windows.Forms.ImageList ButtonImageList {get; set;}
        IGameInfo GameInfo { get; set; }
        SharedTicTacToeBoardData GenerateNewGame(); //Host Only
        int GetCurrentSymbol();
        void AllButtonsAllowClick(Boolean allow);
        void AllButtonsEnable(Boolean enable);
        SharedTicTacToeBoardData ResetGame(SharedTicTacToeBoardData theSharedBoardData);   //Members and Host
        void ReceiveMessage(string gameName, PlayerClass player, SharedTicTacToeBoardData theSharedBoardData);
        void SendMessage(string gameName, PlayerClass player, SharedTicTacToeBoardData theSharedBoardData);
        IMessageRelay ServiceProvider { get; set; }
        
    }
}
