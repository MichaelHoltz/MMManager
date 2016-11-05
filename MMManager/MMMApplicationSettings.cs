using System;
using Newtonsoft.Json;
using System.IO;
using System.Windows.Forms;

namespace MMManager
{
    class MMMApplicationSettings
    {
        public String MainBackupRoot { get; set; } = "c:\\MMManager";
        public String DefaultMCRoot { get; set; } = "\\.minecraft";
        public String UserAppData { get; set; } = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
        public String SaveFilePath { get; set; } = "\\saves";
        public String InformaitonFile { get; set; } = "\\info";
        public String ModFilePath { get; set; } = "\\mods";
        public String LoaderFile { get; set; } = "Forge Loader";

        public MMMApplicationSettings LoadSettings()
        {
            MMMApplicationSettings mas; // Instance of this class
            try
            {
                String json = File.ReadAllText("mmmApplicationSettings.json");
                mas = JsonConvert.DeserializeObject<MMMApplicationSettings>(json);
            }
            catch
            {
                mas = new MMMApplicationSettings();
            }

            return mas;
        }
        /// <summary>
        /// Save the current Properties of this Class
        /// </summary>
        public void SaveSettings()
        {
            //Save Json
            String json = JsonConvert.SerializeObject(this, Formatting.Indented);
            File.WriteAllText("mmmApplicationSettings.json", json);

        }
    }
}
