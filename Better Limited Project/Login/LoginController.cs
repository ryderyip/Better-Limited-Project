using Better_Limited_Project.FormControlling;
using Better_Limited_Project.SettingsUtility;

namespace Better_Limited_Project.Login
{
    public class LoginController
    {
        public delegate void LoggedInEventHandler<T>(object sender, T staffId);

        public event LoggedInEventHandler<string> LoggedIn;

        private readonly LoginForm _loginForm;

        public LoginController()
        {
            _loginForm = new LoginForm();
            _loginForm.LoginClicked += OnLoginClicked;
            _loginForm.Shown += (_, _) => _loginForm.AutoLogin();
        }

        public void OpenForm(FormController formController)
        {
            formController.OpenFullForm(_loginForm);
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
            string staffId = StaffAccountRepository.GetStaffIdByUsername(credentials.Username);
            LoggedIn?.Invoke(this, staffId);
            
            SaveLastLoginUsername(credentials.Username);
        }

        private void SaveLastLoginUsername(string username)
        {
            var settings = UserSettings.GetSettings();
            settings.LastLoginUsername = username;
            settings.Save();
        }
    }
}