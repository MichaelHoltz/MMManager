using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Diagnostics;
namespace MMManager
{
    class MMManagerBase
    {


        public String BaseName { get; set; }

        public String ModFilePath { get; set; }
        

        public System.Collections.Generic.SortedList<Int16, String> ModFiles { get; set; }

        public String SaveFilePath { get; set; }
        

        public SortedList<Int16, String> SaveFiles { get; set; }

        public String LoaderFile { get; set; }
        

        public String InformationFile { get; set; }

        public void SetDefaults()
        {
            
            Properties.Settings.Default["UserAppData"] = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            Properties.Settings.Default.Save();
            Properties.Settings.Default.Upgrade();

            ModFilePath = Properties.Settings.Default["ModFilePath"].ToString();
            InformationFile = Properties.Settings.Default["InformationFile"].ToString();
            SaveFilePath = Properties.Settings.Default["SaveFilePath"].ToString();
            LoaderFile = Properties.Settings.Default["LoaderFile"].ToString();
            
           // Properties.Settings.Default.Save(); // Saves settings in application configuration file
            //Properties.Settings.Default.Reload();
            ////Create the object
            
                
            //Configuration  config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            
            ////make changes
            //config.AppSettings.Settings.Add("UserAppData", Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData));
            ////config.AppSettings.Settings["UserAppData"].Value = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            ////config.AppSettings.Settings["Password"].Value = txtPassword.Text;

            ////save to apply changes
            //config.Save(ConfigurationSaveMode.Modified);
            //ConfigurationManager.RefreshSection("appSettings");
           

        }
    }


}
