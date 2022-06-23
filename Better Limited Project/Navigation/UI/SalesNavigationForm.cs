using System;
using System.Linq;
using System.Windows.Forms;
using Better_Limited_Project.CustomerRecord;
using Better_Limited_Project.FormControlling;
using Better_Limited_Project.Login;
using Better_Limited_Project.ProductUtility.DefectiveItemReturning;
using Better_Limited_Project.ProductUtility.ProductList.Forms;
using Better_Limited_Project.ProductUtility.Restocking.UI;
using Better_Limited_Project.Sales.OrderPlacing.Controller;
using Better_Limited_Project.Sales.OrderPlacing.UI;
using Better_Limited_Project.SettingsUtility;
using Better_Limited_Project.StaffUtility.Repository;
using Better_Limited_Project.StaffUtility.StaffProfile;

namespace Better_Limited_Project.Navigation.UI
{
    public partial class SalesNavigationForm : Form, INavigationForm
    {
        private readonly FormController _formController;
        public event INavigationForm.LogOutClickedEventHandler? LogOutClicked;

        public SalesNavigationForm(FormController formController)
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
        
        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            if (!HasSelectedRetailStore())
            {
                MessageBox.Show(NavigationForms.noSelectedRetailStoreMessage);
                return;
            }
            var controller = new PlaceOrderController();
            controller.OpenForm();
        }

        private void btnSalesOrder_Click(object sender, EventArgs e)
        {
            if (!HasSelectedRetailStore())
            {
                MessageBox.Show(NavigationForms.noSelectedRetailStoreMessage);
                return;
            }

            var form = new SalesOrderListForm();
            _formController.OpenContentForm(form);
        }

        private void btnProductList_Click(object sender, EventArgs e)
        {
            if (!HasSelectedRetailStore())
            {
                MessageBox.Show(NavigationForms.noSelectedRetailStoreMessage);
                return;
            }
            
            var form = new ProductListForm();
            _formController.OpenContentForm(form);
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            var controller = new SettingsController(_formController);
            controller.OpenForm();
        }

        private bool HasSelectedRetailStore()
        {
            var currentRetailStore = UserSettings.GetSettings().Workplace;
            return currentRetailStore != null
                   && new RetailStoreRepository().FindAll(store => store.Id == currentRetailStore.Id)
                       .Any();
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            var form = new CustomerListForm();
            _formController.OpenContentForm(form);
        }

        private void btnDefectiveItem_Click(object sender, EventArgs e)
        {
            var form = new DefectiveItemListForm();
            _formController.OpenContentForm(form);
        }

        private void btnRestockRequest_Click(object sender, EventArgs e)
        {
            var form = new RestockRequestListForm();
            _formController.OpenContentForm(form);
        }
    }
}