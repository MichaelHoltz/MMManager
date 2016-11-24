using System.Collections.Generic;
using System.Windows.Forms;
using MMManager.GameObjects;
namespace MMManager.GameInterfaces
{
    public interface IScore
    {
        void UpdateScore(IPlayer player, int currentScore, SharedTicTacToeBoardData boardData);
        int GetScore(IPlayer player);

        void RefreshData(List<PlayerClass> Players);
        ImageList ButtonImageList { get; set; }
    }
}
