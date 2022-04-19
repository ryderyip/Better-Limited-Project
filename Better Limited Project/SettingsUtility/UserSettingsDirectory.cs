using System.IO;
using Better_Limited_Project.DocumentUtility;

namespace Better_Limited_Project.SettingsUtility
{
    public static class UserSettingsDirectory
    {
        private const string BaseFolderName = "Better Limited";
        public const string SettingsFileName = "User Settings.ini";
        public const string GeneratedDocumentName = "Document";

        public static string GetSettingsDirectory()
        {
            return Path.Combine(WindowsExplorer.GetMyDocumentsPath(), BaseFolderName);
        }

        /// <summary>
        /// Gets the document generation file path 
        /// </summary>
        public static string GetDefaultDocumentGenerationDirectoryPath()
        {
            return Path.Combine(WindowsExplorer.GetMyDocumentsPath(), BaseFolderName);
        }
    }
}