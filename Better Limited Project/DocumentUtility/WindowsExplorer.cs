using System;
using System.Diagnostics;
using System.IO;

namespace Better_Limited_Project.DocumentUtility
{
    public static class WindowsExplorer
    {
        /// <summary>
        /// Opens the specified directory with windows explorer
        /// </summary>
        /// <returns>True if directory is successfully opened</returns>
        public static bool OpenDirectory(string path)
        {
            if (!Directory.Exists(path))
                return false;
            
            Process.Start(path);
            return true;
        }

        public static string GetMyDocumentsPath()
        {
            return Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        }
    }
}