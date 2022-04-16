using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Better_Limited_Project.SettingsUtility
{
    public static class UserSettingsSaver
    {
        public static void Save(UserSettings settings)
        {
            string directoryPath = UserSettingsDirectory.GetSettingsDirectory();
            if (!Directory.Exists(directoryPath))
                Directory.CreateDirectory(directoryPath);
            
            string settingsPath = Path.Combine(directoryPath, UserSettingsDirectory.SettingsFileName);

            if (File.Exists(settingsPath))
                File.Delete(settingsPath);
            var formatter = new BinaryFormatter();
            var stream = new FileStream(settingsPath, FileMode.Create, FileAccess.Write);
            formatter.Serialize(stream, settings);
            stream.Dispose();
        }
    }
}