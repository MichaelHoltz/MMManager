using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MMManager
{
    [Serializable]
    class MMMForgeInfo
    {
        public String Version { get; set; }
        public String Location { get; set; }
        public MMMForgeInfo()
        {
            Version = "1";
            Location = "test";
        }
    }
}
