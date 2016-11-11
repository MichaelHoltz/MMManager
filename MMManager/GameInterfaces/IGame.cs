using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MMManager.GameInterfaces;
namespace MMManager.GameInterfaces
{
    public interface IGame
    {
        IGameInfo GameInfo { get; set; }
        void GenerateNewGame();
    }
}
