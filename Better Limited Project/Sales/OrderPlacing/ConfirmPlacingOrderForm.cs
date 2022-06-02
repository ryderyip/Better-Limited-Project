using System;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using Better_Limited_Project.ProductUtility.Entity;
using Better_Limited_Project.Sales.OrderPlacing.Entity;
using Color = System.Drawing.Color;

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

            decimal amountDue = _order.GetInStockItemPrice() + _order.GetDepositAmount();
            decimal priceToPayWhenStockReplenished = _order.GetTotalAmount() - amountDue;
            tbPriceToPayWhenStockReplenished.Text = priceToPayWhenStockReplenished.ToString("C", new CultureInfo("zh-HK"));
            tbAmountDue.Text = amountDue.ToString("C", new CultureInfo("zh-HK"));

            if (_order.GetDepositAmount() == 0)
                panDepositPrice.Visible = false;

            PopulateProductDgv();
        }

        private void PopulateProductDgv()
        {
            foreach (var salesOrderProduct in _order.SalesOrderProducts.Where(sop => !sop.IsOutOfStock))
            {
                decimal subtotal = salesOrderProduct.Price * salesOrderProduct.Quantity;
                dgvProducts.Rows.Add(salesOrderProduct.GetProduct().Name,
                    salesOrderProduct.Price.ToString("C", new CultureInfo("zh-HK")),
                    salesOrderProduct.Quantity,
                    subtotal.ToString("C", new CultureInfo("zh-HK")));
            }

            foreach (var salesOrderProduct in _order.SalesOrderProducts.Where(sop => sop.IsOutOfStock))
            {
                decimal depositAmount = salesOrderProduct.Price * Product.DepositPricePercentage;
                decimal subtotal = depositAmount * salesOrderProduct.Quantity;
                int rowIndex = dgvProducts.Rows.Add(salesOrderProduct.GetProduct().Name,
                    depositAmount.ToString("C", new CultureInfo("zh-HK")) + " (20%)",
                    salesOrderProduct.Quantity,
                    subtotal.ToString("C", new CultureInfo("zh-HK")));
                dgvProducts.Rows[rowIndex].DefaultCellStyle.BackColor = Color.SandyBrown;
            }
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            OrderConfirmed?.Invoke(this, EventArgs.Empty);
            Close();
        }
    }
}