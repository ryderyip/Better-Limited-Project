namespace Better_Limited_Project.Login
{
    public class LoginSession
    {
        public StaffUtility.StaffEntity.Staff Staff { get; set; }
        public SettingsUtility.UserSettings UserSettings { get; set; }

        public static LoginSession CreateSession()
        {
            return new LoginSession
            {
                UserSettings = SettingsUtility.UserSettings.GetSettings()
            };
        }
    }
}