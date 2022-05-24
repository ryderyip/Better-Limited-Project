using System;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using Better_Limited_Project.ProductUtility.Entity;
using Better_Limited_Project.ProductUtility.ProductList.PermissionManagement;
using Better_Limited_Project.ProductUtility.Repository;

namespace Better_Limited_Project.ProductUtility.ProductList.Forms
{
    public partial class ProductDetailsForm : Form
    {
        private readonly string _productId;
        private readonly string _workplaceId;

        public event EventHandler? UpdateProductInfoClicked;
        public event EventHandler? ProductRemoved;
        private IStock _stock;
        private readonly ProductInfoEditPermission _infoEditPermission;

        public ProductDetailsForm(string productId, string workplaceId)
        {
            _productId = productId;
            _workplaceId = workplaceId;
            _stock = GetStock();
            _infoEditPermission = ProductInfoEditPermissionManager.GetCurrentStaffPermission();
            InitializeComponent();
        }

        private void OnShown(object sender, EventArgs e)
        {
            RefreshProductInfo();
            if (_infoEditPermission is ProductInfoEditPermission.None)
                btnUpdateProductInfo.Visible = false;
        }
        
        private void SetAllFields()
        {
            var product = _stock.Product;
            lblProductName.Text = product.Name;
            tbOriginalPrice.Text = product.OriginalPrice.ToString("C", new CultureInfo("zh-HK"));

            if (_stock is RetailStoreStock stock)
                tbSellingPrice.Text = stock.SellingPrice.ToString("C", new CultureInfo("zh-HK"));
            else
                HideSellingPrice();

            tbPhasingOut.Text = product.IsPhasingOut ? "Yes" : "No";
            tbQuantity.Text = _stock.Quantity.ToString();
            tbReorderLevel.Text = _stock.RestockLevel.ToString();
            tbDescription.Text = product.Description;

            var supplier = product.Supplier;
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
            _stock = GetStock();
            SetAllFields();
        }

        private IStock GetStock()
        {
            return StockRepository.GetStocks(_workplaceId)
                .First(stock => stock.Product.Id == _productId);
        }

        private void btnUpdateProductInfo_Click(object sender, EventArgs e)
        {
            UpdateProductInfoClicked?.Invoke(this, e);
        }

        private void btnRemoveProduct_Click(object sender, EventArgs e)
        {
            ProductRepository.DeleteProduct(_stock.Product);
            ProductRemoved?.Invoke(this, EventArgs.Empty);
            Close();
        }
    }
}