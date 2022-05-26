using System;
using System.Globalization;
using System.Windows.Forms;
using Better_Limited_Project.CustomerRecord;
using Better_Limited_Project.Login;
using Better_Limited_Project.ProductUtility.Entity;
using Better_Limited_Project.Sales.PaymentUtility;
using Better_Limited_Project.SettingsUtility;
using Better_Limited_Project.StaffUtility.StaffEntity;

namespace Better_Limited_Project.Sales.OrderPlacing
{
    public partial class ConfirmPlacingOrderForm : Form
    {
        private readonly SalesOrder _order;

        public ConfirmPlacingOrderForm(Cart cart)
        {
            var staff = StaffRepository.GetStaff(LoginSession.GetSession().StaffId);
            var retailStore = RetailStoreRepository.GetRetailStoreById(UserSettings.GetSettings().Workplace!.Id);
            _order = new SalesOrder(staff, retailStore, cart);
            Shown += (_, _) => FillFields();
            InitializeComponent();
        }

        public ConfirmPlacingOrderForm(Cart cart, CustomerEntity customer)
        {
            var staff = StaffRepository.GetStaff(LoginSession.GetSession().StaffId);
            var retailStore = RetailStoreRepository.GetRetailStoreById(UserSettings.GetSettings().Workplace!.Id);
            _order = new SalesOrder(staff, retailStore, cart, customer);
            Shown += (_, _) => FillFields();
            InitializeComponent();
        }

        /*private Payment GeneratePayment()
        {
            return _order.Cart.HasOutOfStockItem()
                ? new Payment(_order.Cart.GetTotalDepositPrice(),
                    _paymentMethod,
                    DateTime.Now,
                    true)
                : new Payment(_order.Cart.GetTotalPrice(),
                    _paymentMethod,
                    DateTime.Now);
        }*/

        private void FillFields()
        {
            if (_order.CustomerEntity != null)
            {
                var customer = _order.CustomerEntity.Customer;
                txtCustName.Text = customer.Name;
                txtCustPhoneNumber.Text = customer.Phone;
                txtCustEmailAddress.Text = customer.Email ?? "-";
                txtAddress1.Text = customer.AddressEntity.Address.Address1;
                txtAddress2.Text = customer.AddressEntity.Address.Address2;
            }

            txtTotalPrice.Text = _order.Cart.HasNeedDepositItem()
                ? _order.Cart.GetTotalDepositPrice().ToString("C", new CultureInfo("zh-HK"))
                : _order.Cart.GetTotalPrice().ToString("C", new CultureInfo("zh-HK"));
            SetProductDgv();
            PopulateProductDgv();
        }

        private void SetProductDgv()
        {
            dgvProducts.Columns.Add("name", "Name");
            dgvProducts.Columns.Add("price", "Price");
            dgvProducts.Columns.Add("quantity", "Qty");
            dgvProducts.Columns.Add("subtotal", "Subtotal");
            dgvProducts.Columns.Add("is_deposit", "Is Deposit");
        }

        private void PopulateProductDgv()
        {
            foreach (var cartItem in _order.Cart.GetCartItems())
                dgvProducts.Rows.Add(cartItem.Product.Name,
                    cartItem.Price.ToString("C", new CultureInfo("zh-HK")),
                    cartItem.Quantity,
                    (cartItem.Quantity * cartItem.Price).ToString("C", new CultureInfo("zh-HK")),
                    cartItem.IsDeposit ? "Yes" : "No");
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            var form = new PaymentMethodSelectionForm(_order);
            form.StartPosition = FormStartPosition.CenterScreen;
            form.ShowDialog();
        }
    }
}