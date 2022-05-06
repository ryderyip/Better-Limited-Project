using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Better_Limited_Project.DatabaseUtility;
using Better_Limited_Project.ProductUtility.Entity;
using Better_Limited_Project.Sales.Sales.SalesOrder.SalesOrderPager;
using Better_Limited_Project.SettingsUtility;
using MySql.Data.MySqlClient;

namespace Better_Limited_Project.Sales.Sales.SalesOrder
{
    public partial class PlaceOrderForm : Form
    {
        private readonly DataTable _productTable;
        private readonly PlaceOrderViewProductsPager _pager;
        private readonly PlaceOrderFormPageFiller _pageFiller;

        public PlaceOrderForm()
        {
            _productTable = GetProductTable();
            _pager = new PlaceOrderViewProductsPager();
            _pageFiller = new PlaceOrderFormPageFiller();
            InitializeComponent();
            PopulatePagerWithProductData();
        }
        
        private DataTable GetProductTable()
        {
            var retailStoreId = UserSettings.GetSettings().Workplace?.Id;
            using var conn = Database.GetConnection();
            conn.Open();
            var dataTable = new DataTable();
            var command = new MySqlCommand(
                @"select p.id as id,
                       p.name as name, 
                       rss.quantity as quantity, 
                       rss.selling_price as price, 
                       pc.name as category
                        from retail_store_stock rss
                        INNER JOIN product p on rss.product_id = p.id
                        INNER JOIN product_category pc on p.category_id = pc.id
                        INNER JOIN retail_store rs on rss.retail_store_id = rs.id
                        WHERE rs.id = @retailStoreId;", conn);
            command.Parameters.AddWithValue("@retailStoreId", retailStoreId);
            var dataReader = command.ExecuteReader();
            dataTable.Load(dataReader);
            dataReader.Close();
            return dataTable;
        }

        private void PopulatePagerWithProductData()
        {
            foreach (DataRow productRow in _productTable.Rows)
            {
                var quantity = productRow.Field<int>("quantity");
                var product = new Product
                {
                    Name = productRow.Field<string>("name"),
                    SellingPrice = productRow.Field<decimal>("price")
                };
                _pager.AddProduct(new ProductQuantity(product, quantity));
            }
        }
        
        private void OnFormShown(object sender, EventArgs e)
        {
            CollectControls();
            var products = _pager.GetCurrentPageProducts().ToArray();
            _pageFiller.FillPageWithProducts(products);
        }
        
        private void CollectControls()
        {
            _pageFiller.AddControlCollection(new PlaceOrderItemControlCollection(lblProduct1Name,
                lblProduct1Price,
                lblProduct1Quantity,
                pbProduct1,
                btnAddProduct1,
                panProduct1));
            _pageFiller.AddControlCollection(new PlaceOrderItemControlCollection(lblProduct2Name,
                lblProduct2Price,
                lblProduct2Quantity,
                pbProduct2,
                btnAddProduct2,
                panProduct2));
            _pageFiller.AddControlCollection(new PlaceOrderItemControlCollection(lblProduct3Name,
                lblProduct3Price,
                lblProduct3Quantity,
                pbProduct3,
                btnAddProduct3,
                panProduct3));
            _pageFiller.AddControlCollection(new PlaceOrderItemControlCollection(lblProduct4Name,
                lblProduct4Price,
                lblProduct4Quantity,
                pbProduct4,
                btnAddProduct4,
                panProduct4));
            _pageFiller.AddControlCollection(new PlaceOrderItemControlCollection(lblProduct5Name,
                lblProduct5Price,
                lblProduct5Quantity,
                pbProduct5,
                btnAddProduct5,
                panProduct5));
            _pageFiller.AddControlCollection(new PlaceOrderItemControlCollection(lblProduct6Name,
                lblProduct6Price,
                lblProduct6Quantity,
                pbProduct6,
                btnAddProduct6,
                panProduct6));
        }

        private void btnPreviousPage_Click(object sender, EventArgs e)
        {
            var products = _pager.GetPreviousPageProducts().ToArray();
            _pageFiller.FillPageWithProducts(products);
        }
        
        private void btnNextPage_Click(object sender, EventArgs e)
        {
            var products = _pager.GetNextPageProducts().ToArray();
            _pageFiller.FillPageWithProducts(products);
        }
    }
}
