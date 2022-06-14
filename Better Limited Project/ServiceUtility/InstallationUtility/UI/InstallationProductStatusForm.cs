using System.Linq;
using System.Windows.Forms;
using Better_Limited_Project.Sales.OrderPlacing.Entity;

namespace Better_Limited_Project.ServiceUtility.InstallationUtility.UI
{
    public partial class InstallationProductStatusForm : Form
    {
        private readonly SalesOrder _salesOrder;

        public InstallationProductStatusForm(SalesOrder salesOrder)
        {
            _salesOrder = salesOrder;
            StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
            Load += (_, _) => Initialize();
        }

        private void Initialize()
        {
            var installationRequest = _salesOrder.GetInstallationRequest();
            if (installationRequest == default)
            {
                MessageBox.Show("Current sales order has not requested for instllation.");
                return;
            }

            var productsToInstall = installationRequest.ProductsToInstall;
            foreach (var installationRequestProduct in productsToInstall)
            {
                var installations = installationRequest.GetInstallations().ToList();
                dgvInstallationProduct.Rows.Add(installationRequestProduct.Product.Name,
                    installationRequestProduct.Quantity,
                    installationRequestProduct.InstallationRequest.ArrangedOn?.ToString("g") ?? "-",
                    installations.Any() ? installations.First().InstalledOn?.ToString("g") ?? "-" : "-");
            }

            foreach (var technician in installationRequest.GetInstallations().SelectMany(i => i.Technicians.Select(t => t.Technician)))
                dgvTechnicians.Rows.Add(technician.Name, technician.Phone);
        }
    }
}
