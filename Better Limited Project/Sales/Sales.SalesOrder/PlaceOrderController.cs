using System;
using System.Data;
using Better_Limited_Project.DatabaseUtility;
using Better_Limited_Project.ProductUtility.Entity;
using Better_Limited_Project.SettingsUtility;
using Better_Limited_Project.Tools;
using MySql.Data.MySqlClient;

namespace Better_Limited_Project.Sales.Sales.SalesOrder
{
    public class PlaceOrderController
    {
        private readonly PlaceOrderForm _form;
        private readonly DataTable _productTable;
        private readonly Pager<ProductQuantity> _pager;
        private const int PageSize = 6;

        public PlaceOrderController()
        {
            _pager = new Pager<ProductQuantity>(PageSize);
            _form = new PlaceOrderForm(_pager);
            _form.Shown += SetCartDgvSchemaOnShown;
            _productTable = GetProductTable();
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
                    Id = productRow.Field<string>("id"),
                    Name = productRow.Field<string>("name"),
                    SellingPrice = productRow.Field<decimal>("price"),
                    Category = productRow.Field<string>("category")
                };
                _pager.AddItem(new ProductQuantity(product, quantity));
            }
        }
        
        public void OpenForm()
        {
            _form.ShowDialog();
        }

        private void SetCartDgvSchemaOnShown(object sender, EventArgs e)
        {
            _form.dgvCart.Columns.Add("name", "Name");
            _form.dgvCart.Columns.Add("price", "Price");
            _form.dgvCart.Columns.Add("quantity", "Qty");
            _form.dgvCart.Columns.Add("category", "Category");
        }
    }
}