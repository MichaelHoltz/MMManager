﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MMManager.GameInterfaces;
using MMManager.GameObjects;
namespace MMManager.GameInterfaces
{
    public interface IGameInfo:IScore
    {
        IGame Game { get; set; } 
        IGameOptions GameOptions { get; set; }
        //List<PlayerClass> Players { get;  }
        IPlayers Players { get; }
        PlayerClass Player { get; set; }
        IScore GameScore { get; set; }
        void GameOver(string results);
        void AddGame(string gameName);
        void RemoveGame(string gameName);
        string GameName { get; set; }
        void StartGame(string gameName);
        void PlayersChanged();

        void RefreshGameList();

        ControlStatus GameMode { get; set;}
        SharedTicTacToeBoardData.GameState GameState { get; set; }
        SharedTicTacToeBoardData BoardData { get; set; }
    }

    public enum ControlStatus
    {
        Unknown=0,
        Hosting=1,
        Joined=2,
        Watching=3
    }
}