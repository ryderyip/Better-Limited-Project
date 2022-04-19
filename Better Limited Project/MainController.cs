using System;
using Better_Limited_Project.FormControlling;
using Better_Limited_Project.Login;
using Better_Limited_Project.Navigation;
using Better_Limited_Project.Navigation.Controller;
using Better_Limited_Project.SettingsUtility;
using Better_Limited_Project.StaffUtility.StaffEntity;
using Better_Limited_Project.StaffUtility.StaffProfile;

namespace Better_Limited_Project
{
    public class MainController
    {
        private readonly FormController _formController;
        private readonly UserSettings _userSettings;
        private INavigationController _navigationController;
        
        public MainController(MainForm mainForm)
        {
            _formController = new FormController(mainForm);
            _userSettings = UserSettings.GetSettings();
            mainForm.Shown += StartLoginProcess;
        }
        
        private void StartLoginProcess(object sender, EventArgs e)
        {
            OpenLoginForm();
            SetLanguage();
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
        
        private void SetLanguage()
        {
            LanguageController.SetLanguage(_userSettings.Language);
        }
        
        private void OnLoggedIn(object sender, string staffId)
        {
            var staff = StaffRepository.GetStaff(staffId);
            OpenNavigationForm(staff);
            OpenProfileForm(staff);
        }

        private void OpenNavigationForm(Staff staff)
        {
            _navigationController = 
                NavigationControllerFactory.CreateController(_formController, staff);
            _navigationController.LogOutClicked += OnLogOut;
            _navigationController.OpenForm();
        }
        
        private void OpenProfileForm(Staff staff)
        {
            var profileController = new ProfileController(_formController);
            profileController.LogOutClicked += OnLogOut;
            profileController.OpenForm(staff);
        }
        
        private void OnLogOut(object sender, EventArgs e)
        {
            _navigationController.CloseForm();
            OpenLoginForm();
        }
    }
}