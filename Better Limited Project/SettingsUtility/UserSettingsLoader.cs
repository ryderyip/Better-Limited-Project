using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace Better_Limited_Project.SettingsUtility
{
    public static class UserSettingsLoader
    {
        public static UserSettings Load()
        {
            UserSettings settings;
            string path = Path.Combine(UserSettingsDirectory.GetSettingsDirectory(),
                UserSettingsDirectory.SettingsFileName);

            if (!File.Exists(path))
            {
                settings = UserSettings.CreateDefaultSettings();
                settings.Save();
                return settings;
            }

            var stream = new FileStream(path, FileMode.Open, FileAccess.Read);
            var formatter = new BinaryFormatter();
            settings = (UserSettings) formatter.Deserialize(stream);
            stream.Dispose();
            return settings;
        }
    }
}