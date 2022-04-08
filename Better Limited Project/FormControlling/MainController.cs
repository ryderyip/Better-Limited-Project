using System;
using Better_Limited_Project.Login;
using Better_Limited_Project.Navigation;
using Better_Limited_Project.SettingsUtility;
using Better_Limited_Project.StaffUtility.StaffProfile;

namespace Better_Limited_Project.FormControlling
{
    public class MainController
    {
        private readonly FormController _formController;
        private readonly UserSettings _userSettings;
        private string _staffId;
        
        public MainController(MainForm mainForm)
        {
            _userSettings = UserSettings.GetSettings();
            SetLanguage();
            _formController = new FormController(mainForm);
            mainForm.Shown += OnMainFormShown;
        }

        private void SetLanguage()
        {
            LanguageController.SetLanguage(_userSettings.Language);
        }

        private void OnMainFormShown(object sender, EventArgs e)
        {
            OpenLoginForm();
        }
        
        private void OnLoggedIn(object sender, string staffId)
        {
            _staffId = staffId;
            OpenNavigationForm();
            OpenProfileForm();
        }
        
        private void OpenLoginForm()
        {
            var loginController = new LoginController();
            loginController.LoggedIn += OnLoggedIn;
            string lastLoginUsername = _userSettings.LastLoginUsername;
            if (lastLoginUsername == null)
                loginController.OpenForm(_formController);
            else
                loginController.OpenForm(_formController, lastLoginUsername);
        }

        private void OpenNavigationForm()
        {
            var navigationController = 
                NavigationControllerFactory.CreateController(_formController, _staffId);
            navigationController.OpenForm();
        }
        
        private void OpenProfileForm()
        {
            var profileController = new ProfileController(_formController);
            profileController.OpenForm(_staffId);
        }
    }
}