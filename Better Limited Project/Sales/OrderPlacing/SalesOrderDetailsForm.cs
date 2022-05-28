using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using Better_Limited_Project.Sales.OrderPlacing.Entity;

namespace Better_Limited_Project.Sales.OrderPlacing
{
    public partial class SalesOrderDetailsForm : Form
    {
        private readonly SalesOrder _salesOrder;

        public SalesOrderDetailsForm(SalesOrder salesOrder)
        {
            _salesOrder = salesOrder;
            InitializeComponent();
            Shown += (_, _) => FillFields();
        }
        
        private void OnFormShown(object sender, System.EventArgs e)
        {
            foreach (var salesOrderProduct in _salesOrder.SalesOrderProducts)
            {
                dgvProducts.Rows.Add(salesOrderProduct.Product.Name,
                    salesOrderProduct.IsDeposit ? "Yes" : "No",
                    salesOrderProduct.Product.Category.Name,
                    salesOrderProduct.Price.ToString("C", new CultureInfo("zh-HK")),
                    salesOrderProduct.Quantity,
                    (salesOrderProduct.Price * salesOrderProduct.Quantity).ToString("C", new CultureInfo("zh-HK")));
            }
        }

        private void FillFields()
        {
            txtSalesOrderID.Text = _salesOrder.Id;
            txtAmtDue.Text = _salesOrder.GetTotalPrice().ToString("C", new CultureInfo("zh-HK"));
            txtAmtPaid.Text = _salesOrder.Payment == null
                ? "-"
                : _salesOrder.Payment.Amount.ToString("C", new CultureInfo("zh-HK"));
            if (_salesOrder.Customer != null)
            {
                txtCustName.Text = _salesOrder.Customer.Name;
                txtCustPhoneNumber.Text = _salesOrder.Customer.Phone;
                txtCustEmail.Text = _salesOrder.Customer.Email;
                // TODO set need delivery, installation
                txtAddress1.Text = _salesOrder.Customer.Address.Address1;
                txtAddress2.Text = _salesOrder.Customer.Address.Address2;
            }

            if (IsPaymentCompleted())
            {
                btnSettleIncompletePayment.Enabled = false;
                btnSettleIncompletePayment.BackColor = Color.Gray;
            }
        }

        private bool IsPaymentCompleted()
        {
            return _salesOrder.Payment != null 
                   && _salesOrder.Payment.Amount == _salesOrder.GetTotalPrice();
        }

    }
}