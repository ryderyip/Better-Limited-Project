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
        public event EventHandler? ProductUpdated;
        private IStock _stock;

        public ProductDetailsForm(IStock selectedProductStock)
        {
            _stock = selectedProductStock;
            InitializeComponent();
        }

        private void OnShown(object sender, EventArgs e)
        {
            RefreshProductInfo();
            if (ProductInfoEditPermissionManager.GetCurrentStaffPermission()
                is ProductInfoEditPermission.None)
                btnUpdateProductInfo.Visible = false;
            if (ProductInfoEditPermissionManager.GetCurrentStaffPermission()
                is not ProductInfoEditPermission.AllowUpdateAll)
                btnEditDescription.Visible = false;

        }

        private void FillAllFields()
        {
            var product = _stock.Product;
            lblProductName.Text = product.Name;
            tbOriginalPrice.Text = product.OriginalPrice.ToString("C", new CultureInfo("zh-HK"));

            if (_stock is RetailStoreStock stock)
                tbSellingPrice.Text = stock.SellingPrice is decimal.Zero
                    ? "-"
                    : stock.SellingPrice.ToString("C", new CultureInfo("zh-HK"));
            else
                HideSellingPrice();

            tbPhasingOut.Text = product.IsPhasingOut ? "Yes" : "No";
            tbQuantity.Text = _stock.Quantity.ToString();
            tbReorderLevel.Text = _stock.RestockLevel.ToString();
            tbDescription.Text = product.Description;

            var supplier = product.SupplierEntity.Supplier;
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

        private void RefreshProductInfo()
        {
            _stock = StockRepository.GetStocks(_stock.Workplace.Id)
                .First(s => s.Product.Id == _stock.Product.Id);
            FillAllFields();
        }

        private void btnUpdateProductInfo_Click(object sender, EventArgs e)
        {
            var permission = ProductInfoEditPermissionManager.GetCurrentStaffPermission();
            if (permission is ProductInfoEditPermission.None)
                return;

            IUpdateProductForm form = permission is ProductInfoEditPermission.AllowUpdateAll
                ? new UpdateProductAdminForm(_stock)
                : new UpdateProductForm(_stock);
            form.ProductUpdated += (_, _) => RefreshProductInfo();
            form.ProductUpdated += (_, _) => ProductUpdated?.Invoke(this, e);
            form.ShowForm();
        }

        private void btnRemoveProduct_Click(object sender, EventArgs e)
        {
            ProductRepository.DeleteProduct(_stock.Product);
            ProductUpdated?.Invoke(this, EventArgs.Empty);
            Close();
        }

        private void btnEditDescription_Click(object sender, EventArgs e)
        {
            var form = new ProductDescriptionEditForm(_stock.Product);
            form.StartPosition = FormStartPosition.CenterScreen;
            form.DescriptionUpdated += (_, _) => RefreshProductInfo();
            form.DescriptionUpdated += (_, _) => ProductUpdated?.Invoke(this, e);
            form.ShowDialog();
        }
    }
}