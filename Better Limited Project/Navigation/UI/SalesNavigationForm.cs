using System;
using Better_Limited_Project.FormControlling;
using Better_Limited_Project.ProductUtility.ProductList;
using Better_Limited_Project.ProductUtility.ProductList.ProductList;
using Better_Limited_Project.Sales.Sales.OrderPlacing;
using Better_Limited_Project.SettingsUtility;
using Better_Limited_Project.StaffUtility.StaffEntity;
using Better_Limited_Project.StaffUtility.StaffProfile;

namespace Better_Limited_Project.Navigation.UI
{
    public partial class SalesNavigationForm : System.Windows.Forms.Form, INavigationForm
    {
        private readonly FormController _formController;
        private readonly Staff _staff;
        public event INavigationForm.LogOutClickedEventHandler? LogOutClicked;

        public SalesNavigationForm(FormController formController, Staff staff)
        {
            _formController = formController;
            _staff = staff;
            Shown += (_, _) => btnProfile.Text = staff.Name;
            InitializeComponent();
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            var profileController = new ProfileController(_formController);
            profileController.LogOutClicked += (_, _) => LogOutClicked?.Invoke(this, EventArgs.Empty);
            profileController.OpenForm(_staff);
        }
        
        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            var controller = new PlaceOrderController();
            controller.OpenForm();
        }

        private void btnSalesOrder_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException("Sales order not implemented");
        }

        private void btnProductList_Click(object sender, EventArgs e)
        {
            var controller = ProductListControllerFactory.Generate(_formController);
            controller.OpenForm();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            var controller = new SettingsController(_staff);
            controller.OpenForm(_formController);
        }
    }
}