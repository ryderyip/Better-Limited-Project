using System;
using System.Windows.Forms;
using Better_Limited_Project.Sales.OrderPlacing.UI;
using Better_Limited_Project.ServiceUtility.InstallationUtility.Entity;
using Better_Limited_Project.ServiceUtility.InstallationUtility.Repository;

namespace Better_Limited_Project.ServiceUtility.InstallationUtility.UI
{
    public partial class InstallationRequestDetailsForm : Form
    {
        private InstallationRequest _installationRequest;

        public InstallationRequestDetailsForm(InstallationRequest installationRequest)
        {
            _installationRequest = installationRequest;
            StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
            Load += (_, _) => Initialize();
        }

        public event EventHandler? InfoUpdated;

        private void Initialize()
        {
            if (_installationRequest.IsArranged())
                btnArrangeInstallation.Visible = false;
            if (_installationRequest.HasRequestedForDelieryButNotArranged())
                btnArrangeInstallation.Visible = false;
            FillFields();
            PopulateDgv();
        }

        private void PopulateDgv()
        {
            dgvInstallationProduct.Rows.Clear();
            foreach (var requestProduct in _installationRequest.ProductsToInstall)
                dgvInstallationProduct.Rows.Add(requestProduct.Product.Name, requestProduct.Quantity);
        }

        private void FillFields()
        {
            tbOrderNumber.Text = _installationRequest.SalesOrder.OrderNumber;
            tbCreatedOn.Text = _installationRequest.SalesOrder.CreatedOn.ToString("g");
            tbArrangedOn.Text = _installationRequest.ArrangedOn?.ToString("g") ?? "-";
            tbArrangedByStaffName.Text = _installationRequest.ArrangedByStaff?.Name ?? "-";
        }

        private void btnArrangeInstallation_Click(object sender, EventArgs e)
        {
            var form = new ArrangeInstallationForm(_installationRequest);
            var result = form.ShowDialog();
            if (result is DialogResult.OK)
                RefreshForm();
            InfoUpdated?.Invoke(this, EventArgs.Empty);
        }

        private void RefreshForm()
        {
            _installationRequest = InstallationRequestRepository.FindById(_installationRequest.Id);
            Initialize();
        }

        private void btnViewSalesOrder_Click(object sender, EventArgs e)
        {
            var fomr = new SalesOrderDetailsForm(_installationRequest.SalesOrder);
            fomr.ShowDialog();
        }
    }
}