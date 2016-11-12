using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MMManager.GameInterfaces;
namespace MMManager.GameObjects
{
    /// <summary>
    /// 
    /// </summary>
    [Serializable]
    public class SharedTicTacToeBoardData
    {
        //TODO - Share ENUMS
        public enum GameState
        {
            Waiting=0,
            Playing=1,
            GameOver=2
            
        }
        public enum MessageCode
        {
            Start=0,
            Join=1,
            Watch=2,
            Play=3,
            Move=4,
            Bomb=5,
            Win=6,
            Lose=7,
            Draw=8,
            OK=9,
            Reset=10,
            NewGame=11,
            RefreshGameList=12,
            RemoveGame,
            LeaveGame
        };
        public List<Player> Players;

        public GameState State { get; set; }
        public MessageCode Message { get; set; }
        public string MessageString { get; set; }
        public string MessageValue { get; set; }

        public string MessageSender { get; set; }

        public char[] GameBoard;
        public SharedTicTacToeBoardData()
        {
            Players = new List<Player>(); // Default to no players.
            GameBoard = new char[0];
        }

    }
    [Serializable]
    public class Player
    {
        public String PlayerName { get; set; }
        public Char PlayerSymbol { get; set; }
        public bool PlayerTurn { get; set; }
        public bool PlayerWon { get; set; }
    }

}
