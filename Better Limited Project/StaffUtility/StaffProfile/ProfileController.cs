using System;
using Better_Limited_Project.FormControlling;

namespace Better_Limited_Project.StaffUtility.StaffProfile
{
    public class ProfileController
    {
        private readonly FormController _formController;
        private readonly ProfileForm _profileForm;

        public ProfileController(FormController formController)
        {
            _formController = formController;
            _profileForm = new ProfileForm();
            _profileForm.LogOutClicked += OnLogOutClicked;
        }

        public event EventHandler? LogOutClicked;

        public void OpenForm()
        {
            if (IsProfileFormAlreadyOpened())
                return;

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