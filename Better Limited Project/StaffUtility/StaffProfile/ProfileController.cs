using Better_Limited_Project.FormControlling;

namespace Better_Limited_Project.StaffUtility.StaffProfile
{
    public class ProfileController
    {
        private ProfileForm _profileForm;

        public void OpenForm(FormController formController, StaffEntity.Staff staff)
        {
            _profileForm = new ProfileForm(staff);
            formController.OpenForm(_profileForm);
        }
    }
}