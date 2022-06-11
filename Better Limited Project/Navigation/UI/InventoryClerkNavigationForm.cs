using System;
using System.Windows.Forms;
using Better_Limited_Project.FormControlling;
using Better_Limited_Project.Login;
using Better_Limited_Project.ProductUtility.DefectiveItemReturning;
using Better_Limited_Project.ProductUtility.ProductList.Forms;
using Better_Limited_Project.ServiceUtility.Delivery.UI;
using Better_Limited_Project.SettingsUtility;
using Better_Limited_Project.StaffUtility.StaffProfile;

namespace Better_Limited_Project.Navigation.UI
{
    public partial class InventoryClerkNavigationForm : Form, INavigationForm
    {
        private readonly FormController _formController;
        public event INavigationForm.LogOutClickedEventHandler? LogOutClicked;
        
        public InventoryClerkNavigationForm(FormController formController)
        {
            _formController = formController;
            Shown += (_, _) => btnProfile.Text = LoginSession.GetSession().CurrentStaff.Name;
            InitializeComponent();
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            var profileController = new ProfileController(_formController);
            profileController.LogOutClicked += (_, _) => LogOutClicked?.Invoke(this, EventArgs.Empty);
            profileController.OpenForm();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            var controller = new SettingsController(_formController);
            controller.OpenForm();
        }

        private void btnCouriers_Click(object sender, EventArgs e)
        {
            var form = new CourierListForm();
            _formController.OpenContentForm(form);
        }

        private void btnGoodsReceived_Click(object sender, EventArgs e)
        {
            if (!UserSettings.HasSelectedWorkplace())
            {
                MessageBox.Show(NavigationForms.noSelectedWarehouseMessage);
                return;
            }
            throw new NotImplementedException();
        }

        private void btnGoodsReturned_Click(object sender, EventArgs e)
        {
            if (!UserSettings.HasSelectedWorkplace())
            {
                MessageBox.Show(NavigationForms.noSelectedWarehouseMessage);
                return;
            }

            var form = new DefectiveItemListForm();
            _formController.OpenContentForm(form);
        }

        private void btnReorderRequests_Click(object sender, EventArgs e)
        {
            if (!UserSettings.HasSelectedWorkplace())
            {
                MessageBox.Show(NavigationForms.noSelectedWarehouseMessage);
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
                MessageBox.Show(NavigationForms.noSelectedWarehouseMessage);
                return;
            }
            var form = new ProductListForm();
            _formController.OpenContentForm(form);
        }

        private void btnDeliveryDuty_Click(object sender, EventArgs e)
        {
            if (!UserSettings.HasSelectedWorkplace())
            {
                MessageBox.Show(NavigationForms.noSelectedWarehouseMessage);
                return;
            }

            var form = new DeliveryListForm();
            _formController.OpenContentForm(form);
        }
    }
}