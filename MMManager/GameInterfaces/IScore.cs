using System.Collections.Generic;
using MMManager.GameObjects;
namespace MMManager.GameInterfaces
{
    public interface IScore
    {
        void UpdateScore(IPlayer player, int currentScore);
        int GetScore(IPlayer player);

        void RefreshData(List<PlayerClass> Players);
    }
}
