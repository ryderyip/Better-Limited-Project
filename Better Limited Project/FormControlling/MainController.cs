using System;
using System.Windows.Forms;
using Better_Limited_Project.Login;
using Better_Limited_Project.Navigation;
using Better_Limited_Project.SettingsUtility;
using Better_Limited_Project.StaffUtility.StaffProfile;

namespace Better_Limited_Project.FormControlling
{
    public class MainController
    {
        private readonly FormController _formController;
        private readonly LoginSession _session;
        
        public MainController(MainForm mainForm)
        {
            _session = LoginSession.CreateSession();
            SetLanguage();
            _formController = new FormController(_session.UserSettings, mainForm);
            mainForm.Shown += OnMainFormShown;
        }

        private void SetLanguage()
        {
            LanguageController.SetLanguage(_session.UserSettings.Language);
        }

        private void OnMainFormShown(object sender, EventArgs e)
        {
            OpenLoginForm();
        }
        
        private void OnLoggedIn(object sender, StaffUtility.StaffEntity.Staff staff)
        {
            OpenNavigationForm(staff);
            OpenProfileForm(staff);
        }

        private void OpenLoginForm()
        {
            var loginController = new LoginController();
            loginController.LoggedIn += OnLoggedIn;
            string lastLoginUsername = _session.UserSettings.LastLoginUsername;
            if (lastLoginUsername == null)
                loginController.OpenForm(_formController);
            else
                loginController.OpenForm(_formController, lastLoginUsername);
        }

        private void OpenNavigationForm(StaffUtility.StaffEntity.Staff staff)
        {
            var navigationController = NavigationControllerFactory.CreateController(staff.StaffTitle);
            navigationController.OpenForm(_formController);
        }
        
        private void OpenProfileForm(StaffUtility.StaffEntity.Staff staff)
        {
            var profileController = new ProfileController();
            profileController.OpenForm(_formController, staff);
        }
    }
}