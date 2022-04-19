using System;
using Better_Limited_Project.Login;
using Better_Limited_Project.Navigation;
using Better_Limited_Project.Navigation.Controller;
using Better_Limited_Project.SettingsUtility;
using Better_Limited_Project.StaffUtility.StaffEntity;
using Better_Limited_Project.StaffUtility.StaffProfile;

namespace Better_Limited_Project.FormControlling
{
    public class MainController
    {
        private readonly FormController _formController;
        private readonly UserSettings _userSettings;
        private Staff _staff;
        private INavigationController _navigationController;
        
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
            _staff = StaffRepository.GetStaff(staffId);
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
            _navigationController = 
                NavigationControllerFactory.CreateController(_formController, _staff);
            _navigationController.LogOutClicked += OnLogOut;
            _navigationController.OpenForm();
        }
        
        private void OpenProfileForm()
        {
            var profileController = new ProfileController(_formController);
            profileController.LogOutClicked += OnLogOut;
            profileController.OpenForm(_staff);
        }
        
        private void OnLogOut(object sender, EventArgs e)
        {
            _navigationController.CloseForm();
            OpenLoginForm();
        }
    }
}