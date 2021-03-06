﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Diagnostics;
using Newtonsoft.Json;
using System.IO;
using MMManager.PersistanceObjects;
namespace MMManager
{
    public partial class mainForm : Form
    {
        private Object thisLock = new Object();

        MMMApplicationSettings mas; // Application Settings
        MMMPeer mmmPeer;
        MMMlauncherProfiles mmmLauncherProfiles;

        System.Windows.Media.MediaPlayer mp;
        public mainForm()
        {
            InitializeComponent();
            //Load Application Settings.
            mas = new MMMApplicationSettings();
            mas = mas.LoadSettings(); // Loads the settings from file cleanly
            mmmPeer = new MMMPeer();
            mmmPeer = mmmPeer.LoadSettings();
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
            string version = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString();
            this.Text += String.Format("  Ver. {0}", version);

            //propertyGrid1.SelectedObject = mas; // Set Property View to Application Settings
            if (mmmPeer.Instances == null || mmmPeer.Instances.Count == 0)
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
                //MessageBox.Show(mmmPeer.Instances.Values[0].InstanceName);
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

        private void mainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Automatically Save Settings
            mas.SaveSettings();
            mmmPeer.SaveSettings();
        }


        private void BtnArchive_Click(object sender, EventArgs e)
        {
            MMManagerFileCompare.NewDirectoryCopyFileInfo += MMManagerFileCompare_NewDirectoryCopyFileInfo;
            DateTime dt = DateTime.Now;
            string sourcePath = mas.UserAppData + mas.DefaultMCRoot;
            string destinationPath = mas.MainBackupRoot;
            String backup = dt.Year + "_" + dt.Month + "_" + dt.Day + "_" + dt.Hour + "_" + dt.Minute;
            MMManagerFileCompare.DirectoryCopy(sourcePath, destinationPath + "\\" + backup, false);

            string sourcePathNow = sourcePath + mas.ModFilePath;
            string destinationPathNow = destinationPath + "\\" + backup + mas.ModFilePath;
            MMManagerFileCompare.DirectoryCopy(sourcePathNow, destinationPathNow, true);
            //sourcePathNow = sourcePath + mmb.InformationFile;
            //destinationPathNow = destinationPath + "\\" + mmb.BaseName + mmb.InformationFile;
            //MMManagerFileCompare.DirectoryCopy(sourcePath, destinationPath, true);
            sourcePathNow = sourcePath + mas.SaveFilePath;
            destinationPathNow = destinationPath + "\\" + backup + mas.SaveFilePath;
            MMManagerFileCompare.DirectoryCopy(sourcePathNow, destinationPathNow, true);
            //MessageBox.Show("Backup to: " + backup + " Complete.");
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

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Text = MMManagerFileCompare.maxThreadCount.ToString();

        }
        delegate void SetTextCallback(string text);
        private void SetText(string text)
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (this.label3.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetText);
                this.Invoke(d, new object[] { text });

            }
            else
            {
                this.label3.Text = text;
            }
        }

        private void MMManagerFileCompare_NewDirectoryCopyFileInfo(object sender, DirectoryCopyEventArgs e)
        {
            SetText(e.fileInfo);
        }

        private void btnChatForm_Click(object sender, EventArgs e)
        {
            MMMChatClient mcc = new MMMChatClient(mmmPeer.UserName);
            mcc.StartPosition = FormStartPosition.CenterParent;
            mcc.Show();
            //MMMChatTicTacToeForm mcf = new MMMChatTicTacToeForm();
            //mcf.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // MMMp2pManager c = new MMMp2pManager();

        }

        private void btnSoloTicTacToe_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
        }



        private void button2_Click(object sender, EventArgs e)
        {
            mp = new System.Windows.Media.MediaPlayer();
            mp.MediaEnded += P1_MediaEnded;
            mp.Open(new System.Uri(@"C:\Projects\MMManager\MMManager\Sounds\GameStartMario.wav"));
            mp.Play();
            //var p1 = new System.Windows.Media.MediaPlayer();
            //p1.MediaEnded += P1_MediaEnded;

            //for (int i = 0; i < 5; i++)
            //{
            //    p1 = new System.Windows.Media.MediaPlayer();
            //    p1.MediaEnded += P1_MediaEnded;
            //    p1.Open(new System.Uri(@"C:\Projects\MMManager\MMManager\Sounds\PacMan_Movement #003032.mp3"));
            //    p1.Play();

            //    // this sleep is here just so you can distinguish the two sounds playing simultaneously
            //    System.Threading.Thread.Sleep(500);

            //    var p2 = new System.Windows.Media.MediaPlayer();
            //    p2.Open(new System.Uri(@"C:\windows\media\tada.wav"));
            //    p2.Play();
            //}
        }

        private void P1_MediaEnded(object sender, EventArgs e)
        {
            (sender as System.Windows.Media.MediaPlayer).Position = TimeSpan.Zero;
            (sender as System.Windows.Media.MediaPlayer).Play();
        }

        private void P2_MediaEnded(object sender, EventArgs e)
        {
            (sender as System.Windows.Media.MediaPlayer).Position = TimeSpan.Zero;
            (sender as System.Windows.Media.MediaPlayer).Play();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            mp = new System.Windows.Media.MediaPlayer();
            mp.MediaEnded += P2_MediaEnded;
            //mp.Open(new System.Uri(@"C:\Projects\MMManager\MMManager\Sounds\GameWaitingMusic.wav"));
            mp.Open(new System.Uri(@"C:\Projects\MMManager\MMManager\Sounds\KoRn vs. Dem Franchize Boyz - Coming Undone Wit It.wav"));
            
            mp.Play();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(mp!=null)
                mp.Stop();
            button4.ImageIndex = 0;
            timer1.Interval = 50;
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (button4.ImageIndex < 9)
            {
                button4.ImageIndex++;
                timer1.Interval -= 5;
            }
            else
                timer1.Enabled = false;
        }

    }
}
