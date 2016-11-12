using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MMManager.GameInterfaces
{
    public interface IScore
    {
        void JoinGame(String playerName, int startingScore);
        void LeaveGame(String playerName);
        void UpdateScore(String playerName, int currentScore);
        int GetScore(String playerName);
        void ClearAllPlayers();
    }
}
