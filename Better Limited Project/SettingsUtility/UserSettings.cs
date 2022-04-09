using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Better_Limited_Project.SettingsUtility
{
    [Serializable]
    public class UserSettings
    {
        public Language Language { get; set; }
        public Theme Theme { get; set; }
        public Workplace Workplace { get; set; }
        public string LastLoginUsername { get; set; }
        public string DefaultDocumentGenerationPath { get; set; }
        private const string SettingsFileName = "User Settings.ini";

        public void Save()
        {
            string path = SettingsFileName;
            var formatter = new BinaryFormatter();
            var stream = new FileStream(path, FileMode.Create, FileAccess.Write);
            formatter.Serialize(stream, this);
            stream.Dispose();
        }

        public static UserSettings GetSettings()
        {
            UserSettings userSettings;
            string path = SettingsFileName;
            
            if (!File.Exists(path))
            {
                userSettings = CreateDefaultSettings();
                userSettings.Save();
                return userSettings;
            }
            
            var stream = new FileStream(path, FileMode.Open, FileAccess.Read);
            var formatter = new BinaryFormatter();
            userSettings = (UserSettings) formatter.Deserialize(stream);
            stream.Dispose();
            return userSettings;
        }

        private static UserSettings CreateDefaultSettings()
        {
            return new UserSettings
            {
                Language = Language.English, 
                Workplace = Workplace.RetailStore,
                Theme = Theme.Light
            };
        }
    }
}