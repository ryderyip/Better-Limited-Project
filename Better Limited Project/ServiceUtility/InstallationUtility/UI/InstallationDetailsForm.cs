using System;
using System.Linq;
using System.Windows.Forms;
using Better_Limited_Project.Sales.OrderPlacing.UI;
using Better_Limited_Project.ServiceUtility.InstallationUtility.Entity;

namespace Better_Limited_Project.ServiceUtility.InstallationUtility.UI
{
    public partial class InstallationDetailsForm : Form
    {
        public event EventHandler? InfoUpdated;
        private readonly Installation _installation;

        public InstallationDetailsForm(Installation installation)
        {
            _installation = installation;
            StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
            Load += (_, _) => Initialize();
        }

        private void Initialize()
        {
            if (_installation.IsInstalled())
                btnSetAsInstalled.Visible = false;
            foreach (var installationRequestProduct in _installation.InstallationRequest.ProductsToInstall)
                dgvInstallationProduct.Rows.Add(installationRequestProduct.Product.Name,
                    installationRequestProduct.Quantity);
            
            tbScheduledOn.Text = _installation.ScheduledOn.ToString("f");
            tbInstalledOn.Text = _installation.InstalledOn?.ToString("f") ?? "-";

            foreach (var technician in _installation.Technicians.Select(it => it.Technician))
                dgvTechnicians.Rows.Add(technician.Name, technician.Phone);
        }

        private void btnViewSalesOrder_Click(object sender, EventArgs e)
        {
            var form = new SalesOrderDetailsForm(_installation.InstallationRequest.SalesOrder);
            form.ShowDialog();
        }

        private void btnSetAsInstalled_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Confirm setting this installation as installed?", "Confirmation", MessageBoxButtons.YesNo);
            if (result is not DialogResult.Yes)
                return;
            _installation.InstalledOn = DateTime.Now;
            _installation.Save();
            Initialize();
            InfoUpdated?.Invoke(this, EventArgs.Empty);
        }
    }
}
