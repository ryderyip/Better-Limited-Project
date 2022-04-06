using System;
using System.Windows.Forms;
using Better_Limited_Project.Login;
using Better_Limited_Project.Navigation;
using Better_Limited_Project.SettingsUtility;

namespace Better_Limited_Project.FormControlling
{
    public class MainController
    {
        private readonly FormController _formController;
        private readonly LoginSession _session;
        private LoginController _loginController;

        public MainController(MainForm mainForm)
        {
            mainForm.Shown += OnMainFormShown;
            _session = new LoginSession
            {
                UserSettings = LoadSettings()
            };
            _formController = new FormController(_session.UserSettings, mainForm);
        }

        private void OnMainFormShown(object sender, EventArgs e)
        {
            _loginController = new LoginController();
            _loginController.LoggedIn += OnLoggedIn;
            OpenLoginForm();
        }

        private void OpenLoginForm()
        {
            string lastLoginUsername = _session.UserSettings.LastLoginUsername;
            if (lastLoginUsername == null)
                _loginController.OpenForm(_formController);
            else
                _loginController.OpenForm(_formController, lastLoginUsername);
        }

        private UserSettings LoadSettings()
        {
            return UserSettings.GetSettings();
        }

        private void OnLoggedIn(object sender, Login.Staff staff)
        {
            var navigationController =
                NavigationControllerFactory.CreateController(staff.StaffTitle);
            navigationController.OpenForm(_formController);
        }
    }
}