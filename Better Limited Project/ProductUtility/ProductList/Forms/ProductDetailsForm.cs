using System;
using System.Globalization;
using System.Windows.Forms;
using Better_Limited_Project.ProductUtility.Entity;
using Better_Limited_Project.ProductUtility.ProductList.PermissionManagement;
using Better_Limited_Project.Tools;

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
            pbImage.SizeMode = PictureBoxSizeMode.Zoom;
            RefreshProductInfo();
            if (!ProductPermissionManager.CanCurrentStaffEditSellingPrice())
                btnUpdateProductInfo.Visible = false;
            if (!ProductPermissionManager.CanCurrentStaffEditProductOriginalInformation())
                btnEditDescription.Visible = false;
            if (!ProductPermissionManager.CanCurrentStaffRemoveProduct())
                btnRemoveProduct.Visible = false;
        }

        private void FillAllFields()
        {
            var product = _stock.Product;
            tbName.Text = product.Name;
            tbOriginalPrice.Text = product.OriginalPrice.ToString("C", new CultureInfo("zh-HK"));
            pbImage.Image = product.GetImage();

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

            var supplier = product.Supplier;
            tbSupplierName.Text = supplier.Name;
            tbSupplierPhone.Text = supplier.Phone;
            tbSupplierEmail.Text = supplier.Email;
            tbCategory.Text = product.Category.Name;
        }

        private void HideSellingPrice()
        {
            tbSellingPrice.Visible = false;
            lblSellingPrice.Visible = false;
        }

        private void RefreshProductInfo()
        {
            _stock = _stock.Workplace.GetProductStock(_stock.Product.Id);
            FillAllFields();
        }

        private void btnUpdateProductInfo_Click(object sender, EventArgs e)
        {
            IUpdateProductForm form = ProductPermissionManager.CanCurrentStaffEditProductOriginalInformation()
                ? new UpdateProductAdminForm(_stock)
                : new UpdateProductForm(_stock);
            form.ProductUpdated += (_, _) => RefreshProductInfo();
            form.ProductUpdated += (_, _) => ProductUpdated?.Invoke(this, e);
            form.ShowForm();
        }

        private void btnRemoveProduct_Click(object sender, EventArgs e)
        {
            // TODO will only remove stocks, product will be kept as record
            _stock.Remove();
            ProductUpdated?.Invoke(this, EventArgs.Empty);
            Close();
        }

        private void btnEditDescription_Click(object sender, EventArgs e)
        {
            var form = new ProductDescriptionEditForm(_stock.Product);
            form.StartPosition = FormStartPosition.CenterScreen;
            form.DescriptionUpdated += (_, _) => RefreshProductInfo();
            form.ShowDialog();
        }

        private void btnUpdateImage_Click(object sender, EventArgs e)
        {
            var form = new UploadImageForm(_stock.Product.GetImage());
            form.StartPosition = FormStartPosition.CenterScreen;
            form.Uploaded += (_, image) =>
            {
                if (image == null)
                    return;
                _stock.Product.SetImage(image);
                RefreshProductInfo();
            };
            form.ShowDialog();
        }
    }
}