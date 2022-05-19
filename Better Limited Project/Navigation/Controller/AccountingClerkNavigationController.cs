using Better_Limited_Project.FormControlling;
using Better_Limited_Project.Navigation.UI;
using Better_Limited_Project.StaffUtility.StaffEntity;

namespace Better_Limited_Project.Navigation.Controller
{
    public class AccountingClerkNavigationController : INavigationController
    {
        private readonly FormController _formController;
        private readonly Staff _staff;
        private readonly AccountingClerkNavigationForm _form;
        public event INavigationController.LogOutClickedEventHandler? LogOutClicked;

        public AccountingClerkNavigationController(FormController formController, Staff staff)
        {
            _formController = formController;
            _staff = staff;
            _form = new AccountingClerkNavigationForm(staff.Name);
        }

        public void OpenForm()
        {
            throw new System.NotImplementedException();
        }

        public void CloseForm()
        {
            throw new System.NotImplementedException();
        }
    }
}