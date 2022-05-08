using System.Data;
using Better_Limited_Project.DatabaseUtility;
using Better_Limited_Project.ProductUtility.Entity;
using Better_Limited_Project.Sales.Sales.SalesOrder.SalesOrderPager;
using Better_Limited_Project.SettingsUtility;
using Better_Limited_Project.Tools;
using MySql.Data.MySqlClient;

namespace Better_Limited_Project.Sales.Sales.SalesOrder
{
    public class PlaceOrderController
    {
        private readonly DataTable _productTable;
        private readonly Pager<ProductQuantity> _pager;
        private const int PageSize = 6;

        public PlaceOrderController()
        {
            _productTable = GetProductTable();
            _pager = new Pager<ProductQuantity>(PageSize);
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
                _pager.AddItem(new ProductQuantity(product, quantity));
            }
        }
        
        public void OpenForm()
        {
            var form = new PlaceOrderForm(_pager);
            form.ShowDialog();
        }
    }
}