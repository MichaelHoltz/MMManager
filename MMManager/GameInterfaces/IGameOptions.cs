using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MMManager.GameInterfaces
{
    public interface IGameOptions
    {
        int GridSize { get; } // Read Only Property
        bool GenerateBombs { get; }
        bool GenerateExtraTurns { get; }

        bool GenerateRowColClear { get; }
        bool GenerateShuffle { get; }
    }
}
