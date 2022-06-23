using System.Linq;
using Better_Limited_Project.FormControlling;
using Better_Limited_Project.SettingsUtility;

namespace Better_Limited_Project.Login
{
    public class LoginController
    {
        public delegate void LoggedInEventHandler<T>(object sender, T staffId);

        private readonly LoginForm _loginForm;

        public LoginController()
        {
            _loginForm = new LoginForm();
            _loginForm.LoginClicked += OnLoginClicked;
        }

        public LoginController(string lastLoginUsername) : this()
        {
            _loginForm.FillLastLoginUsername(lastLoginUsername);
        }

        public event LoggedInEventHandler<string>? LoggedIn;

        public void OpenForm(FormController formController)
        {
            formController.OpenFullForm(_loginForm);
        }

        private void OnLoginClicked(object sender, LoginCredentials credentials)
        {
            var staffAccountRepository = new StaffAccountRepository();
            var verifier = new LoginVerifier(staffAccountRepository);
            var status = verifier.VerifyLogin(credentials);
            if (status is not LoginStatus.Successful)
            {
                _loginForm.LoginFailed(status);
                return;
            }

            _loginForm.Close();
            string staffId = staffAccountRepository.FindAll(ac => ac.Username == credentials.Username).First().StaffId;
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