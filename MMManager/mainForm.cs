﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Diagnostics;
using Newtonsoft.Json;
using System.IO;

namespace MMManager
{
    public partial class mainForm : Form
    {
        MMMApplicationSettings mas; // Application Settings
        MMMPeer mmmPeer;
        MMMlauncherProfiles mmmLauncherProfiles;
        public mainForm()
        {
            InitializeComponent();
            //Load Application Settings.
            mas = new MMMApplicationSettings();
            mas.LoadSettings();
           
            try
            {
                string json = File.ReadAllText("mmmPeer.json");
                mmmPeer = JsonConvert.DeserializeObject<MMMPeer>(json);
            }
            catch
            {
                mmmPeer = new MMMPeer();
            }

            try
            {
                string json = File.ReadAllText(mas.UserAppData + mas.DefaultMCRoot + "\\launcher_profiles.json");
                mmmLauncherProfiles = JsonConvert.DeserializeObject<MMMlauncherProfiles>(json);
                foreach (var item in mmmLauncherProfiles.Profiles)
                {
                    
                    cbMinecraftProfiles.Items.Add((item.Value as MMMProfile).name);
                    if (mmmLauncherProfiles.selectedProfile == (item.Value as MMMProfile).name)
                    {
                        cbMinecraftProfiles.Text = mmmLauncherProfiles.selectedProfile;
                        label1.Text = (item.Value as MMMProfile).lastVersionId;
                        label2.Text = (item.Value as MMMProfile).javaArgs;
                    }
                }
                

            }
            catch
            {
                mmmLauncherProfiles = new MMMlauncherProfiles();
            }
        }
        private void mainForm_Load(object sender, EventArgs e)
        {
            propertyGrid1.SelectedObject = mas; // Set Property View to Application Settings
        }

        //Example to Compare and make two directories the same.
        private void button1_Click(object sender, EventArgs e)
        {
            string sourcePath = Properties.Settings.Default["UserAppData"].ToString() + Properties.Settings.Default["DefaultMCRoot"].ToString(); // @"C:\Users\Administrator\Desktop\Source";
            string destinationPath = Properties.Settings.Default["MainBackupRoot"].ToString(); //@"C:\Users\Administrator\Desktop\Dest";
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            ArchiveAll(sourcePath, destinationPath);

        }
        private void ArchiveAll(String sourcePath, String destinationPath)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();

            System.IO.DirectoryInfo dir1 = new System.IO.DirectoryInfo(sourcePath);
            lblPath1.Text = sourcePath;
            System.IO.DirectoryInfo dir2 = new System.IO.DirectoryInfo(destinationPath);
            if(!dir2.Exists)
                dir2.Create();
            lblPath2.Text = destinationPath;
            IEnumerable<System.IO.FileInfo> list1 = dir1.GetFiles("*.*", System.IO.SearchOption.AllDirectories);
            listBox1.Items.AddRange(list1.ToArray());
            IEnumerable<System.IO.FileInfo> list2 = dir2.GetFiles("*.*", System.IO.SearchOption.AllDirectories);
            listBox2.Items.AddRange(list2.ToArray());
            bool IsInDestination = false;
            bool IsInSource = false;

            foreach (System.IO.FileInfo s in list1)
            {
                IsInDestination = false;

                foreach (System.IO.FileInfo s2 in list2)
                {
                    if (s.Name == s2.Name)
                    {
                        IsInDestination = true;
                        break;
                    }
                    else
                    {
                        IsInDestination = false;
                    }
                }

                if (!IsInDestination)
                {
                    System.IO.File.Copy(s.FullName, System.IO.Path.Combine(destinationPath, s.Name), true);
                }
            }

            list1 = dir1.GetFiles("*.*", System.IO.SearchOption.AllDirectories);

            list2 = dir2.GetFiles("*.*", System.IO.SearchOption.AllDirectories);
            listBox2.Items.Clear();
            listBox2.Items.AddRange(list2.ToArray());
            //bool areIdentical = list1.SequenceEqual(list2, new MMManagerFileCompare());

            //if (!areIdentical)
            //{
            //    foreach (System.IO.FileInfo s in list2)
            //    {
            //        IsInSource = true;

            //        foreach (System.IO.FileInfo s2 in list1)
            //        {
            //            if (s.Name == s2.Name)
            //            {
            //                IsInSource = true;
            //                break;
            //            }
            //            else
            //            {
            //                IsInSource = false;
            //            }
            //        }

            //        //if (!IsInSource)
            //        //{
            //        //    System.IO.File.Copy(s.FullName, System.IO.Path.Combine(sourcePath, s.Name), true);
            //        //}
            //    }
            //}        
        }

