using System;
using System.Windows.Forms;
using Better_Limited_Project.FormControlling;

namespace Better_Limited_Project.Navigation
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
            formController.OpenForm(salesNavigationForm, DockStyle.Left);
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