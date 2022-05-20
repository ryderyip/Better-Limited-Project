using System;
using System.Data;
using System.Windows.Forms;
using Better_Limited_Project.DatabaseUtility;
using Better_Limited_Project.Login;
using Better_Limited_Project.SettingsUtility;
using Better_Limited_Project.StaffUtility.StaffEntity;
using Better_Limited_Project.Tools;
using MySql.Data.MySqlClient;

namespace Better_Limited_Project.ProductUtility.ProductList.Forms
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

        private DataTable GetProductTable()
        {
            var department = StaffRepository.GetStaff(LoginSession.GetSession().StaffId).Department;
            return department is Department.Sales ? 
                GetRetailStoreStockDataTable() : GetWarehouseStockDataTable();
        }
        
        private void OnFormShown(object sender, EventArgs e)
        {
            dgvProductList.DataSource = _productTable;
            HideDgvIdColumn();
        }

        private DataTable GetRetailStoreStockDataTable()
        {
            var retailStoreId = UserSettings.GetSettings().Workplace?.Id;
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
                        WHERE rs.id = @retailStoreId;");
            command.Parameters.AddWithValue("@retailStoreId", retailStoreId);
            return DataTableRepository.RetrieveDataTable(command);
        }

        private DataTable GetWarehouseStockDataTable()
        {
            var warehouseId = UserSettings.GetSettings().Workplace?.Id;
            var command = new MySqlCommand(
                @"select p.id as product_id,
                       p.name as name, 
                       ws.quantity, 
                       pc.name as category
                        from warehouse_stock ws
                        INNER JOIN product p on ws.product_id = p.id
                        INNER JOIN product_category pc on p.category_id = pc.id
                        INNER JOIN warehouse w on ws.warehouse_id = w.id
                        WHERE w.id = @warehouseId;");
            command.Parameters.AddWithValue("@warehouseId", warehouseId);
            return DataTableRepository.RetrieveDataTable(command);
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
            HideDgvIdColumn();
        }

        private void btnUpdateStockLevel_Click(object sender, EventArgs e)
        {
            UpdateStockLevelClicked?.Invoke(this, EventArgs.Empty);
        }
        
        private void HideDgvIdColumn()
        {
            dgvProductList.Columns["product_id"].Visible = false;
        }
    }
}