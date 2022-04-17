#nullable enable
using System;
using System.Windows.Forms;

namespace Better_Limited_Project.SettingsUtility
{
    [Serializable]
    public class UserSettings
    {
        public Language Language { get; set; }
        public Theme Theme { get; set; }
        public IWorkplace? Workplace { get; set; }
        public string? LastLoginUsername { get; set; }
        public string DefaultDocumentGenerationDirectoryPath { get; set; }

        public UserSettings()
        {
            DefaultDocumentGenerationDirectoryPath =
                UserSettingsDirectory.GetDefaultDocumentGenerationDirectoryPath();
        }

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
                Theme = Theme.Light
            };
        }
    }
}