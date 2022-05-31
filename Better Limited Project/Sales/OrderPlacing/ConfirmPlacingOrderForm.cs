using System;
using System.Globalization;
using System.Windows.Forms;
using Better_Limited_Project.ProductUtility.Entity;
using Better_Limited_Project.Sales.OrderPlacing.Entity;

namespace Better_Limited_Project.Sales.OrderPlacing
{
    public partial class ConfirmPlacingOrderForm : Form
    {
        public event EventHandler? OrderConfirmed;
        private readonly SalesOrder _order;

        public ConfirmPlacingOrderForm(SalesOrder salesOrder)
        {
            _order = salesOrder;
            Shown += (_, _) => FillFields();
            InitializeComponent();
        }

        private void FillFields()
        {
            if (_order.Customer != null)
            {
                var customer = _order.Customer;
                txtCustName.Text = customer.Name;
                txtCustPhoneNumber.Text = customer.Phone;
                txtCustEmailAddress.Text = customer.Email ?? "-";
                txtAddress1.Text = customer.Address.Address1;
                txtAddress2.Text = customer.Address.Address2;
            }

            txtTotalPrice.Text = _order.GetDepositPrice().ToString("C", new CultureInfo("zh-HK"));

            PopulateProductDgv();
        }

        private void PopulateProductDgv()
        {
            foreach (var salesOrderProduct in _order.SalesOrderProducts)
            {
                decimal subtotal = salesOrderProduct.IsDeposit
                    ? salesOrderProduct.Price * salesOrderProduct.Quantity * Product.DepositPricePercentage
                    : salesOrderProduct.Price * salesOrderProduct.Quantity;
                dgvProducts.Rows.Add(salesOrderProduct.Product.Name,
                    salesOrderProduct.Price.ToString("C", new CultureInfo("zh-HK")),
                    salesOrderProduct.Quantity,
                    salesOrderProduct.IsDeposit ? "Yes" : "No",
                    subtotal.ToString(
                        "C", new CultureInfo("zh-HK")));
            }
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            OrderConfirmed?.Invoke(this, EventArgs.Empty);
            Close();
        }
    }
}