using System;
using System.Windows.Forms;
using Better_Limited_Project.FormControlling;
using Better_Limited_Project.ProductUtility.ProductList.ProductList;
using Better_Limited_Project.SettingsUtility;
using Better_Limited_Project.StaffUtility.StaffEntity;
using Better_Limited_Project.StaffUtility.StaffProfile;

namespace Better_Limited_Project.Navigation.UI
{
    public partial class ReceivingClerkNavigationForm : Form, INavigationForm
    {
        private readonly FormController _formController;
        private readonly Staff _staff;
        public event INavigationForm.LogOutClickedEventHandler? LogOutClicked;
        
        public ReceivingClerkNavigationForm(FormController formController, Staff staff)
        {
            _formController = formController;
            _staff = staff;
            InitializeComponent();
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            var profileController = new ProfileController(_formController);
            profileController.LogOutClicked += (_, _) => LogOutClicked?.Invoke(this, EventArgs.Empty);
            profileController.OpenForm(_staff);
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            var controller = new SettingsController(_staff);
            controller.OpenForm(_formController);
        }

        private void btnGoodsReceived_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void btnInventory_Click(object sender, EventArgs e)
        {
            var controller = ProductListControllerFactory.Generate();
            controller.OpenForm(_formController);
        }

        private void btnPurchaseOrders_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }
    }
}