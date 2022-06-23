using System.Drawing;
using System.IO;

namespace Better_Limited_Project.Tools
{
    public class ImageToBytesConverter
    {
        public static byte[] Convert(Image image)
        {
            using var ms = new MemoryStream();
            image.Save(ms, image.RawFormat);
            return ms.ToArray();
        }
    }
}