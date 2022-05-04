using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Better_Limited_Project.DatabaseUtility;
using Better_Limited_Project.ProductUtility.Entity;
using Better_Limited_Project.SettingsUtility;
using MySql.Data.MySqlClient;

namespace Better_Limited_Project.ProductUtility.ProductList
{
    public partial class ProductListForm : Form
    {
        public delegate void ProductClickedEventHandler(object sender, string productId);
        public delegate void UpdateStockLevelClickedEventHandler(object sender, EventArgs e);
        public event ProductClickedEventHandler ProductClicked;
        public event UpdateStockLevelClickedEventHandler UpdateStockLevelClicked;
        private DataTable _productTable;

        public ProductListForm()
        {
            InitializeComponent();
            _productTable = GetProductTable();
        }
        
        private void OnFormShown(object sender, EventArgs e)
        {
            dgvProductList.DataSource = _productTable;
        }

        private DataTable GetProductTable()
        {
            var retailStoreId = UserSettings.GetSettings().Workplace?.Id;
            using var conn = Database.GetConnection();
            conn.Open();
            var dataTable = new DataTable();
            var command = new MySqlCommand(
                @"select p.id as product_id,
                       p.name as name, 
                       rss.quantity, 
                       rss.selling_price, 
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

        private void txtSearchKeywords_TextChanged(object sender, EventArgs e)
        {
            string keywords = txtSearchKeywords.Text;
            var rows = _productTable.AsEnumerable()
                .Where(row => row.Field<string>("Name").ToLower().Contains(keywords.ToLower()));
            dgvProductList.DataSource = rows.Any() ? 
                rows.CopyToDataTable() : _productTable.Clone();

            bool isNoSearchResult = dgvProductList.Rows.Count == 0 && !string.IsNullOrWhiteSpace(keywords);
            txtNoResults.Visible = isNoSearchResult;
        }

        private void dgvProductList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var clickedProductRow = _productTable.Rows[e.RowIndex];
            ProductClicked?.Invoke(this, clickedProductRow["product_id"].ToString());
        }

        public void RefreshStock()
        {
            _productTable = GetProductTable();
            dgvProductList.DataSource = _productTable;
        }

        private void btnUpdateStockLevel_Click(object sender, EventArgs e)
        {
            UpdateStockLevelClicked?.Invoke(this, EventArgs.Empty);
        }
    }
}