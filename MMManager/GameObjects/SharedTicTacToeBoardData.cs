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
            SyncBoard=16,
            GameOver = 17

        };
        private PlayerClass lastTurn { get; set; }
        public List<PlayerClass> Players;
        public string GameName { get; set; } // Filter so multiple Games can co-exist.
        public GameState State { get; set; }
        public MessageCode Message { get; set; }
        public string MessageString { get; set; }
        public string MessageValue { get; set; }
        public PlayerClass MessageSender { get; set; }
        public PlayerClass WhosTurn
        {
            get
            {
                int nt = 0;
                for (int i = 0; i < Players.Count; i++)
                {
                    if (Players[i] == lastTurn)
                    {
                        if (i + 1 < Players.Count)
                        {
                            nt = i + 1;
                        }
                        else
                        {
                            nt = 0;
                        }
                        break;
                    }
                }
                lastTurn = Players[nt]; // Set up for next time it's checked.
                return Players[nt];
            }
            set
            {
                lastTurn = value;
            }

        }
        public int GameSize { get; set; }
        public int[] GameBoard;
        /// <summary>
        /// Default Constructor
        /// </summary>
        public SharedTicTacToeBoardData()
        {
            Players = new List<PlayerClass>(); // Default to no players.
            GameBoard = new int[0];
        }

    }


}
