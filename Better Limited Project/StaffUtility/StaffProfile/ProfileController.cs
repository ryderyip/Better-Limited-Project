using System;
using Better_Limited_Project.FormControlling;
using Better_Limited_Project.StaffUtility.StaffEntity;

namespace Better_Limited_Project.StaffUtility.StaffProfile
{
    public class ProfileController
    {
        private ProfileForm _profileForm;
        private readonly FormController _formController;
        public delegate void LogOutClickedEventHandler(object sender, EventArgs e);
        public event LogOutClickedEventHandler LogOutClicked;

        public ProfileController(FormController formController)
        {
            _formController = formController;
        }

        public void OpenForm(string staffId)
        {
            if (IsProfileFormAlreadyOpened())
                return;
            var staff = StaffRepository.GetStaff(staffId);
            _profileForm = new ProfileForm(staff);
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
            return _formController.ContentForm.GetType() == typeof(ProfileForm);
        }
    }
}