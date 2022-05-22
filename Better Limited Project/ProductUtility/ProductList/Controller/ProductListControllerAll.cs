using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using Better_Limited_Project.DatabaseUtility;
using Better_Limited_Project.FormControlling;
using Better_Limited_Project.ProductUtility.ProductList.Forms;
using Better_Limited_Project.StaffUtility.StaffEntity;
using Better_Limited_Project.Tools;
using MySql.Data.MySqlClient;

namespace Better_Limited_Project.ProductUtility.ProductList.Controller
{
    public class ProductListControllerAll : IProductListController
    {
        private readonly ProductListForm _form;
        private readonly List<IWorkplace> _workplaces;

        public ProductListControllerAll()
        {
            _workplaces = GetWorkplaces().ToList();
            _form = new ProductListForm();
            _form.ProductClicked += OnProductClicked;
            _form.UpdateStockLevelClicked += OnUpdateStockLevelClicked;
            _form.cbWorkplaceSelect.SelectedIndexChanged += (_, _) =>
            {
                RefreshUiStock();
                var helper = new DgvKeywordSearchHelper();
                helper.Activate(GetProductTable(), _form.dgvProductList, _form.txtSearchKeywords, "name");
            };
            _form.Shown += (_, _) =>
            {
                _form.gpWorkplaceSelect.Visible = true;
                _form.btnNewProductClicked.Visible = true;
                _form.btnRestock.Visible = false;
                _workplaces.ForEach(workplace => _form.cbWorkplaceSelect.Items.Add(workplace.Name));
                _form.cbWorkplaceSelect.SelectedIndex = 0;
            };
        }
        
        private DataTable GetProductTable()
        {
            return IsSelectedWorkplaceRetailStore() ? 
                GetRetailStoreStockTable() : GetWarehouseStockTable();
        }

        private bool IsSelectedWorkplaceRetailStore()
        {
            return RetailStoreRepository.GetRetailStores()
                .Any(rs => rs.Name == GetSelectedWorkplace().Name);
        }

        private IWorkplace GetSelectedWorkplace()
        {
            return _workplaces[_form.cbWorkplaceSelect.SelectedIndex];
        }
        
        private void OnUpdateStockLevelClicked(object sender, EventArgs e)
        {
            var controller = new UpdateStockLevelController(GetSelectedWorkplace().Id);
            controller.StockLevelUpdated += (_, _) => RefreshUiStock();
            controller.OpenForm();
        }
        
        private void OnProductClicked(object sender, int rowIndex)
        {
            string productId = _form.dgvProductList.Rows[rowIndex].Cells["product_id"].Value.ToString();
            var controller = new ProductDetailsController(productId, GetSelectedWorkplace().Id);
            controller.ProductInfoUpdated += (_, _) => RefreshUiStock();;
            controller.OpenForm();
        }

        public void OpenForm(FormController formController)
        {
            formController.OpenContentForm(_form);
        }
        
        private void RefreshUiStock()
        {
            _form.dgvProductList.DataSource = GetProductTable();
            HideDgvIdColumn();
        }
        
        private void HideDgvIdColumn()
        {
            if (_form.dgvProductList.Columns.Count != 0)
                _form.dgvProductList.Columns["product_id"].Visible = false;
        }

        private DataTable GetRetailStoreStockTable()
        {
            string retailStoreId = GetSelectedWorkplace().Id;
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

        private DataTable GetWarehouseStockTable()
        {
            string warehouseId = GetSelectedWorkplace().Id;
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

        private IEnumerable<IWorkplace> GetWorkplaces()
        {
            var stores = RetailStoreRepository.GetRetailStores();
            var warehouses = WarehouseRepository.GetWarehouses();
            return (from IWorkplace retailStore in stores select retailStore)
                .Concat(from IWorkplace warehouse in warehouses select warehouse);
        }
    }
}