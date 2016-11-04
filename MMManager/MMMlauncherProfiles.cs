using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MMManager
{
    /// <summary>
    /// Class for Dealing with the Mincraft Profile Launcher
    /// </summary>
    class MMMlauncherProfiles
    {
        public SortedList<String, MMMProfile> Profiles { get; set; }
        public String selectedProfile { get; set; }

        public String clientToken { get; set; }
    }
}
