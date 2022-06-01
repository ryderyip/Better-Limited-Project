using System;
using Better_Limited_Project.FormControlling;
using Better_Limited_Project.SettingsUtility;
using Better_Limited_Project.StaffUtility.StaffEntity;

namespace Better_Limited_Project.StaffUtility.StaffProfile
{
    public class ProfileController
    {
        private readonly FormController _formController;
        private ProfileForm _profileForm;
        public event EventHandler? LogOutClicked;

        public ProfileController(FormController formController)
        {
            _formController = formController;
        }

        public void OpenForm(Staff staff)
        {
            if (IsProfileFormAlreadyOpened())
                return;
            var settings = UserSettings.GetSettings();
            _profileForm = settings.Workplace == null ? 
                           new ProfileForm(staff, "Unknown") :
                           new ProfileForm(staff, settings.Workplace.Name);
            _profileForm.LogOutClicked += OnLogOutClicked;
            _formController.OpenContentForm(_profileForm);
        }
        
        private void OnLogOutClicked(object sender, EventArgs e)
        {
            LogOutClicked?.Invoke(sender, e);
            _profileForm.Close();
        }

        private bool IsProfileFormAlreadyOpened()
        {
            return _formController.ContentForm != null 
                   && _formController.ContentForm.GetType() == typeof(ProfileForm);
        }
    }
}