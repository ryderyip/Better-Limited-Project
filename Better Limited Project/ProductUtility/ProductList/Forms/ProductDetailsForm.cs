using System;
using System.Globalization;
using System.Windows.Forms;
using Better_Limited_Project.Admin.PermissionManagement;
using Better_Limited_Project.ProductUtility.Entity;

namespace Better_Limited_Project.ProductUtility.ProductList.Forms
{
    public partial class ProductDetailsForm : Form
    {
        private readonly string _productId;
        private readonly string _workplaceId;
        public delegate void UpdateProductInfoClickedEventHandler(object sender, EventArgs e);

        public event UpdateProductInfoClickedEventHandler UpdateProductInfoClicked;
        private ProductQuantity _productQuantity;
        private readonly ProductUpdatePermission _updatePermission;

        public ProductDetailsForm(string productId, string workplaceId)
        {
            _productId = productId;
            _workplaceId = workplaceId;
            _updatePermission = ProductUpdatePermissionManager.GetCurrentStaffPermission();
            InitializeComponent();
        }

        private void OnShown(object sender, EventArgs e)
        {
            RefreshProductInfo();
            if (_updatePermission is ProductUpdatePermission.None)
                btnUpdateProductInfo.Visible = false;
        }
        
        private void SetAllFields()
        {
            var product = _productQuantity.Product;
            lblProductName.Text = product.Name;
            tbOriginalPrice.Text = product.OriginalPrice.ToString("C", new CultureInfo("zh-HK"));

            if (product.SellingPrice == decimal.Zero)
                HideSellingPrice();
            else
                tbSellingPrice.Text = product.SellingPrice.ToString("C", new CultureInfo("zh-HK"));
            
            tbPhasingOut.Text = product.IsPhasingOut ? "Yes" : "No";
            tbQuantity.Text = _productQuantity.Quantity.ToString();
            // TODO Display reorder level
            tbDescription.Text = product.Description;

            var supplier = product.Supplier!;
            tbSupplierName.Text = supplier.Name;
            tbSupplierPhone.Text = supplier.Phone;
            tbSupplierEmail.Text = supplier.Email;
            // TODO Display supplier address
        }

        private void HideSellingPrice()
        {
            tbSellingPrice.Visible = false;
            lblSellingPrice.Visible = false;
        }

        public void RefreshProductInfo()
        {
            _productQuantity = ProductRepository.GetProductById(_productId)
                .GetStockOfRetailStoreOrWarehouse(_workplaceId);
            SetAllFields();
        }
        
        private void btnUpdateProductInfo_Click(object sender, EventArgs e)
        {
            UpdateProductInfoClicked?.Invoke(this, e);
        }
    }
}