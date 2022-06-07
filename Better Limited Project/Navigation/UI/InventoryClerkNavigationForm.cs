using System;
using System.Windows.Forms;
using Better_Limited_Project.FormControlling;
using Better_Limited_Project.ProductUtility.ProductList.Forms;
using Better_Limited_Project.ServiceUtility.Delivery.UI;
using Better_Limited_Project.SettingsUtility;
using Better_Limited_Project.StaffUtility.StaffEntity;
using Better_Limited_Project.StaffUtility.StaffProfile;

namespace Better_Limited_Project.Navigation.UI
{
    public partial class InventoryClerkNavigationForm : Form, INavigationForm
    {
        private readonly FormController _formController;
        private readonly Staff _staff;
        public event INavigationForm.LogOutClickedEventHandler? LogOutClicked;
        
        public InventoryClerkNavigationForm(FormController formController, Staff staff)
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

        private void btnSettings_Click(object sender, EventArgs e)
        {
            var controller = new SettingsController(_formController);
            controller.OpenForm();
        }

        private void btnDeliveryRequests_Click(object sender, EventArgs e)
        {
            if (!UserSettings.HasSelectedWorkplace())
            {
                MessageBox.Show("Please select your current warehouse before access this feature!");
                return;
            }

            var form = new DeliveryRequestListForm();
            _formController.OpenContentForm(form);
        }

        private void btnGoodsReceived_Click(object sender, EventArgs e)
        {
            if (!UserSettings.HasSelectedWorkplace())
            {
                MessageBox.Show("Please select your current warehouse before access this feature!");
                return;
            }
            throw new NotImplementedException();
        }

        private void btnGoodsReturned_Click(object sender, EventArgs e)
        {
            if (!UserSettings.HasSelectedWorkplace())
            {
                MessageBox.Show("Please select your current warehouse before access this feature!");
                return;
            }
            throw new NotImplementedException();
        }

        private void btnReorderRequests_Click(object sender, EventArgs e)
        {
            if (!UserSettings.HasSelectedWorkplace())
            {
                MessageBox.Show("Please select your current warehouse before access this feature!");
                return;
            }
            throw new NotImplementedException();
        }

        private void btnRestockRequests_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void btnInventory_Click(object sender, EventArgs e)
        {
            if (!UserSettings.HasSelectedWorkplace())
            {
                MessageBox.Show("Please select your current warehouse before access this feature!");
                return;
            }
            var form = new ProductListForm();
            _formController.OpenContentForm(form);
        }

        private void btnDeliveryDuty_Click(object sender, EventArgs e)
        {
            if (!UserSettings.HasSelectedWorkplace())
            {
                MessageBox.Show("Please select your current warehouse before access this feature!");
                return;
            }

            var form = new DeliveryListForm();
            _formController.OpenContentForm(form);
        }
    }
}