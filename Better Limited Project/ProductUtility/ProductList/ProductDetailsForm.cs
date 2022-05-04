using System;
using System.Data;
using System.Globalization;
using System.Windows.Forms;
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

        public ProductDetailsForm(string productId)
        {
            var productQuantity = GetProductQuantity(productId);
            _product = productQuantity.Product;
            _quantity = productQuantity.Quantity;
            InitializeComponent();
        }

        private ProductQuantity GetProductQuantity(string productId)
        {
            var retailStoreId = UserSettings.GetSettings().Workplace?.Id;
            using var conn = Database.GetConnection();
            conn.Open();
            var dataTable = new DataTable();
            var command = new MySqlCommand(
                @"select p.id as product_id,
                       p.name as name, 
                       price as original_price, 
                       description, 
                       is_phasing_out, 
                       rss.quantity, 
                       rss.selling_price, 
                       pc.name as category, 
                       s.name as supplier_name, 
                       s.phone as supplier_phone, 
                       s.email as supplier_email,
                       rs.name as retail_store_name
                        from retail_store_stock rss
                        INNER JOIN product p on rss.product_id = p.id
                        INNER JOIN product_category pc on p.category_id = pc.id
                        INNER JOIN supplier s on p.supplier_id = s.id
                        INNER JOIN retail_store rs on rss.retail_store_id = rs.id
                        WHERE rs.id = @retailStoreId
                        AND p.id = @productId;", conn);
            command.Parameters.AddWithValue("@retailStoreId", retailStoreId);
            command.Parameters.AddWithValue("@productId", productId);
            var dataReader = command.ExecuteReader();
            dataTable.Load(dataReader);
            dataReader.Close();

            return ConvertToProductQuantity(dataTable.Rows[0]);
        }

        private ProductQuantity ConvertToProductQuantity(DataRow row)
        {
            var product = new Product
            {
                Id = row.Field<string>("product_id"),
                Name = row.Field<string>("name"),
                OriginalPrice = row.Field<decimal>("original_price"),
                SellingPrice = row.Field<decimal>("selling_price"),
                Description = row.Field<string>("description"),
                Category = row.Field<string>("category"),
                IsPhasingOut = row.Field<bool>("is_phasing_out"),
                Supplier = new Supplier
                {
                    Name = row.Field<string>("supplier_name"),
                    Phone = row.Field<string>("supplier_phone"),
                    Email = row.Field<string>("supplier_email")
                }
            };
            int quantity = row.Field<int>("quantity");
            return new ProductQuantity(product, quantity);
        }
      
        private void OnShown(object sender, EventArgs e)
        {
            SetAllFields();
        }
        
        public void RefreshProductInfo(string productId)
        {
            var productQuantity = GetProductQuantity(productId);
            _product = productQuantity.Product;
            _quantity = productQuantity.Quantity;
            SetAllFields();
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

            var supplier = _product.Supplier;
            tbSupplierName.Text = supplier.Name;
            tbSupplierPhone.Text = supplier.Phone;
            tbSupplierEmail.Text = supplier.Email;
            // TODO Display supplier address
        }

        private void btnUpdateSellingPrice_Click(object sender, EventArgs e)
        {
            UpdateProductInfoClicked?.Invoke(this, e);
        }
    }
}