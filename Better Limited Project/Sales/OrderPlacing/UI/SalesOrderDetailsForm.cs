using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using Better_Limited_Project.Login;
using Better_Limited_Project.ProductUtility.ProductList.Forms;
using Better_Limited_Project.Sales.OrderPlacing.Controller;
using Better_Limited_Project.Sales.OrderPlacing.Entity;
using Better_Limited_Project.Sales.OrderPlacing.Repository;
using Better_Limited_Project.Sales.PaymentUtility;
using Better_Limited_Project.ServiceUtility.InstallationUtility.Entity;
using Better_Limited_Project.ServiceUtility.InstallationUtility.UI;
using Better_Limited_Project.SettingsUtility;
using Better_Limited_Project.StaffUtility.StaffEntity;
using Better_Limited_Project.Tools;

namespace Better_Limited_Project.Sales.OrderPlacing.UI
{
    public partial class SalesOrderDetailsForm : Form
    {
        public EventHandler? OrderUpdated;
        private SalesOrder _salesOrder;
        private readonly List<SalesOrderProduct> _salesOrderProducts;

        public SalesOrderDetailsForm(SalesOrder salesOrder)
        {
            _salesOrder = salesOrder;
            _salesOrderProducts = salesOrder.GetSalesOrderProducts().ToList();
            StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
            Shown += (_, _) => Initialize();
        }

        private void Initialize()
        {
            ToolTipGenerator.Generate(initialDelay: 0)
                .SetToolTip(lblIsActive, OrderPlacingStringResources.active_inactive_order_meaning_tooltip);
            SetOrderActivityText();
            PopulateProductDgv();
            FillFields();
            DisappearUselessButtons();
        }

        private void SetOrderActivityText()
        {
            if (_salesOrder.IsActive)
            {
                lblIsActive.Text = PaymentStringResources.active_order;
                lblIsActive.ForeColor = Color.ForestGreen;
            }
            else
            {
                lblIsActive.Text = PaymentStringResources.inactive_order;
                lblIsActive.ForeColor = Color.OrangeRed;
            }
        }

        private void PopulateProductDgv()
        {
            dgvProducts.Rows.Clear();
            foreach (var sop in _salesOrderProducts)
            {
                var product = sop.GetProduct();
                int rowIndex = dgvProducts.Rows.Add(product.Id,
                    product.Name,
                    sop.Quantity,
                    EnumToStringHelper.GetDisplayValue(sop.GetPaymentStatus()),
                    sop.IsStockReady() ? "Replenished" : "Awaiting Restock");
                if (sop.GetPaymentStatus() is not SalesOrderProductPaymentStatus.FullyPaid)
                    dgvProducts.Rows[rowIndex].DefaultCellStyle.BackColor = FormColors.DgvRowAttention;
            }
        }

        private void DisappearUselessButtons()
        {
            if (LoginSession.GetSession().CurrentStaff.Department is Department.Inventory)
            {
                BtnPaymentReceipt.Visible = false;
                btnSettleIncompletePayment.Visible = false;
                btnDepositReceipt.Visible = false;
                btnManageOrder.Visible = false;
            }

            var calculator = new SalesOrderCalculator(_salesOrder.GetSalesOrderProducts());
            if (!_salesOrder.HasCompletedPayment())
                BtnPaymentReceipt.Visible = false;
            if (!_salesOrder.HasDepositPayment())
                btnDepositReceipt.Visible = false;
            if (calculator.IsAllPaymentCompleted())
                btnSettleIncompletePayment.Visible = false;
            if (!_salesOrder.IsActive)
            {
                btnManageOrder.Visible = false;
                btnSettleIncompletePayment.Visible = false;
            }

            if (_salesOrder.GetInstallationStatus() is InstallationStatus.InstallationArranged or InstallationStatus
                .AllInstalled)
                btnInstallationStatus.Visible = true;
        }

