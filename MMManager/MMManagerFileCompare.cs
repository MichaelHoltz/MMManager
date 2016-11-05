using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading;
namespace MMManager
{
    /// <summary>
    /// Data Used for Copying Directories and files.
    /// </summary>
    public struct DirectoryCopyData
    {
        public string SourceDirName;
        public string DestDirName;
        public bool CopySubDirs;

    }
    public class DirectoryCopyEventArgs : EventArgs
    {
        public DirectoryCopyEventArgs(string fileInfo)
        {
            this.fileInfo = fileInfo;
        }
        public string fileInfo { get; set; }
    }
    class MMManagerFileCompare : System.Collections.Generic.IEqualityComparer<System.IO.FileInfo>
    {
        public static int maxThreadCount=0;
        public static event EventHandler<DirectoryCopyEventArgs> NewDirectoryCopyFileInfo;

         public bool Equals(System.IO.FileInfo f1, System.IO.FileInfo f2)
        {
            return (f1.Name == f2.Name);
        }
        public int GetHashCode(System.IO.FileInfo fi)
        {
            string s = fi.Name;
            return s.GetHashCode();
        }
        /// <summary>
        /// Copy the contents of a directory with multiple Recursive Threads..
        /// </summary>
        /// <param name="sourceDirName"></param>
        /// <param name="destDirName"></param>
        /// <param name="copySubDirs"></param>
        public static void DirectoryCopy(string sourceDirName, string destDirName, bool copySubDirs)
        {
            maxThreadCount++;
            var d = new DirectoryCopyData { SourceDirName = sourceDirName, DestDirName = destDirName, CopySubDirs = copySubDirs };
            if (NewDirectoryCopyFileInfo != null)
            {
                NewDirectoryCopyFileInfo(null, new DirectoryCopyEventArgs(sourceDirName));
            }
            Thread dc = new Thread(DirectoryCopyThread);
            dc.Start(d);
        }
        public static void DirectoryCopyThread(object o)
        {
            DirectoryCopyData d = (DirectoryCopyData)o;
            string sourceDirName = d.SourceDirName;
            string destDirName = d.DestDirName;
            bool copySubDirs = d.CopySubDirs;
            // Get the subdirectories for the specified directory.
            DirectoryInfo dir = new DirectoryInfo(sourceDirName);

            if (!dir.Exists)
            {
                throw new DirectoryNotFoundException(
                    "Source directory does not exist or could not be found: "
                    + sourceDirName);
            }

            DirectoryInfo[] dirs = dir.GetDirectories();
            // If the destination directory doesn't exist, create it.
            if (!Directory.Exists(destDirName))
            {
                Directory.CreateDirectory(destDirName);
            }

            // Get the files in the directory and copy them to the new location.
            FileInfo[] files = dir.GetFiles();
            foreach (FileInfo file in files)
            {
                string temppath = Path.Combine(destDirName, file.Name);
                file.CopyTo(temppath, false);
            }

            // If copying subdirectories, copy them and their contents to new location.
            if (copySubDirs)
            {
                foreach (DirectoryInfo subdir in dirs)
                {
                    string temppath = Path.Combine(destDirName, subdir.Name);
                    DirectoryCopy(subdir.FullName, temppath, copySubDirs); //Starts a new Thread for Sub Directories.
                }
            }
        }

    }
}
