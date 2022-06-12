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
            StartPosition = FormStartPosition.CenterScreen;
            _stock = selectedProductStock;
            InitializeComponent();
        }

        private void OnShown(object sender, EventArgs e)
        {
            pbImage.SizeMode = PictureBoxSizeMode.Zoom;
            RefreshProductInfo();
            if (!ProductPermissionManager.CanCurrentStaffEditSellingPrice())
                btnUpdateProductInfo.Visible = false;
            if (!ProductPermissionManager.CanEditAllInformation())
            {
                btnEditDescription.Visible = false;
                btnUpdateImage.Visible = false;
            }
            if (!ProductPermissionManager.CanCurrentStaffRemoveProduct()
            || _stock.Product.IsInAnyReorderRequest()
            || _stock.Product.IsInAnyRestockRequest())
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
            IUpdateProductForm form = ProductPermissionManager.CanEditAllInformation()
                ? new UpdateProductAdminForm(_stock)
                : new UpdateProductForm(_stock);
            form.ProductUpdated += (_, _) => RefreshProductInfo();
            form.ProductUpdated += (_, _) => ProductUpdated?.Invoke(this, e);
            form.ShowForm();
        }

        private void btnRemoveProduct_Click(object sender, EventArgs e)
        {
            if (_stock.Product.IsBelongsToAnyIncompleteSalesOrder())
            {
                MessageBox.Show(ProductUtilityStringResources.cant_remove_product_message);
                return;
            }

            var result = _stock.Product.IsInAnySalesOrder()
                ? MessageBox.Show(ProductUtilityStringResources.cant_completely_remove_product_warning,
                    ProductUtilityStringResources.remove_product_confirm_dialog, MessageBoxButtons.OKCancel)
                : MessageBox.Show(ProductUtilityStringResources.ask_confirm_remove_product,
                    ProductUtilityStringResources.remove_product_confirm_dialog, MessageBoxButtons.OKCancel);
            if (result is not DialogResult.OK)
                return;

            _stock.Product.Remove();
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