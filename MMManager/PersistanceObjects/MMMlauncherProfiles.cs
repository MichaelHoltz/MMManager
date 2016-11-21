using System;
using System.Collections.Generic;

namespace MMManager.PersistanceObjects
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
