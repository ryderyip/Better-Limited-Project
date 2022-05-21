#nullable enable
using System;
using System.Linq;
using Better_Limited_Project.Login;
using Better_Limited_Project.StaffUtility.StaffEntity;

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

        public static bool HasSelectedWorkplace()
        {
            var department = StaffRepository.GetStaff(LoginSession.GetSession().StaffId).Department;
            var workplace = GetSettings().Workplace;
            return workplace != null
                   && (department is Department.Sales && RetailStoreRepository.GetRetailStores()
                           .Any(store => store.Name == workplace.Name)
                       || department is Department.Inventory && WarehouseRepository.GetWarehouses()
                           .Any(warehouse => warehouse.Name == workplace.Name));
        }
    }
}