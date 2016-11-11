using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MMManager.GameInterfaces;
namespace MMManager.GameInterfaces
{
    public interface IGameInfo: IPlayer
    {
        IGame Game { get; set; } 
        IGameOptions GameOptions { get; set; }
        IScore GameScore { get; set; }
        void GameOver(string results);
        void RemoveGame(string gameName);
        void AddGame(string gameName);
        string GameName { get; set; }
        void StartGame(string gameName);
        
        void RefreshGameList();
        void WatchGame();

        ControlStatus GameMode { get; set;}
        GameFlowStatus GameStatus { get; set; }
    }
    public enum ControlStatus
    {
        Hosting=0,
        Joined=1,
        Watching=2
    }
    public enum GameFlowStatus
    {
        Waiting=0,
        Playing=1,
        GameOver=2

    }
}
