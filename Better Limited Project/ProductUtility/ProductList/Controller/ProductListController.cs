using System;
using System.Data;
using System.Windows.Forms;
using Better_Limited_Project.DatabaseUtility;
using Better_Limited_Project.FormControlling;
using Better_Limited_Project.Login;
using Better_Limited_Project.ProductUtility.ProductList.Forms;
using Better_Limited_Project.SettingsUtility;
using Better_Limited_Project.StaffUtility.StaffEntity;
using Better_Limited_Project.Tools;
using MySql.Data.MySqlClient;

namespace Better_Limited_Project.ProductUtility.ProductList.Controller
{
    public class ProductListController : IProductListController
    {
        private readonly ProductListForm _form;
        private DataTable _productTable;

        public ProductListController()
        {
            _form = new ProductListForm();
            _form.ProductClicked += OnProductClicked;
            _form.UpdateStockLevelClicked += OnUpdateStockLevelClicked;
            _productTable = GetProductTable();
        }

        public void OpenForm(FormController formController)
        {
            if (UserSettings.GetSettings().Workplace == null)
            {
                MessageBox.Show("Please first select your workplace in settings!");
                return;
            }

            formController.OpenContentForm(_form);
            _form.Shown += OnFormShown;
        }
        
        private void OnFormShown(object sender, EventArgs e)
        {
            _form.dgvProductList.DataSource = _productTable;
            HideDgvIdColumn();
            var helper = new DgvKeywordSearchHelper();
            helper.Activate(_productTable, _form.dgvProductList, _form.txtSearchKeywords, "name");
        }
        
        private DataTable GetProductTable()
        {
            var department = StaffRepository.GetStaff(LoginSession.GetSession().StaffId).Department;
            return department is Department.Sales ? 
                GetRetailStoreStockDataTable() : GetWarehouseStockDataTable();
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
        
        private void OnUpdateStockLevelClicked(object sender, EventArgs e)
        {
            var retailStoreId = UserSettings.GetSettings().Workplace.Id;
            var controller = new UpdateStockLevelController(retailStoreId);
            controller.StockLevelUpdated += (_, _) => RefreshUiStock();
            controller.OpenForm();
        }
        
        private void OnProductClicked(object sender, int rowIndex)
        {
            var clickedProductRow = _productTable.Rows[rowIndex];
            string productId = clickedProductRow["product_id"].ToString();
            string workplaceId = UserSettings.GetSettings().Workplace!.Id;
            
            var controller = new ProductDetailsController(productId, workplaceId);
            controller.ProductInfoUpdated += (_, _) => RefreshUiStock();
            controller.ProductRemoved += (_, _) => RefreshUiStock();
            controller.OpenForm();
        }

        private void RefreshUiStock()
        {
            _productTable = GetProductTable();
            _form.dgvProductList.DataSource = _productTable;
            HideDgvIdColumn();
        }
        
        private void HideDgvIdColumn()
        {
            _form.dgvProductList.Columns["product_id"].Visible = false;
        }
    }
}