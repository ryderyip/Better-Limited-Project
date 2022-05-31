using System;
using System.Windows.Forms;
using Better_Limited_Project.FormControlling;
using Better_Limited_Project.SettingsUtility;
using Better_Limited_Project.StaffUtility.StaffEntity;
using Better_Limited_Project.StaffUtility.StaffProfile;

namespace Better_Limited_Project.Navigation.UI
{
    public partial class AccountingClerkNavigationForm : Form, INavigationForm
    {
        private readonly FormController _formController;
        private readonly Staff _staff;
        public event INavigationForm.LogOutClickedEventHandler? LogOutClicked;

        public AccountingClerkNavigationForm(FormController formController, Staff staff)
        {
            _formController = formController;
            _staff = staff;
            Shown += (_, _) => btnProfile.Text = staff.Name;
            InitializeComponent();
        }

        private void btnPurchaseOrders_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void btnSalesOrder_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void btnSalesReport_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void btnGoodsReceived_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void btnGoodsReturned_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            var controller = new SettingsController(_staff);
            controller.OpenForm(_formController);
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            var profileController = new ProfileController(_formController);
            profileController.LogOutClicked += (_, _) => LogOutClicked?.Invoke(this, EventArgs.Empty);
            profileController.OpenForm(_staff);
        }
    }
}
