using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MMManager
{
    public class TicTacToeBoard
    {

        public enum GameState
        {
            Waiting=0,
            Playing=1,
            GameOver=2
            
        }
        public enum MessageCode
        {
            Start=0,
            Accept=1,
            Play=2,
            Move=3,
            Bomb=4,
            Win=5,
            Lose=6,
            Draw=7,
            OK=8,
            Reset=9

        };

        public GameState State { get; set; }
        public object MessageObject { get; set; }
        public MessageCode Message { get; set; }
        public string MessageString { get; set; }
        public string MessageValue { get; set; }
        public string[] board;
        public int bomb { get; set; }
        public string FirstSymbol { get; set; }
        public string FirstName { get; set; }
        
        public string SecondSymbol { get; set; }
        public string SecondName { get; set; }
        public TicTacToeBoard()
        {
            board = new string[9];
            board[0] = ""; //1
            board[1] = "";
            board[2] = "";
            board[3] = "";
            board[4] = "";
            board[5] = "";
            board[6] = "";
            board[7] = "";
            board[8] = ""; //9

            Random r = new Random(DateTime.Now.Second);
            bomb = r.Next(0, 8); // Assign the Bomb
            board[bomb] = "bomb";
            int whoGoesFirst = r.Next(1, 2);
            if (whoGoesFirst == 1)
            {
                FirstSymbol = "X";
                SecondSymbol = "O";
            }
            else
            {
                FirstSymbol = "O";
                SecondSymbol = "X";
            }

        }
        public String Move(int location,String Name)
        {
            if (board[location] == "bomb")
            {
                //DO Something to indicate the bomb
                board[location] = ""; // Clear and lose turn
                return "B!";
            }
            board[location] = getSymbol(Name);
            return board[location];
        }
        public bool CheckReset()
        {
            bool retVal = true;
            for (int i = 0; i < 9; i++)
            {
                if (board[i] == "bomb" || board[i] == "")
                {
                    retVal = false;
                    break;
                }
            }
            return retVal;
        }

        public String getSymbol(String Name)
        {
            if (Name == FirstName)
            {
                return FirstSymbol;
            }
            if (Name == SecondName)
            {
                return SecondSymbol;
            }
            return "?";
        }


    }
}
