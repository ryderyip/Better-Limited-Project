using System;
using System.Globalization;
using System.Windows.Forms;
using Better_Limited_Project.ProductUtility.Entity;

namespace Better_Limited_Project.ProductUtility.ProductList.Forms
{
    public partial class UpdateProductAdminForm : Form, IUpdateProductForm
    {
        private readonly IStock _stock;
        public event EventHandler? ProductUpdated;
        
        public UpdateProductAdminForm(IStock stock)
        {
            _stock = stock;
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }
        
        public void ShowForm()
        {
            ShowDialog();
        }
        
        private void btnUpdateInfo_Click(object sender, EventArgs e)
        {
            decimal newSellingPrice = nudNewSellingPirce.Value;
            int newReorderLevel = (int) nudNewReorderLevel.Value;
            int newStockLevel = (int) nudNewStockLevel.Value;
            bool phasingOut = rbPhasingOutOn.Checked;

            if (_stock is RetailStoreStock retailStoreStock)
                retailStoreStock.SellingPrice = newSellingPrice;
            _stock.RestockLevel = newReorderLevel;
            _stock.Product.IsPhasingOut = phasingOut;
            _stock.Quantity = newStockLevel;
            _stock.Update();

            ProductUpdated?.Invoke(this, EventArgs.Empty);
            Close();
        }

        private void UpdateProductAdminForm_Shown(object sender, EventArgs e)
        {
            nudNewSellingPirce.Maximum = Product.MaximumPrice;
            nudNewSellingPirce.DecimalPlaces = 2;
            nudNewSellingPirce.ThousandsSeparator = true;

            nudNewOriginalPrice.Maximum = Product.MaximumPrice;
            nudNewOriginalPrice.DecimalPlaces = 2;
            nudNewOriginalPrice.ThousandsSeparator = true;
            
            nudNewReorderLevel.Maximum = Product.MaximumReorderLevel;
            nudNewReorderLevel.DecimalPlaces = 0;
            nudNewReorderLevel.Increment = 1;
            
            nudNewStockLevel.Maximum = Product.MaximumReorderLevel;
            nudNewStockLevel.DecimalPlaces = 0;
            nudNewStockLevel.Increment = 1;

            FillFields();
        }
        
        private void FillFields()
        {
            nudNewStockLevel.Value = _stock.Quantity;
            tbStockLevel.Text = _stock.Quantity.ToString();
            var product = _stock.Product;
            txtName.Text = product.Name;
            tbNewName.Text = product.Name;

            // TODO deal with this fucking annoying cultureinfo shit
            if (_stock is RetailStoreStock stock)
            {
                txtSellingPrice.Text = stock.SellingPrice.ToString("C", new CultureInfo("zh-HK"));
                nudNewSellingPirce.Value = stock.SellingPrice;
            }
            else
                HideSellingPrice();

            nudNewOriginalPrice.Value = product.OriginalPrice;
            txtOriginalPrice.Text = product.OriginalPrice.ToString("C", new CultureInfo("zh-HK"));
            txtPhasingOut.Text = product.IsPhasingOut ? "Yes" : "No";
            txtReorderLevel.Text = _stock.RestockLevel.ToString();
            nudNewReorderLevel.Value = _stock.RestockLevel;
            if (product.IsPhasingOut)
                rbPhasingOutOn.Checked = true;
            else
                rbPhasingOutOff.Checked = true;
        }
        
        private void HideSellingPrice()
        {
            txtSellingPrice.Visible = false;
            lblSellingPrice.Visible = false;
            lblNewSellingPrice.Visible = false;
            nudNewSellingPirce.Visible = false;
        }
    }
}
