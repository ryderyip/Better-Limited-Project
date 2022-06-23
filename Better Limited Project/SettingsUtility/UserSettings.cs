#nullable enable
using System;
using System.Linq;
using Better_Limited_Project.Login;
using Better_Limited_Project.StaffUtility.Repository;
using Better_Limited_Project.StaffUtility.StaffEntity;

namespace Better_Limited_Project.SettingsUtility
{
    [Serializable]
    public class UserSettings
    {
        public UserSettings()
        {
            DocumentGenerationDirectoryPath =
                UserSettingsDirectory.GetDefaultDocumentGenerationDirectoryPath();
        }

        public Language Language { get; set; }
        public Theme Theme { get; set; }
        public IWorkplace? Workplace { get; set; }
        public string? LastLoginUsername { get; set; }
        public string DocumentGenerationDirectoryPath { get; set; }

        public void Save()
        {
            UserSettingsSaver.Save(this);
            LanguageController.SetSystemLanguage(Language);
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

        public static bool HasSelectedWorkplace()
        {
            var department = LoginSession.GetSession().CurrentStaff.Department;
            var workplace = GetSettings().Workplace;
            return workplace != null
                   && (department is Department.Sales && new RetailStoreRepository().GetAll()
                           .Any(store => store.Name == workplace.Name)
                       || department is Department.Inventory && WarehouseRepository.GetAll()
                           .Any(warehouse => warehouse.Name == workplace.Name));
        }
    }
}