        private void BtnArchive_Click(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            String path = mmmPeer.Instances["Default Instance"].InstancePath;
            //mmb.BaseName = dt.Year + "_" + dt.Month + "_" + dt.Day + "_" + dt.Hour + "_" + dt.Minute;
            //propertyGrid1.SelectedObject = mmb;
            //string sourcePath = Properties.Settings.Default["UserAppData"].ToString() + Properties.Settings.Default["DefaultMCRoot"].ToString(); // @"C:\Users\Administrator\Desktop\Source";
            //string destinationPath = Properties.Settings.Default["MainBackupRoot"].ToString(); //@"C:\Users\Administrator\Desktop\Dest";
            //string sourcePathNow = sourcePath + mmb.ModFilePath;
            //string destinationPathNow = destinationPath + "\\" + mmb.BaseName + mmb.ModFilePath;
            //ArchiveAll(sourcePathNow,destinationPathNow);
            //sourcePathNow = sourcePath + mmb.InformationFile;
            //destinationPathNow = destinationPath + "\\" + mmb.BaseName + mmb.InformationFile;
            //ArchiveAll(sourcePathNow, destinationPathNow);
            //sourcePathNow = sourcePath + mmb.SaveFilePath;
            //destinationPathNow = destinationPath + "\\" + mmb.BaseName + mmb.SaveFilePath;
            //ArchiveAll(sourcePathNow, destinationPathNow);
        }

        private void btnModsSelector_Click(object sender, EventArgs e)
        {
            //TODO - pass in Instance Information for configuration to know where to show list from.
            frmModsSelect fms = new frmModsSelect();
            fms.ShowDialog();
        }

        private void btnFormTesting_Click(object sender, EventArgs e)
        {
            frmTesting ft = new frmTesting();
            ft.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            mas.SaveSettings();
            string json = JsonConvert.SerializeObject(mmmPeer,Formatting.Indented);
            File.WriteAllText("mmmPeer.json", json);
        }

        private void btnPeer_Click(object sender, EventArgs e)
        {
            //Must have an Instance.
            if (mmmPeer.Instances == null || mmmPeer.Instances.Count ==0)
            {
                MMMInstance mmmI = new MMMInstance();
                mmmI.ActiveInstance = true;
                mmmI.InstanceName = "Current Minecraft Settings";
                mmmI.MineCraftVersion = "1.7.0";
                mmmI.ForgeVersion = "1.10.0";
                mmmPeer.ForgeInfo.Version = "2";
                mmmPeer.ForgeInfo.Location = "test2";
                mmmPeer.Instances = new SortedList<String, MMMInstance>(31);
                mmmPeer.Instances.Add(mmmI.InstanceName, mmmI); // Add Default Instance

            }
            else
            {
                MessageBox.Show(mmmPeer.Instances.Values[0].InstanceName);
            }

            //Set the Peer Properties or auto Assign them.
            tbPeerName.Text = mmmPeer.UserName;
            tbPeerLocation.Text = Environment.MachineName;
            //Set the Instance properties.
            foreach (var item in mmmPeer.Instances)
            {
                cbForgeVersion.Items.Add((item.Value as MMMInstance).ForgeVersion);
                cbMCVersion.Items.Add((item.Value as MMMInstance).MineCraftVersion);
                cbInstanceName.Items.Add((item.Value as MMMInstance).InstanceName);
                if ((item.Value as MMMInstance).ActiveInstance)
                {
                    cbForgeVersion.SelectedText = (item.Value as MMMInstance).ForgeVersion;
                    cbMCVersion.SelectedText = (item.Value as MMMInstance).MineCraftVersion;
                    cbInstanceName.SelectedText = (item.Value as MMMInstance).InstanceName;
                }
            }


            propertyGrid1.SelectedObject = mmmPeer; //Set to Peer Object
            
        }

        private void tbPeerName_TextChanged(object sender, EventArgs e)
        {
            mmmPeer.UserName = tbPeerName.Text;
        }

        private void tbPeerLocation_TextChanged(object sender, EventArgs e)
        {
            mmmPeer.LocationID = tbPeerLocation.Text;
        }

        private void btnBrowseInstance_Click(object sender, EventArgs e)
        {
            //Find the Selected Instance
            //Going to have an error here the first time!!!
            MMMInstance mmmi = mmmPeer.Instances[cbInstanceName.Text];
            
            if (mmmi.InstancePath == null)
                mmmi.InstancePath = Properties.Settings.Default["UserAppData"].ToString() + Properties.Settings.Default["DefaultMCRoot"].ToString();
            String path = mmmi.InstancePath;
            //Show the Folder            
            //folderBrowserDialog1.SelectedPath = Properties.Settings.Default["UserAppData"].ToString() + Properties.Settings.Default["DefaultMCRoot"].ToString();
            //folderBrowserDialog1.ShowDialog();
            //mmb.ModFilePath = folderBrowserDialog1.SelectedPath;
            //propertyGrid1.Update(); // Update the property Grid
            //propertyGrid1.Refresh();
            Process.Start(path); // Open Explorer Window to path for browsing.
        }

        private void cbMinecraftProfiles_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (var item in mmmLauncherProfiles.Profiles)
            {

                
                if (cbMinecraftProfiles.Text == (item.Value as MMMProfile).name)
                {
                   // cbMinecraftProfiles.Text = mmmLauncherProfiles.selectedProfile;
                    label1.Text = (item.Value as MMMProfile).lastVersionId;
                    label2.Text = (item.Value as MMMProfile).javaArgs;
                }
            }
        }


        private void btnApplicationSettings_Click(object sender, EventArgs e)
        {
            if (mas != null)
            {
                propertyGrid1.SelectedObject = mas;
            }
        }
    }
}
