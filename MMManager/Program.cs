using System;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;
using System.Windows.Forms;

namespace MMManager
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new mainForm());
            Application.Run(new frmTesting());
           // Application.Run(new MMMChatClient(PriorProcess())); // Start with an instance number.
        }
        public static int PriorProcess()
        // Returns a System.Diagnostics.Process pointing to
        // a pre-existing process with the same name as the
        // current one, if any; or null if the current process
        // is unique.
        {
            int pCount = 0;
            Process curr = Process.GetCurrentProcess();
            String processName = curr.ProcessName;
            String alternateName = "";
            if (processName.Contains(".vshost")) // Need to look for 
            {
                alternateName = curr.ProcessName.Replace(".vshost", ""); // Normal Instances
            }
            else
            {
                alternateName = curr.ProcessName + ".vshost"; // Debug Instances
            }
            Process[] procs = Process.GetProcessesByName(curr.ProcessName);
            foreach (Process p in procs)
            {
                if ((p.Id != curr.Id) && (p.MainModule.FileName.Replace(".vshost", "") == curr.MainModule.FileName.Replace(".vshost", "")))
                {
                    //Want the last Process
                    pCount++;
                   // MessageBox.Show("1");
                }
                    
            }
            //Now account for the debugger
            procs = Process.GetProcessesByName(alternateName);
            foreach (Process p in procs)
            {
                if ((p.Id != curr.Id) && (p.MainModule.FileName.Replace(".vshost","") == curr.MainModule.FileName))
                {
                    //Want the last Process
                    pCount++;
                    //MessageBox.Show("2");
                }

            }

            return pCount; //Returns the highest number of running instances.
        }
    }
}
