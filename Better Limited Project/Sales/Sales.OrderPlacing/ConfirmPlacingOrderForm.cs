using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows.Forms;
using Better_Limited_Project.ProductUtility.Entity;
using Better_Limited_Project.Sales.Sales.SalesOrder.CustomerRecord;

namespace Better_Limited_Project.Sales.Sales.OrderPlacing
{
    public partial class ConfirmPlacingOrderForm : Form
    {
        public delegate void ButtonClickedEventHandler(object sender, EventArgs e);
        public event ButtonClickedEventHandler? OrderConfirmed;
        private readonly IEnumerable<ProductQuantity> _productQuantities;

        public ConfirmPlacingOrderForm(IEnumerable<ProductQuantity> productQuantities)
        {
            _productQuantities = productQuantities;
            
            Shown += (_, _) => FillFieldsNoCustomerDeliveryInfo();
            InitializeComponent();
        }

        public ConfirmPlacingOrderForm(IEnumerable<ProductQuantity> productQuantities, string customerName)
        {
            var customer = CustomerRepository.GetCustomerByName(customerName);
            _productQuantities = productQuantities;
            Shown += (_, _) => FillFieldsWithCustomerDeliveryInfo(customer, customer.Address!);
            InitializeComponent();
        }

        private void FillFieldsNoCustomerDeliveryInfo()
        {
            txtCustName.Text = "-";
            txtCustPhoneNumber.Text = "-";
            txtCustEmailAddress.Text = "-";
            txtAddress1.Text = "-";
            txtAddress2.Text = "-";
            txtTotalPrice.Text = CalculateTotalPrice().ToString("C", new CultureInfo("zh-HK"));
            SetProductDgv();
            PopulateProductDgv();
        }
        
        private void FillFieldsWithCustomerDeliveryInfo(Customer customer, Address address)
        {
            txtCustName.Text = customer.Name;
            txtCustPhoneNumber.Text = customer.Phone;
            txtCustEmailAddress.Text = customer.Email ?? "-";
            txtAddress1.Text = address.Address1;
            txtAddress2.Text = address.Address2;
            txtTotalPrice.Text = CalculateTotalPrice().ToString("C", new CultureInfo("zh-HK"));
            SetProductDgv();
            PopulateProductDgv();
        }

        private void SetProductDgv()
        {
            dgvProducts.Columns.Add("name", "Name");
            dgvProducts.Columns.Add("price", "Price");
            dgvProducts.Columns.Add("quantity", "Qty");
        }
        
        private void PopulateProductDgv()
        {
            foreach (var productQuantity in _productQuantities)
                dgvProducts.Rows.Add(productQuantity.Product.Name,
                    productQuantity.Product.SellingPrice,
                    productQuantity.Quantity);
        }

        private decimal CalculateTotalPrice()
        {
            decimal total = 0;
            foreach (var productQuantity in _productQuantities)
                total += productQuantity.Product.SellingPrice * productQuantity.Quantity;
            return total;
        }
        
        private void btnPay_Click(object sender, EventArgs e)
        {
            OrderConfirmed?.Invoke(this, EventArgs.Empty);
        }
    }
}
