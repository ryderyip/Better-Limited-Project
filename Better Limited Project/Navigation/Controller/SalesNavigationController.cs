using System;
using Better_Limited_Project.FormControlling;
using Better_Limited_Project.Navigation.UI;
using Better_Limited_Project.ProductUtility.ProductList;
using Better_Limited_Project.Sales.Sales.SalesOrder;
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
            _salesNavigationForm = new SalesNavigationForm(_staff.Name);
        }

        public event INavigationController.LogOutClickedEventHandler LogOutClicked;

        public void OpenForm()
        {
            SubscribeAllFormEvents();
            _formController.OpenNavigationForm(_salesNavigationForm);
        }
        
        private void SubscribeAllFormEvents()
        {
            _salesNavigationForm.ProfileClicked += OnProfileClicked;
            _salesNavigationForm.PlaceOrderClicked += OnPlaceOrderClicked;
            _salesNavigationForm.SalesOrderClicked += OnSalesOrderClicked;
            _salesNavigationForm.ProductListClicked += OnProductListClicked;
            _salesNavigationForm.SettingsClicked += OnSettingsClicked;
        }

        public void CloseForm()
        {
            _salesNavigationForm.Close();
        }
        
        private void OnProfileClicked(object sender, EventArgs e)
        {
            var profileController = new ProfileController(_formController);
            profileController.LogOutClicked += (_, _) => LogOutClicked?.Invoke(this, EventArgs.Empty);
            profileController.OpenForm(_staff);
        }
        
        private void OnPlaceOrderClicked(object sender, EventArgs e)
        {
            var controller = new PlaceOrderController();
            controller.OpenForm();
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