using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using Better_Limited_Project.ProductUtility.Entity;
using Better_Limited_Project.Sales.OrderPlacing.Controller;
using Better_Limited_Project.Sales.OrderPlacing.Entity;
using Better_Limited_Project.Tools;

namespace Better_Limited_Project.Sales.OrderPlacing.UI
{
    public partial class ConfirmPlacingOrderForm : Form
    {
        private readonly SalesOrder _order;
        private readonly List<SalesOrderProduct> _salesOrderProduct;

        public ConfirmPlacingOrderForm(SalesOrder order, List<SalesOrderProduct> salesOrderProduct)
        {
            _order = order;
            _salesOrderProduct = salesOrderProduct;
            Shown += (_, _) => FillFields();
            InitializeComponent();
        }

        public event EventHandler? OrderConfirmed;

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

            var calculator = new SalesOrderCalculator(_salesOrderProduct);
            var amountDue = calculator.GetNonDepositAmount() + calculator.GetDepositAmount();
            var priceToPayWhenStockReplenished = calculator.GetTotalAmount() - amountDue;
            tbPriceToPayWhenStockReplenished.Text =
                priceToPayWhenStockReplenished.ToString("C", new CultureInfo("zh-HK"));
            tbAmountDue.Text = amountDue.ToString("C", new CultureInfo("zh-HK"));

            if (calculator.GetDepositAmount() == 0)
                panDepositPrice.Visible = false;

            PopulateProductDgv();
        }

        private void PopulateProductDgv()
        {
            foreach (var salesOrderProduct in _salesOrderProduct.Where(sop => !sop.IsOutOfStock))
            {
                var subtotal = salesOrderProduct.Price * salesOrderProduct.Quantity;
                dgvProducts.Rows.Add(salesOrderProduct.GetProduct().Name,
                    salesOrderProduct.Price.ToString("C", new CultureInfo("zh-HK")),
                    salesOrderProduct.Quantity,
                    subtotal.ToString("C", new CultureInfo("zh-HK")));
            }

            foreach (var salesOrderProduct in _salesOrderProduct.Where(sop => sop.IsOutOfStock))
            {
                var depositAmount = salesOrderProduct.Price * Product.DepositPricePercentage;
                var subtotal = depositAmount * salesOrderProduct.Quantity;
                var rowIndex = dgvProducts.Rows.Add(salesOrderProduct.GetProduct().Name,
                    depositAmount.ToString("C", new CultureInfo("zh-HK")) + " (20%)",
                    salesOrderProduct.Quantity,
                    subtotal.ToString("C", new CultureInfo("zh-HK")));
                dgvProducts.Rows[rowIndex].DefaultCellStyle.BackColor = FormColors.DgvRowAttention;
            }
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            OrderConfirmed?.Invoke(this, EventArgs.Empty);
            Close();
        }
    }
}