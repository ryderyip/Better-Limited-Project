using System;
using Better_Limited_Project.FormControlling;
using Better_Limited_Project.Navigation.UI;
using Better_Limited_Project.ProductUtility.ProductList;
using Better_Limited_Project.SettingsUtility;
using Better_Limited_Project.StaffUtility.StaffEntity;
using Better_Limited_Project.StaffUtility.StaffProfile;

namespace Better_Limited_Project.Navigation.Controller
{
    public class SalesNavigationController : INavigationController
    {
        private readonly FormController _formController;
        private readonly Staff _staff;
        private readonly SalesNavigationForm _salesNavigationForm;

        public SalesNavigationController(FormController formController, Staff staff)
        {
            _formController = formController;
            _staff = staff;
            _salesNavigationForm = new SalesNavigationForm();
        }

        public event INavigationController.LogOutClickedEventHandler LogOutClicked;

        public void OpenForm()
        {
            SubscribeAllFormEvents(_salesNavigationForm);
            _formController.OpenNavigationForm(_salesNavigationForm);
            _salesNavigationForm.SetProfileButtonStaffName(_staff.Name);
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
            profileController.LogOutClicked += (_, _) => LogOutClicked?.Invoke(this, EventArgs.Empty);
            profileController.OpenForm(_staff);
        }
        
        private void OnPlaceOrderClicked(object sender, EventArgs e)
        {
            
        }
        private void OnSalesOrderClicked(object sender, EventArgs e)
        {

        }
        private void OnProductListClicked(object sender, EventArgs e)
        {
            var controller = new ProductListController(_formController);
            controller.OpenForm();
        }
        private void OnSettingsClicked(object sender, EventArgs e)
        {
            var controller = new SettingsController(_staff);
            controller.OpenForm(_formController);
        }
    }
}