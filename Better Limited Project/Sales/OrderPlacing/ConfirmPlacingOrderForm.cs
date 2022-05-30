using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using Better_Limited_Project.CustomerRecord;
using Better_Limited_Project.Login;
using Better_Limited_Project.ProductUtility.Entity;
using Better_Limited_Project.ProductUtility.Repository;
using Better_Limited_Project.Sales.OrderPlacing.Entity;
using Better_Limited_Project.Sales.PaymentUtility;
using Better_Limited_Project.SettingsUtility;
using Better_Limited_Project.StaffUtility.StaffEntity;

namespace Better_Limited_Project.Sales.OrderPlacing
{
    public partial class ConfirmPlacingOrderForm : Form
    {
        public event EventHandler? SalesOrderPlaced;
        private readonly SalesOrder _order;

        public ConfirmPlacingOrderForm(Cart cart, Customer? customer)
        {
            _order = CreateOrder(cart, customer);
            Shown += (_, _) => FillFields();
            InitializeComponent();
        }

        private SalesOrder CreateOrder(Cart cart, Customer? customer)
        {
            var staff = LoginSession.GetSession().CurrentStaff;
            var retailStore = new RetailStoreRepository().GetRetailStoreById(UserSettings.GetSettings().Workplace!.Id);

            return new SalesOrder
            {
                Staff = staff, RetailStore = retailStore, Customer = customer,
                SalesOrderProducts = new List<SalesOrderProduct>(cart.GetCartItems().ToList()
                    .ConvertAll(cartItem => new SalesOrderProduct
                    {
                        Price = cartItem.Price, Product = cartItem.Product,
                        Quantity = cartItem.Quantity, IsDeposit = cartItem.IsDeposit
                    }))
            };
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
            var form = new PaymentMethodSelectionForm();
            form.StartPosition = FormStartPosition.CenterScreen;
            form.Selected += (_, method) => { OnPaymentMethodSelected(method); };
            form.ShowDialog();
        }

        private void OnPaymentMethodSelected(PaymentMethod method)
        {
            var form = PaymentFormFactory.Generate(_order.GetDepositPrice(), method);
            form.PaymentCompleted += OnPaymentCompleted;
            form.ShowForm();
        }

        private void OnPaymentCompleted(object sender, Payment payment)
        {
            _order.Payment = payment;
            _order.Save();
            var stocks = StockRepository.GetStocks(UserSettings.GetSettings().Workplace!.Id).ToList();
            foreach (var salesOrderProduct in _order.SalesOrderProducts)
            {
                var stock = stocks.First(stock => stock.Product.Id == salesOrderProduct.Product.Id);
                stock.Quantity -= salesOrderProduct.Quantity;
                if (stock.Quantity < 0)
                    stock.Quantity = 0;
                stock.Update();
            }
            Close();
            SalesOrderPlaced?.Invoke(this, EventArgs.Empty);
        }
    }
}