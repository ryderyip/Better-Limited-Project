using System.Windows.Forms;
using Better_Limited_Project.FormControlling;
using Better_Limited_Project.SettingsUtility;
using Better_Limited_Project.Staff.StaffEntity;

namespace Better_Limited_Project.Login
{
    public class LoginController
    {
        public delegate void LoggedInEventHandler<T>(object sender, T staff);

        public event LoggedInEventHandler<Staff> LoggedIn;

        private readonly LoginForm _loginForm;

        public LoginController()
        {
            _loginForm = new LoginForm();
            _loginForm.LoginClicked += OnLoginClicked;
        }

        public void OpenForm(FormController formController)
        {
            formController.OpenForm(_loginForm, DockStyle.Fill);
        }

        public void OpenForm(FormController formController, string lastLoginUsername)
        {
            OpenForm(formController);
            _loginForm.FillLastLoginUsername(lastLoginUsername);
        }

        private void OnLoginClicked(object sender, LoginCredentials credentials)
        {
            var status = LoginVerifier.VerifyLogin(credentials);
            if (status is not LoginStatus.Successful)
            {
                _loginForm.LoginFailed(status);
                return;
            }

            _loginForm.Close();
            var staff = GetStaffInfo(credentials.Username);
            LoggedIn?.Invoke(this, staff);
            
            // TODO not tested
            SaveLastLoginUsername(credentials.Username);
        }

        private Staff GetStaffInfo(string username)
        {
            var staffId = StaffAccountRepository.GetStaffIdByUsername(username);
            return StaffRepository.GetStaff(staffId);
        }

        private void SaveLastLoginUsername(string username)
        {
            var settings = UserSettings.GetSettings();
            settings.LastLoginUsername = username;
            settings.Save();
        }
    }
}