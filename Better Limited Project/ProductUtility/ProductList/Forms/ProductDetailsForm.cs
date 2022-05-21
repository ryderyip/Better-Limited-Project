using System;
using System.Data;
using System.Globalization;
using System.Windows.Forms;
using Better_Limited_Project.Admin.PermissionManagement;
using Better_Limited_Project.DatabaseUtility;
using Better_Limited_Project.ProductUtility.Entity;
using Better_Limited_Project.SettingsUtility;
using MySql.Data.MySqlClient;

namespace Better_Limited_Project.ProductUtility.ProductList
{
    public partial class ProductDetailsForm : Form
    {
        public delegate void UpdateProductInfoClickedEventHandler(object sender, EventArgs e);

        public event UpdateProductInfoClickedEventHandler UpdateProductInfoClicked;
        private Product _product;
        private int _quantity;
        private readonly ProductUpdatePermission _updatePermission;

        public ProductDetailsForm(string productId)
        {
            var productQuantity = GetProductQuantity(productId);
            _product = productQuantity.Product;
            _quantity = productQuantity.Quantity;
            _updatePermission = ProductUpdatePermissionManager.GetCurrentStaffPermission();
            
            InitializeComponent();
        }

        private ProductQuantity GetProductQuantity(string productId)
        {
            var retailStoreId = UserSettings.GetSettings().Workplace?.Id;
            var command = new MySqlCommand(
                @"select p.id as product_id, p.name as name, price as original_price, 
                       description, is_phasing_out, rss.quantity, 
                       rss.selling_price, pc.id as category, 
                       s.name as supplier_name, s.phone as supplier_phone, 
                       s.email as supplier_email, rs.name as retail_store_name
                        from retail_store_stock rss
                        INNER JOIN product p on rss.product_id = p.id
                        INNER JOIN product_category pc on p.category_id = pc.id
                        INNER JOIN supplier s on p.supplier_id = s.id
                        INNER JOIN retail_store rs on rss.retail_store_id = rs.id
                        WHERE rs.id = @retailStoreId
                        AND p.id = @productId;");
            command.Parameters.AddWithValue("@retailStoreId", retailStoreId);
            command.Parameters.AddWithValue("@productId", productId);
            
            var dataTable = DataTableRepository.RetrieveDataTable(command);
            return ConvertToProductQuantity(dataTable.Rows[0]);
        }

        private ProductQuantity ConvertToProductQuantity(DataRow row)
        {
            string supplierName = row.Field<string>("supplier_name");
            string supplierPhone = row.Field<string>("supplier_phone");
            string supplierEmail = row.Field<string>("supplier_email");
            var product = new Product
            {
                Id = row.Field<string>("product_id"),
                Name = row.Field<string>("name"),
                OriginalPrice = row.Field<decimal>("original_price"),
                SellingPrice = row.Field<decimal>("selling_price"),
                Description = row.Field<string>("description"),
                Category = CategoryRepository.GetById(row.Field<int>("category").ToString()),
                IsPhasingOut = row.Field<bool>("is_phasing_out"),
                Supplier = new Supplier(supplierName, supplierPhone, supplierEmail)
            };
            int quantity = row.Field<int>("quantity");
            return new ProductQuantity(product, quantity);
        }
      
        private void OnShown(object sender, EventArgs e)
        {
            SetAllFields();
            if (_updatePermission is ProductUpdatePermission.None)
                btnUpdateProductInfo.Visible = false;
        }
        
        private void SetAllFields()
        {
            lblProductName.Text = _product.Name;
            tbOriginalPrice.Text = _product.OriginalPrice.ToString("C", new CultureInfo("zh-HK"));
            tbSellingPrice.Text = _product.SellingPrice.ToString("C", new CultureInfo("zh-HK"));
            tbPhasingOut.Text = _product.IsPhasingOut ? "Yes" : "No";
            tbQuantity.Text = _quantity.ToString();
            // TODO Display reorder level
            tbDescription.Text = _product.Description;

            var supplier = _product.Supplier!;
            tbSupplierName.Text = supplier.Name;
            tbSupplierPhone.Text = supplier.Phone;
            tbSupplierEmail.Text = supplier.Email;
            // TODO Display supplier address
        }
        
        public void RefreshProductInfo(string productId)
        {
            var productQuantity = GetProductQuantity(productId);
            _product = productQuantity.Product;
            _quantity = productQuantity.Quantity;
            SetAllFields();
        }


        private void btnUpdateProductInfo_Click(object sender, EventArgs e)
        {
            UpdateProductInfoClicked?.Invoke(this, e);
        }
    }
}