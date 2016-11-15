using System.Collections.Generic;
using MMManager.GameObjects;
namespace MMManager.GameInterfaces
{
    public interface IPlayers
    {
        List<PlayerClass> Players { get; set; }
        PlayerClass Player { get; set; }
    }
}
