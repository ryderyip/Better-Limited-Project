using System.IO;

namespace Better_Limited_Project.Tools
{
    public static class FileSizeChecker
    {
        public static bool IsFileLargerThan(long size, string filePath)
        {
            return new FileInfo(filePath).Length > size;
        }
    }
}