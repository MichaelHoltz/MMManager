using System.Collections.Generic;
using MMManager.GameObjects;
namespace MMManager.GameInterfaces
{
    public interface IPlayers
    {
        List<PlayerClass> PlayerList { get; set; }
        MMManager.GameControls.TicTacToePlayer Player { get; set; }
        void JoinGame(IPlayer player);
        void WatchGame(IPlayer player);
        void LeaveGame(IPlayer player);
        void ClearAllPlayers();
    }
}
