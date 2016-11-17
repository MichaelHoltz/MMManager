using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MMManager.GameInterfaces
{
    public interface IScore:IPlayers
    {
        void UpdateScore(IPlayer player, int currentScore);
        int GetScore(IPlayer player);
        void ClearAllPlayers();
    }
}
