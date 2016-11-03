using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MMManager
{
    /// <summary>
    /// Class to manage Instances of MC in time
    /// Including Core Dependencies.
    /// </summary>
    class MMManagerInstance
    {
        private String instanceName;
        private String mineCraftVersion;
        private String forgeVersion;

        public String InstanceName
        {
            get { return instanceName; }
            set { instanceName = value; }
        }
        public String MineCraftVersion
        {
            get { return mineCraftVersion; }
            set { mineCraftVersion = value; }
        }

        public String ForgeVersion
        {
            get { return forgeVersion; }
            set { forgeVersion = value; }
        }

    }
}
