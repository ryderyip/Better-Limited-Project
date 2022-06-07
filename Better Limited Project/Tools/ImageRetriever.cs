using System;
using System.Drawing;
using System.Windows.Forms;

namespace Better_Limited_Project.Tools
{
    public static class ImageRetriever
    {
        public static Image? Retrieve(string path)
        {
            try
            {
                return Image.FromFile(path);
            }
            catch (OutOfMemoryException)
            {
                MessageBox.Show(ToolsStringResources.image_is_incorrect_format);
                return null;
            }
        }
    }
}