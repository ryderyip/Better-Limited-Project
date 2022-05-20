using System;
using System.Data;
using System.Windows.Forms;
using Better_Limited_Project.DatabaseUtility;
using Better_Limited_Project.ProductUtility.ProductList;
using Better_Limited_Project.Tools;
using MySql.Data.MySqlClient;

namespace Better_Limited_Project.Admin
{
    public partial class AdminProductListForm : Form
    {
        private DataTable _productTable;
        
        public AdminProductListForm()
        {
            _productTable = GetProductTable();
            InitializeComponent();
            var searchHelper = new DgvKeywordSearchHelper();
            searchHelper.Activate(_productTable, dgvProductList, txtSearchKeywords, "name");
        }
        
        private DataTable GetProductTable()
        {
            var command = new MySqlCommand(
                @"select p.id as product_id,
                       p.name as name, 
                       rss.quantity, 
                       rss.selling_price, 
                       pc.name as category
                        from retail_store_stock rss
                        INNER JOIN product p on rss.product_id = p.id
                        INNER JOIN product_category pc on p.category_id = pc.id
                        INNER JOIN retail_store rs on rss.retail_store_id = rs.id;");
            return DataTableRepository.RetrieveDataTable(command);
        }

        private void OnFormShown(object sender, EventArgs e)
        {
            dgvProductList.DataSource = _productTable;
            HideDgvIdColumn();
        }

        private void dgvProductList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var clickedProductRow = _productTable.Rows[e.RowIndex];
            string productId = clickedProductRow["product_id"].ToString();
            
            var controller = new ProductDetailsController(productId);
            controller.ProductInfoUpdated += RefreshStockOnProductInfoUpdated;
            controller.OpenForm();
        }

        private void RefreshStockOnProductInfoUpdated(object sender, EventArgs e)
        {
            _productTable = GetProductTable();
            dgvProductList.DataSource = _productTable;
            HideDgvIdColumn();
        }
        
        private void HideDgvIdColumn()
        {
            dgvProductList.Columns["product_id"].Visible = false;
        }
    }
}