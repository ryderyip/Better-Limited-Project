using System;
using System.Windows.Forms;
using Better_Limited_Project.FormControlling;
using Better_Limited_Project.Login;
using Better_Limited_Project.ProductUtility.DefectiveItemReturning;
using Better_Limited_Project.ProductUtility.GoodsPurchasing.UI;
using Better_Limited_Project.ProductUtility.InwardGoodsUtility.UI;
using Better_Limited_Project.Sales.OrderPlacing.UI;
using Better_Limited_Project.SettingsUtility;
using Better_Limited_Project.StaffUtility.StaffProfile;

namespace Better_Limited_Project.Navigation.UI
{
    public partial class AccountingClerkNavigationForm : Form, INavigationForm
    {
        private readonly FormController _formController;
        public event INavigationForm.LogOutClickedEventHandler? LogOutClicked;

        public AccountingClerkNavigationForm(FormController formController)
        {
            _formController = formController;
            Shown += (_, _) => btnProfile.Text = LoginSession.GetSession().CurrentStaff.Name;
            InitializeComponent();
        }

        private void btnPurchaseOrders_Click(object sender, EventArgs e)
        {
            var form = new PurchaseOrderListForm();
            _formController.OpenContentForm(form);
        }

        private void btnSalesOrder_Click(object sender, EventArgs e)
        {
            var form = new SalesOrderListForm();
            _formController.OpenContentForm(form);
        }

        private void btnSalesReport_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void btnGoodsReceived_Click(object sender, EventArgs e)
        {
            var form = new InwardGoodsRecordListForm();
            _formController.OpenContentForm(form);
        }

        private void btnGoodsReturned_Click(object sender, EventArgs e)
        {
            var form = new DefectiveItemListForm();
            _formController.OpenContentForm(form);
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            var controller = new SettingsController(_formController);
            controller.OpenForm();
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            var profileController = new ProfileController(_formController);
            profileController.LogOutClicked += (_, _) => LogOutClicked?.Invoke(this, EventArgs.Empty);
            profileController.OpenForm();
        }
    }
}
