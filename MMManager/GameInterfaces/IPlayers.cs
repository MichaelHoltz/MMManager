using System.Collections.Generic;
using MMManager.GameObjects;
namespace MMManager.GameInterfaces
{
    public interface IPlayers:IPlayer
    {
        List<PlayerClass> Players { get; }
        PlayerClass Player { get; set; }
        void JoinGame(IPlayer player);
        void WatchGame(IPlayer player);
        void LeaveGame(IPlayer player);
    }
}
