using System.Drawing;

namespace Better_Limited_Project.Tools
{
    public class ImageToBytesConverter
    {
        public static byte[] Convert(Image image)
        {
            using var ms = new System.IO.MemoryStream();
            image.Save(ms, image.RawFormat);
            return ms.ToArray();
        }
    }
}