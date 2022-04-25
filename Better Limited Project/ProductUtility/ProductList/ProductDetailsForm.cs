using System;
using System.Globalization;
using System.Windows.Forms;
using Better_Limited_Project.ProductUtility.Entity;

namespace Better_Limited_Project.ProductUtility.ProductList
{
    public partial class ProductDetailsForm : Form
    {
        private readonly Product _product;
        private readonly int _quantity;

        public ProductDetailsForm(ProductQuantity productQuantity)
        {
            _product = productQuantity.Product;
            _quantity = productQuantity.Quantity;
            InitializeComponent();
            Shown += OnShown;
        }

        private void OnShown(object sender, EventArgs e)
        {
            lblProductName.Text = _product.Name;
            tbOriginalPrice.Text = _product.OriginalPrice.ToString("C", new CultureInfo("zh-HK"));
            tbSellingPrice.Text = _product.SellingPrice.ToString("C", new CultureInfo("zh-HK"));
            tbPhasingOut.Text = _product.IsPhasingOut ? "Yes" : "No";
            tbQuantity.Text = _quantity.ToString();
            // TODO Display reorder level
            tbDescription.Text = _product.Description;

            var supplier = _product.Supplier;
            tbSupplierName.Text = supplier.Name;
            tbSupplierPhone.Text = supplier.Phone;
            tbSupplierEmail.Text = supplier.Email;
            // TODO Display supplier address
        }
    }
}