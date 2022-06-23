using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace Better_Limited_Project.SettingsUtility
{
    public static class UserSettingsLoader
    {
        public static UserSettings Load()
        {
            UserSettings settings;
            string filePath = Path.Combine(UserSettingsDirectory.GetSettingsDirectory(),
                UserSettingsDirectory.SettingsFileName);

            if (!File.Exists(filePath))
            {
                settings = UserSettings.CreateDefaultSettings();
                settings.Save();
                return settings;
            }

            var stream = new FileStream(filePath, FileMode.Open, FileAccess.Read);
            var formatter = new BinaryFormatter();

            if (stream.Length == 0)
                throw new SerializationException("The file being deserialized is empty");
            settings = (UserSettings) formatter.Deserialize(stream);

            stream.Dispose();
            return settings;
        }
    }
}