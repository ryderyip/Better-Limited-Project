using System;
using System.Globalization;
using System.Windows.Forms;
using Better_Limited_Project.ProductUtility.Entity;
using Better_Limited_Project.ProductUtility.ProductList.PermissionManagement;

namespace Better_Limited_Project.ProductUtility.ProductList.Forms
{
    public partial class UpdateProductForm : Form, IUpdateProductForm
    {
        private readonly IStock _productStock;
        public event EventHandler? ProductUpdated;

        public void ShowForm()
        {
            ShowDialog();
        }

        public UpdateProductForm(IStock productStock)
        {
            _productStock = productStock;
            StartPosition = FormStartPosition.CenterScreen;
            
            InitializeComponent();
        }

        private void OnFormShown(object sender, EventArgs e)
        {
            nudNewSellingPirce.Maximum = Product.MaximumPrice;
            nudNewSellingPirce.DecimalPlaces = 2;
            nudNewSellingPirce.ThousandsSeparator = true;

            nudNewReorderLevel.Maximum = Product.MaximumReorderLevel;
            nudNewReorderLevel.DecimalPlaces = 0;
            nudNewReorderLevel.Increment = 1;
            
            nudNewStockLevel.Maximum = Product.MaximumReorderLevel;
            nudNewStockLevel.DecimalPlaces = 0;
            nudNewStockLevel.Increment = 1;

            if (!ProductPermissionManager.CanCurrentStaffEditPhasingOut())
                DisablePhasingOutEdit();

            FillFields();
        }

        private void FillFields()
        {
            nudNewStockLevel.Value = _productStock.Quantity;
            tbStockLevel.Text = _productStock.Quantity.ToString();
            var product = _productStock.Product;
            txtName.Text = product.Name;
            

            if (_productStock is RetailStoreStock stock)
            {
                txtSellingPrice.Text = stock.SellingPrice.ToString("C", new CultureInfo("zh-HK"));
                nudNewSellingPirce.Value = stock.SellingPrice;
            }
            else
                HideSellingPrice();

            txtOriginalPrice.Text = product.OriginalPrice.ToString("C", new CultureInfo("zh-HK"));
            txtPhasingOut.Text = product.IsPhasingOut ? "Yes" : "No";
            txtReorderLevel.Text = _productStock.RestockLevel.ToString();
            nudNewReorderLevel.Value = _productStock.RestockLevel;
            if (product.IsPhasingOut)
                rbPhasingOutOn.Checked = true;
            else
                rbPhasingOutOff.Checked = true;
        }

        private void btnUpdateInfo_Click(object sender, EventArgs e)
        {
            decimal newSellingPrice = nudNewSellingPirce.Value;
            int newReorderLevel = (int) nudNewReorderLevel.Value;
            int newStockLevel = (int) nudNewStockLevel.Value;
            bool phasingOut = rbPhasingOutOn.Checked;

            if (_productStock is RetailStoreStock retailStoreStock)
                retailStoreStock.SellingPrice = newSellingPrice;
            _productStock.RestockLevel = newReorderLevel;
            _productStock.Product.IsPhasingOut = phasingOut;
            _productStock.Quantity = newStockLevel;
            _productStock.Save();
            _productStock.Product.Save();
            NewProductStockCreator.CreateEmptyStockForNewProduct(_productStock.Product);

            MessageBox.Show(ProductList.productAndStockUpdated);
            
            ProductUpdated?.Invoke(this, EventArgs.Empty);
            Close();
        }

        private void HideSellingPrice()
        {
            txtSellingPrice.Visible = false;
            lblSellingPrice.Visible = false;
            lblNewSellingPrice.Visible = false;
            nudNewSellingPirce.Visible = false;
        }
        
        private void DisablePhasingOutEdit()
        {
            rbPhasingOutOn.Enabled = false;
            rbPhasingOutOff.Enabled = false;
        }
    }
}