using System;
using Better_Limited_Project.FormControlling;
using Better_Limited_Project.Navigation.Form;
using Better_Limited_Project.SettingsUtility;
using Better_Limited_Project.StaffUtility.StaffEntity;
using Better_Limited_Project.StaffUtility.StaffProfile;

namespace Better_Limited_Project.Navigation.Controller
{
    public class SalesNavigationController : INavigationController
    {
        private readonly FormController _formController;
        private readonly string _staffId;
        private SalesNavigationForm _salesNavigationForm;

        public SalesNavigationController(FormController formController, string staffId)
        {
            _formController = formController;
            _staffId = staffId;
        }

        public void OpenForm()
        {
            _salesNavigationForm = new SalesNavigationForm();
            SubscribeAllFormEvents(_salesNavigationForm);
            _formController.OpenNavigationForm(_salesNavigationForm);
            string staffName = StaffRepository.GetStaff(_staffId).Name;
            _salesNavigationForm.SetProfileButtonStaffName(staffName);
        }

        public void CloseForm()
        {
            _salesNavigationForm.Close();
        }

        private void SubscribeAllFormEvents(SalesNavigationForm salesNavigationForm)
        {
            salesNavigationForm.ProfileClicked += OnProfileClicked;
            salesNavigationForm.PlaceOrderClicked += OnPlaceOrderClicked;
            salesNavigationForm.SalesOrderClicked += OnSalesOrderClicked;
            salesNavigationForm.ProductListClicked += OnProductListClicked;
            salesNavigationForm.SettingsClicked += OnSettingsClicked;
        }

        private void OnProfileClicked(object sender, EventArgs e)
        {
            var profileController = new ProfileController(_formController);
            profileController.OpenForm(_staffId);
        }
        
        private void OnPlaceOrderClicked(object sender, EventArgs e)
        {
            
        }
        private void OnSalesOrderClicked(object sender, EventArgs e)
        {

        }
        private void OnProductListClicked(object sender, EventArgs e)
        {
            
        }
        private void OnSettingsClicked(object sender, EventArgs e)
        {
            var controller = new SettingsController(_staffId);
            controller.OpenForm(_formController);
        }
    }
}