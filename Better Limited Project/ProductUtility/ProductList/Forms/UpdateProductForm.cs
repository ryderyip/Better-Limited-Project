using System;
using System.Globalization;
using System.Windows.Forms;
using Better_Limited_Project.Login;
using Better_Limited_Project.PermissionManagement.Permissions;
using Better_Limited_Project.PermissionManagement.Repository;
using Better_Limited_Project.ProductUtility.Entity;

namespace Better_Limited_Project.ProductUtility.ProductList.Forms
{
    public partial class UpdateProductForm : Form, IUpdateProductForm
    {
        private readonly IStock _productStock;

        public UpdateProductForm(IStock productStock)
        {
            _productStock = productStock;
            StartPosition = FormStartPosition.CenterScreen;

            InitializeComponent();
        }

        public event EventHandler? ProductUpdated;

        public void ShowForm()
        {
            ShowDialog();
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

            var currentStaffTitle = LoginSession.GetSession().CurrentStaff.Title;
            rbPhasingOutOn.Enabled = rbPhasingOutOff.Enabled = PermissionRepository
                .FindBy(Permission.CanStaffEditPhasingOut).PermissionMap(currentStaffTitle);

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
            {
                HideSellingPrice();
            }

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
            var newSellingPrice = nudNewSellingPirce.Value;
            var newReorderLevel = (int) nudNewReorderLevel.Value;
            var newStockLevel = (int) nudNewStockLevel.Value;
            var phasingOut = rbPhasingOutOn.Checked;

            if (_productStock is RetailStoreStock retailStoreStock)
                retailStoreStock.SellingPrice = newSellingPrice;
            _productStock.RestockLevel = newReorderLevel;
            _productStock.Product.IsPhasingOut = phasingOut;
            _productStock.Quantity = newStockLevel;
            _productStock.Save();
            _productStock.Product.Save();

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
    }
}