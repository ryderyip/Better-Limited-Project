using System;
using System.Data;
using System.Windows.Forms;
using Better_Limited_Project.DatabaseUtility;
using Better_Limited_Project.SettingsUtility;
using Better_Limited_Project.Tools;
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
            var helper = new DgvKeywordSearchHelper();
            helper.Activate(_productTable, dgvProductList, txtSearchKeywords, "name");
        }
        
        private void OnFormShown(object sender, EventArgs e)
        {
            dgvProductList.DataSource = _productTable;
            RemoveDgvIdColumn();
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

        private void dgvProductList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var clickedProductRow = _productTable.Rows[e.RowIndex];
            ProductClicked?.Invoke(this, clickedProductRow["product_id"].ToString());
        }

        public void RefreshStock()
        {
            _productTable = GetProductTable();
            dgvProductList.DataSource = _productTable;
            RemoveDgvIdColumn();
        }

        private void btnUpdateStockLevel_Click(object sender, EventArgs e)
        {
            UpdateStockLevelClicked?.Invoke(this, EventArgs.Empty);
        }
        
        private void RemoveDgvIdColumn()
        {
            dgvProductList.Columns.Remove("product_id");
        }
    }
}