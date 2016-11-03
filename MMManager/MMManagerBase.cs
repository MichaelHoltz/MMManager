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

        String baseName;    //Name of Basic Instance

        public String BaseName
        {
            get { return baseName; }
            set { baseName = value; }
        }
        String modFilePath; //Path to Folder of Mod Files

        public String ModFilePath
        {
            get { return modFilePath; }
            set { modFilePath = value; }
        }
        System.Collections.Generic.SortedList<Int16, String> modFiles;  //List of Mod Files  (To be enumerated by Folder)

        public System.Collections.Generic.SortedList<Int16, String> ModFiles
        {
            get { return modFiles; }
            set { modFiles = value; }
        }
        String saveFilePath; //Path to Folder of Save Files

        public String SaveFilePath
        {
            get { return saveFilePath; }
            set { saveFilePath = value; }
        }
        SortedList<Int16, String> saveFiles;    //List of Save Files    (To be enumerated by Folder

        public SortedList<Int16, String> SaveFiles
        {
            get { return saveFiles; }
            set { saveFiles = value; }
        }
        String loaderFile;

        public String LoaderFile
        {
            get { return loaderFile; }
            set { loaderFile = value; }
        }
        String informationFile;

        public String InformationFile
        {
            get { return informationFile; }
            set { informationFile = value; }
        }

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
