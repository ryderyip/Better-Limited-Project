using System;
using System.Windows.Forms;
using Better_Limited_Project.FormControlling;
using Better_Limited_Project.Login;
using Better_Limited_Project.Navigation;
using Better_Limited_Project.Navigation.UI;
using Better_Limited_Project.Procedure;
using Better_Limited_Project.StaffUtility.Repository;
using Better_Limited_Project.StaffUtility.StaffEntity;
using Better_Limited_Project.StaffUtility.StaffProfile;
using Better_Limited_Project.Tools;

namespace Better_Limited_Project
{
    public class MainController
    {
        private readonly FormController _formController;
        private INavigationForm? _navigationForm;
        
        public MainController(MainForm mainForm)
        {
            _formController = new FormController(mainForm);
            
            var loginProcess = new LoginProcedure(_formController);
            loginProcess.Finished += OnLoggedIn;
            
            mainForm.Shown += (_, _) => loginProcess.Start();
        }

        private void OnLoggedIn(object sender, string staffId)
        {
            var staff = new StaffRepository().FindById(staffId);
            LoginSession.SaveSession(staff);
            OpenNavigationForm(staff);
            OpenProfileForm(staff);
            SystemInitialization.Initialize();
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
            if (IsNavigationFormOpened()) 
                ((Form) _navigationForm!).Close();
            
            var loginProcess = new LoginProcedure(_formController);
            loginProcess.Finished += OnLoggedIn;
            loginProcess.Start();
        }

        private bool IsNavigationFormOpened()
        {
            return _navigationForm != null;
        }
    }
}