        private void FillFields()
        {
            var delivery = _salesOrder.GetDeliveries().FirstOrDefault();
            var deliveryRequest = _salesOrder.GetDeliveryRequest();
            var calculator = new SalesOrderCalculator(_salesOrder.GetSalesOrderProducts());

            txtOrderNumber.Text = _salesOrder.OrderNumber;
            tbTotalAmount.Text = calculator.GetTotalAmount().ToString("C", new CultureInfo("zh-HK"));
            txtAmtDue.Text = calculator.GetAmountDue().ToString("C", new CultureInfo("zh-HK"));
            txtAmtPaid.Text = calculator.GetAmountPaid().ToString("C", new CultureInfo("zh-HK"));
            var installationStatus = _salesOrder.GetInstallationStatus();
            txtInstallation.Text = installationStatus switch
            {
                InstallationStatus.AllInstalled => "All Installed",
                InstallationStatus.InstallationRequested => "Installation Requested",
                InstallationStatus.InstallationArranged => "Installation Arranged",
                _ => "No Installation Requested"
            };
            tbDeliveryStatus.Text = delivery == default
                ? deliveryRequest == default ? "No Delivery Requested" : "Delivery Request Not Confirmed"
                : EnumToStringHelper.GetDisplayValue(delivery.DeliveryStatus);
            tbCreatedOn.Text = _salesOrder.CreatedOn.ToString("g");

            if (_salesOrder.Customer != null)
            {
                txtCustName.Text = _salesOrder.Customer.Name;
                txtCustPhoneNumber.Text = _salesOrder.Customer.Phone;
                txtCustEmail.Text = _salesOrder.Customer.Email ?? txtCustEmail.Text;
                txtAddress1.Text = _salesOrder.Customer.Address.Address1;
                txtAddress2.Text = _salesOrder.Customer.Address.Address2;
            }
        }

        private void btnPaymentReceipt_Click(object sender, EventArgs e)
        {
            var generator = new PaymentReceiptGenerator(_salesOrder);
            generator.GenerateAndOpen();
        }

        private void btnDepositReceipt_Click(object sender, EventArgs e)
        {
            var generator = new DepositReceiptGenerator(_salesOrder);
            generator.GenerateAndOpen();
        }

        private void btnSettleIncompletePayment_Click(object sender, EventArgs e)
        {
            if (!_salesOrder.IsAllStockReady())
            {
                MessageBox.Show(OrderPlacingStringResources.cannot_settle_payment_yet);
                return;
            }

            var service = new SettleIncompletePaymentService(_salesOrder);
            service.PaymentSettled += (_, _) =>
            {
                Initialize();
                OrderUpdated?.Invoke(this, EventArgs.Empty);
            };
            service.Start();
        }

        private void btnEditOrder_Click(object sender, EventArgs e)
        {
            var form = new ManageSalesOrderForm(_salesOrder);
            form.StartPosition = FormStartPosition.CenterScreen;
            form.SalesOrderUpdated += (_, _) =>
            {
                _salesOrder = new SalesOrderRepository().FindById(_salesOrder.Id);
                Initialize();
                OrderUpdated?.Invoke(this, EventArgs.Empty);
            };
            form.ShowDialog();
        }

        private void dgvProducts_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string selectedProductId = dgvProducts.Rows[e.RowIndex].Cells[idColumn.Name].Value.ToString();
            var selectedProduct = _salesOrderProducts.Find(sop => sop.ProductId == selectedProductId);
            var productStock = UserSettings.GetSettings().Workplace!.GetProductStock(selectedProduct.ProductId);
            var form = new ProductDetailsForm(productStock);
            form.StartPosition = FormStartPosition.CenterScreen;
            form.ShowDialog();
        }

        private void btnInstallationStatus_Click(object sender, EventArgs e)
        {
            var form = new InstallationProductStatusForm(_salesOrder);
            form.ShowDialog();
        }
    }
}