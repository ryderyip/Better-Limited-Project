using System;
using System.Windows.Forms;

namespace Better_Limited_Project.DocumentUtility
{
    public static class FolderBrowser
    {
        /// <summary>
        ///     Show a folder browser dialog
        /// </summary>
        /// <param name="rootFolder">The root folder where the browsing starts from</param>
        /// <param name="browserDescription">The description to be displayed</param>
        /// <returns>The selected directory. Returns an empty string if no directory is selected</returns>
        public static string BrowseDirectory(Environment.SpecialFolder rootFolder, string browserDescription)
        {
            var browserDialog = new FolderBrowserDialog();
            browserDialog.RootFolder = rootFolder;
            browserDialog.Description = browserDescription;
            var result = browserDialog.ShowDialog();
            if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(browserDialog.SelectedPath))
                return browserDialog.SelectedPath;
            return string.Empty;
        }
    }

    public static class ImageFileBrowser
    {
        /// <returns>Image Path</returns>
        public static string? Browse(string browserTitle)
        {
            var dialog = new OpenFileDialog();
            dialog.Title = browserTitle;
            dialog.Multiselect = false;
            dialog.CheckFileExists = true;
            dialog.Filter = @"Images|*.jpg;*.jpeg;*.png";
            return dialog.ShowDialog() == DialogResult.OK
                ? dialog.FileName
                : null;
        }
    }
}