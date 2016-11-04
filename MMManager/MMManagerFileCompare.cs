using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading;
namespace MMManager
{
    class MMManagerFileCompare : System.Collections.Generic.IEqualityComparer<System.IO.FileInfo>
    {
        private static string _sourceDirName;
        private static string _destDirName;
        private static bool _copySubDirs;
        public bool Equals(System.IO.FileInfo f1, System.IO.FileInfo f2)
        {
            return (f1.Name == f2.Name);
        }
        public int GetHashCode(System.IO.FileInfo fi)
        {
            string s = fi.Name;
            return s.GetHashCode();
        }
        public static void DirectoryCopy(string sourceDirName, string destDirName, bool copySubDirs)
        {
            _sourceDirName = sourceDirName;
            _destDirName = destDirName;
            _copySubDirs = copySubDirs;
            ThreadStart ts = new ThreadStart(DirectoryCopyThread);
            Thread dc = new Thread(ts);
            dc.Start();
        }
        public static void DirectoryCopyThread()
        {
            string sourceDirName = _sourceDirName;
            string destDirName = _destDirName;
            bool copySubDirs = _copySubDirs;
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
                    DirectoryCopy(subdir.FullName, temppath, copySubDirs);
                }
            }
        }

        private void ArchiveAll(String sourcePath, String destinationPath)
        {
            // listBox1.Items.Clear();
            // listBox2.Items.Clear();
            MMManagerFileCompare.DirectoryCopy(sourcePath, destinationPath, true);
            System.IO.DirectoryInfo dir1 = new System.IO.DirectoryInfo(sourcePath);
         //   lblPath1.Text = sourcePath;
            System.IO.DirectoryInfo dir2 = new System.IO.DirectoryInfo(destinationPath);
            if (!dir2.Exists)
                dir2.Create();
           // lblPath2.Text = destinationPath;
            IEnumerable<System.IO.FileInfo> list1 = dir1.GetFiles("*.*", System.IO.SearchOption.AllDirectories);
            //listBox1.Items.AddRange(list1.ToArray());
            IEnumerable<System.IO.FileInfo> list2 = dir2.GetFiles("*.*", System.IO.SearchOption.AllDirectories);
            //listBox2.Items.AddRange(list2.ToArray());
            bool IsInDestination = false;
            //bool IsInSource = false;
            //System.IO.Directory.
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
            //listBox2.Items.Clear();
            //listBox2.Items.AddRange(list2.ToArray());
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
    }
}
