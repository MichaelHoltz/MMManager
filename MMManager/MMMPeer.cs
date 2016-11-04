using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;
using System.ComponentModel;
namespace MMManager
{
    /// <summary>
    /// Class containing all other Settings
    /// As name suggests it is intended to be unique to a person, but the contained classes can be shared and syncronized
    /// </summary>
    class MMMPeer
    {
        /// <summary>
        /// userName
        /// </summary>
        public String UserName { get; set; } = "MyUserName";
        /// <summary>
        /// Hostname or IP address to identify location of Peer
        /// </summary>
        public String LocationID { get; set; } = Environment.MachineName;
        /// <summary>
        /// Sorted List of Instances for this peer. Not working in the Property View Control.
        /// </summary>
        [DescriptionAttribute("Expand to Instance Information.")]
        public SortedList<String, MMMInstance> Instances { get; set; }
        [Description("Testing Discription"), TypeConverter(typeof(ExpandableObjectConverter))]
        public MMMForgeInfo ForgeInfo { get; set; }

        
        public MMMPeer()
        {
            //Setup an Empty Instance to start.
            Instances = new SortedList<String, MMMInstance>(0);
            ForgeInfo = new MMMForgeInfo();
        }
    }
}
