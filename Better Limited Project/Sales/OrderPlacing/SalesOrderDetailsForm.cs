using System;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using Better_Limited_Project.Login;
using Better_Limited_Project.Sales.OrderPlacing.Entity;
using Better_Limited_Project.Sales.OrderPlacing.Repository;
using Better_Limited_Project.Sales.PaymentUtility;
using Better_Limited_Project.StaffUtility.StaffEntity;
using Better_Limited_Project.Tools;

namespace Better_Limited_Project.Sales.OrderPlacing
{
    public partial class SalesOrderDetailsForm : Form
    {
        public EventHandler? OrderUpdated;
        private SalesOrder _salesOrder;

        public SalesOrderDetailsForm(SalesOrder salesOrder)
        {
            _salesOrder = salesOrder;
            InitializeComponent();
        }
        
        private void OnFormShown(object sender, EventArgs e)
        {
            Initialize();
        }

        private void Initialize()
        {
            dgvProducts.Rows.Clear();
            foreach (var salesOrderProduct in _salesOrder.SalesOrderProducts)
            {
                var product = salesOrderProduct.GetProduct();
                dgvProducts.Rows.Add(product.Name,
                    EnumToStringHelper.GetDisplayValue(salesOrderProduct.GetStatus()),
                    product.Category.Name,
                    salesOrderProduct.Price.ToString("C", new CultureInfo("zh-HK")),
                    salesOrderProduct.Quantity,
                    (salesOrderProduct.Price * salesOrderProduct.Quantity).ToString("C", new CultureInfo("zh-HK")));
            }

            FillFields();

            if (LoginSession.GetSession().CurrentStaff.Department is Department.Inventory)
            {
                BtnPaymentReceipt.Visible = false;
                btnSettleIncompletePayment.Visible = false;
                btnDepositReceipt.Visible = false;
                btnEditOrder.Visible = false;
            }

            if (!_salesOrder.IsNeedDelivery() && _salesOrder.IsNeedInstallation())
                dgvProductsStatus.Visible = false;

            if (_salesOrder.SalesOrderProducts.All(sop => sop.GetPayments().All(sopp => !sopp.IsDeposit)))
                btnDepositReceipt.Enabled = false;
        }

        private void FillFields()
        {
            txtOrderNumber.Text = _salesOrder.OrderNumber;
            tbTotalAmount.Text = _salesOrder.GetTotalAmount().ToString("C", new CultureInfo("zh-HK"));
            decimal amountDue = _salesOrder.GetTotalAmount() - _salesOrder.GetAmountPaid();
            txtAmtDue.Text = amountDue.ToString("C", new CultureInfo("zh-HK"));
            txtAmtPaid.Text = _salesOrder.GetAmountPaid().ToString("C", new CultureInfo("zh-HK"));
            txtNeedDelivery.Text = _salesOrder.IsNeedDelivery() ? "Yes" : "No";
            txtNeedInstallation.Text = _salesOrder.IsNeedInstallation() ? "Yes" : "No";
            if (_salesOrder.Customer != null)
            {
                txtCustName.Text = _salesOrder.Customer.Name;
                txtCustPhoneNumber.Text = _salesOrder.Customer.Phone;
                txtCustEmail.Text = _salesOrder.Customer.Email ?? txtCustEmail.Text;
                txtAddress1.Text = _salesOrder.Customer.Address.Address1;
                txtAddress2.Text = _salesOrder.Customer.Address.Address2;
            }

            if (!_salesOrder.IsAllPaymentCompleted())
            {
                btnSettleIncompletePayment.Enabled = false;
                btnSettleIncompletePayment.BackColor = Color.Gray;
            }
        }

        private void BtnPaymentReceipt_Click(object sender, EventArgs e)
        {
            if (_salesOrder.SalesOrderProducts.All(sop => sop.GetPayments().Any(sopp => sopp.IsDeposit)))
            {
                MessageBox.Show("There are currently no completed product payments. " +
                                "(To see deposit receipts, click the button on the right.)");
                return;
            }
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
            
        }

        private void btnEditOrder_Click(object sender, EventArgs e)
        {
            var form = new EditSalesOrderForm(_salesOrder);
            form.StartPosition = FormStartPosition.CenterScreen;
            form.SalesOrderUpdated += (_, _) =>
            {
                _salesOrder = new SalesOrderRepository().FindById(_salesOrder.Id);
                Initialize();
                OrderUpdated?.Invoke(this, EventArgs.Empty);
            };
            form.ShowDialog();
        }
    }
}