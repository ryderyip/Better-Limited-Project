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
        public string DefaultDocumentGenerationDirectoryPath { get; set; }

        public void Save()
        {
            UserSettingsSaver.Save(this);
        }

        public static UserSettings GetSettings()
        {
            return UserSettingsLoader.Load();
        }

        public static UserSettings CreateDefaultSettings()
        {
            return new UserSettings
            {
                Language = Language.English, 
                Workplace = Workplace.RetailStore,
                Theme = Theme.Light,
                DefaultDocumentGenerationDirectoryPath = 
                    UserSettingsDirectory.GetDefaultDocumentGenerationDirectoryPath()
            };
        }
    }
}