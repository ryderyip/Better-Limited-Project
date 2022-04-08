using System;
using Better_Limited_Project.FormControlling;
using Better_Limited_Project.Navigation.Form;

namespace Better_Limited_Project.Navigation.Controller
{
    public class SalesNavigationController : INavigationController
    {
        public void OpenForm(FormController formController)
        {
            var salesNavigationForm = new SalesNavigationForm();
            salesNavigationForm.ProfileClicked += OnProfileClicked;
            salesNavigationForm.PlaceOrderClicked += OnPlaceOrderClicked;
            salesNavigationForm.SalesOrderClicked += OnSalesOrderClicked;
            salesNavigationForm.ProductListClicked += OnProductListClicked;
            salesNavigationForm.SettingsClicked += OnSettingsClicked;
            formController.OpenNavigationForm(salesNavigationForm);
        }

        private void OnProfileClicked(object sender, EventArgs e)
        {

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

        }
    }
}