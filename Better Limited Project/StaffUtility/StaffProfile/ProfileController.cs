using Better_Limited_Project.FormControlling;
using Better_Limited_Project.Staff.StaffEntity;
using Better_Limited_Project.StaffUtility.StaffEntity;

namespace Better_Limited_Project.StaffUtility.StaffProfile
{
    public class ProfileController
    {
        private ProfileForm _profileForm;
        private readonly FormController _formController;

        public ProfileController(FormController formController)
        {
            _formController = formController;
        }

        public void OpenForm(string staffId)
        {
            var staff = StaffRepository.GetStaff(staffId);
            _profileForm = new ProfileForm(staff);
            _formController.OpenForm(_profileForm);
        }
    }
}