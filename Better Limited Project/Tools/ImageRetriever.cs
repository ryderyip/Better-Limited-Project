using System;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Better_Limited_Project.Tools
{
    public class ImageRetriever
    {
        public static Image? Retrieve(string path)
        {
            try
            {
                return Image.FromFile(path);
            }
            catch (OutOfMemoryException)
            {
                MessageBox.Show("Image file is in incorrect format. Please choose another one.");
                return null;
            }
        }
    }
}