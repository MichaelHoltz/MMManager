using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MMManager.GameInterfaces;
using MMManager.GameObjects;
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
            RemoveGame=13,
            LeaveGame=14,
            StopWatching=15,
            SyncBoard=16

        };
        public List<PlayerClass> Players;
        
        public GameState State { get; set; }
        public MessageCode Message { get; set; }
        public string MessageString { get; set; }
        public string MessageValue { get; set; }
        public PlayerClass MessageSender { get; set; }
        public char NextSymbol { get; set; }
        public int GameSize { get; set; }
        public char[] GameBoard;
        /// <summary>
        /// Default Constructor
        /// </summary>
        public SharedTicTacToeBoardData()
        {
            Players = new List<PlayerClass>(); // Default to no players.
            GameBoard = new char[0];
        }

    }


}
