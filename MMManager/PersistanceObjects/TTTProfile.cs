using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.IO;
using System.ComponentModel;

namespace MMManager.PersistanceObjects
{
    /// <summary>
    /// Class for Saving basic information for quick starting a TTT instance.
    /// </summary>
    class TTTProfile
    {

        public String UserName { get; set; } = "MyUserName"; // Default to something Unknown
        public int Symbol { get; set; } = 0; //Default to no symbol
        public TTTProfile LoadSettings(int InstanceNumber)
        {
            TTTProfile tttProfile; // Instance of this class
            try
            {
                String json = File.ReadAllText("tttprofile" + InstanceNumber + ".json");
                tttProfile = JsonConvert.DeserializeObject<TTTProfile>(json);
            }
            catch
            {
                tttProfile = new TTTProfile(); // Default to a new empty object
            }

            return tttProfile;
        }
        /// <summary>
        /// Save the current Properties of this Class
        /// </summary>
        public void SaveSettings(int InstanceNumber)
        {
            //Save Json
            String json = JsonConvert.SerializeObject(this, Formatting.Indented);
            File.WriteAllText("tttprofile" + InstanceNumber + ".json", json);

        }
    }
}
