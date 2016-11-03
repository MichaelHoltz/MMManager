using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using System.Diagnostics;
using Newtonsoft.Json;
using System.IO;

namespace MMManager
{
    public partial class mainForm : Form
    {
        MMMPeer mmmPeer;
        MMManagerBase mmb;
        public mainForm()
        {
            InitializeComponent();
            
            try
            {
                string json = File.ReadAllText("mmmPeer.json");
                mmmPeer = JsonConvert.DeserializeObject<MMMPeer>(json);
            }
            catch
            {
                mmmPeer = new MMMPeer();
            }

            mmb = new MMManagerBase();
            mmb.SetDefaults(); // TEMP
        }

        private void btnShowBase_Click(object sender, EventArgs e)
        {
            //Show the Folder            
            folderBrowserDialog1.SelectedPath = Properties.Settings.Default["UserAppData"].ToString() + Properties.Settings.Default["DefaultMCRoot"].ToString();
            folderBrowserDialog1.ShowDialog();
            mmb.ModFilePath = folderBrowserDialog1.SelectedPath;
            propertyGrid1.Update(); // Update the property Grid
            propertyGrid1.Refresh();
            Process.Start(mmb.ModFilePath); // Open Explorer Window to path for browsing.
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

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void BtnArchive_Click(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            mmb.BaseName = dt.Year + "_" + dt.Month + "_" + dt.Day + "_" + dt.Hour + "_" + dt.Minute;
            propertyGrid1.SelectedObject = mmb;
            string sourcePath = Properties.Settings.Default["UserAppData"].ToString() + Properties.Settings.Default["DefaultMCRoot"].ToString(); // @"C:\Users\Administrator\Desktop\Source";
            string destinationPath = Properties.Settings.Default["MainBackupRoot"].ToString(); //@"C:\Users\Administrator\Desktop\Dest";
            string sourcePathNow = sourcePath + mmb.ModFilePath;
            string destinationPathNow = destinationPath + "\\" + mmb.BaseName + mmb.ModFilePath;
            ArchiveAll(sourcePathNow,destinationPathNow);
            sourcePathNow = sourcePath + mmb.InformationFile;
            destinationPathNow = destinationPath + "\\" + mmb.BaseName + mmb.InformationFile;
            ArchiveAll(sourcePathNow, destinationPathNow);
            sourcePathNow = sourcePath + mmb.SaveFilePath;
            destinationPathNow = destinationPath + "\\" + mmb.BaseName + mmb.SaveFilePath;
            ArchiveAll(sourcePathNow, destinationPathNow);
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
            string json = JsonConvert.SerializeObject(mmmPeer);
            
            File.WriteAllText("mmmPeer.json", json);
        }

        private void btnPeer_Click(object sender, EventArgs e)
        {
            //Must have an Instance.
            if (mmmPeer.Instances == null || mmmPeer.Instances.Count ==0)
            {
                MMMInstance mmmI = new MMMInstance();
                mmmI.ActiveInstance = true;
                mmmI.InstanceName = "Default Instance";
                mmmI.MineCraftVersion = "1.7.0";
                mmmI.ForgeVersion = "1.10.0";
                mmmPeer.ForgeInfo.Version = "2";
                mmmPeer.ForgeInfo.Location = "test2";
                mmmPeer.Instances = new SortedList<short, MMMInstance>(31);
                mmmPeer.Instances.Add(1, mmmI); // Add Default Instance

            }
            else
            {
               // mmmPeer.ForgeInfo = new MMMForgeInfo();
              //  mmmPeer.ForgeInfo.Version = "2";
              //  mmmPeer.ForgeInfo.Location = "test2";
                MessageBox.Show(mmmPeer.Instances.Values[0].InstanceName);
            }
            propertyGrid1.SelectedObject = mmmPeer; //Set to Peer Object
            
        }
    }
}
