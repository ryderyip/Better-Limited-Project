namespace Better_Limited_Project.Login
{
    public class LoginSession
    {
        public string StaffId { get; private set; }

        public SettingsUtility.UserSettings UserSettings { get; set; }

        public static LoginSession CreateSession(string staffId)
        {
            return new LoginSession
            {
                StaffId = staffId,
                UserSettings = SettingsUtility.UserSettings.GetSettings()
            };
        }
    }
}