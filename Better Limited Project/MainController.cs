using System;
using System.Windows.Forms;
using Better_Limited_Project.FormControlling;
using Better_Limited_Project.Login;
using Better_Limited_Project.Navigation;
using Better_Limited_Project.Navigation.UI;
using Better_Limited_Project.SettingsUtility;
using Better_Limited_Project.StaffUtility.StaffEntity;
using Better_Limited_Project.StaffUtility.StaffProfile;

namespace Better_Limited_Project
{
    public class MainController
    {
        private readonly FormController _formController;
        private readonly UserSettings _userSettings;
        private INavigationForm? _navigationForm;
        
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
            string? lastLoginUsername = _userSettings.LastLoginUsername;
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
            LoginSession.SaveSession(staffId);
            OpenNavigationForm(staff);
            OpenProfileForm(staff);
        }

        private void OpenNavigationForm(Staff staff)
        {
            _navigationForm = NavigationFormFactory.GenerateForm(_formController, staff);
            _navigationForm.LogOutClicked += OnLogOut;
            _formController.OpenNavigationForm((Form) _navigationForm);
        }
        
        private void OpenProfileForm(Staff staff)
        {
            var profileController = new ProfileController(_formController);
            profileController.LogOutClicked += OnLogOut;
            profileController.OpenForm(staff);
        }
        
        private void OnLogOut(object sender, EventArgs e)
        {
            if (_navigationForm != null) 
                ((Form) _navigationForm).Close();
            OpenLoginForm();
        }
    }
}