using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using Better_Limited_Project.DatabaseUtility;
using Better_Limited_Project.FormControlling;
using Better_Limited_Project.ProductUtility.ProductList.Forms;
using Better_Limited_Project.ProductUtility.ProductList.ProductList;
using Better_Limited_Project.StaffUtility.StaffEntity;
using Better_Limited_Project.Tools;
using MySql.Data.MySqlClient;

namespace Better_Limited_Project.ProductUtility.ProductList.Controller
{
    public class ProductListControllerAll : IProductListController
    {
        private readonly ProductListForm _form;
        private DataTable? _productTable;
        
        public ProductListControllerAll()
        {
            _form = new ProductListForm();
            _form.ProductClicked += OnProductClicked;
            _form.UpdateStockLevelClicked += OnUpdateStockLevelClicked;
            _form.cbWorkplaceSelect.SelectedIndexChanged += (_, _) =>
            {
                RefreshUiStock();
                var helper = new DgvKeywordSearchHelper();
                helper.Activate(_productTable, _form.dgvProductList, _form.txtSearchKeywords, "name");
            };
            _form.Shown += (_, _) =>
            {
                _form.gpWorkplaceSelect.Visible = true;
                _form.btnNewProductClicked.Visible = true;
                _form.btnRestock.Visible = false;
                GetWorkplaceNames().ToList()
                    .ForEach(name => _form.cbWorkplaceSelect.Items.Add(name));
                if (_form.cbWorkplaceSelect.Items.Count != 0)
                    _form.cbWorkplaceSelect.SelectedIndex = 0;
            };
        }
        
        private DataTable? GetProductTable()
        {
            if (!HasSelectedWorkplace())
                return null;
            
            string selectedWorkplaceName = _form.cbWorkplaceSelect.SelectedItem.ToString();
            var retailStore = RetailStoreRepository.GetRetailStoreByName(selectedWorkplaceName);
            if (retailStore != null)
                return GetRetailStoreStockTable(retailStore.Id);

            var warehouse = WarehouseRepository.GetWarehouseByName(selectedWorkplaceName);
            if (warehouse != null)
                return GetWarehouseStockTable(warehouse.Id);

            throw new ArgumentException("Unexpected workplace name.");
        }

        private string GetSelectedWorkplaceId()
        {
            string selectedWorkplaceName = _form.cbWorkplaceSelect.SelectedItem.ToString();
            var retailStore = RetailStoreRepository.GetRetailStoreByName(selectedWorkplaceName);
            if (retailStore != null)
                return retailStore.Id;

            var warehouse = WarehouseRepository.GetWarehouseByName(selectedWorkplaceName);
            if (warehouse != null)
                return warehouse.Id;

            throw new ArgumentException("Unexpected workplace name.");
        }
        
        private void OnUpdateStockLevelClicked(object sender, EventArgs e)
        {
            var controller = new UpdateStockLevelController(GetSelectedWorkplaceId());
            controller.StockLevelUpdated += (_, _) => RefreshUiStock();
            controller.OpenForm();
        }
        
        private void OnProductClicked(object sender, int rowIndex)
        {
            var clickedProductRow = _productTable.Rows[rowIndex];
            string productId = clickedProductRow["product_id"].ToString();
            var controller = new ProductDetailsController(productId, GetSelectedWorkplaceId());
            controller.ProductInfoUpdated += (_, _) => RefreshUiStock();;
            controller.OpenForm();
        }

        public void OpenForm(FormController formController)
        {
            formController.OpenContentForm(_form);
        }
        
        private void RefreshUiStock()
        {
            _productTable = GetProductTable();
            _form.dgvProductList.DataSource = _productTable;
            HideDgvIdColumn();
        }
        
        private void HideDgvIdColumn()
        {
            if (_form.dgvProductList.Columns.Count != 0)
                _form.dgvProductList.Columns["product_id"].Visible = false;
        }

        private bool HasSelectedWorkplace()
        {
            return _form.cbWorkplaceSelect != null 
                   && _form.cbWorkplaceSelect.SelectedItem != null;
        }

        private DataTable GetRetailStoreStockTable(string retailStoreId)
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
                        INNER JOIN retail_store rs on rss.retail_store_id = rs.id
                        WHERE rs.id = @retailStoreId;");
            command.Parameters.AddWithValue("@retailStoreId", retailStoreId);
            return DataTableRepository.RetrieveDataTable(command);
        }

        private DataTable GetWarehouseStockTable(string warehouseId)
        {
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

        private IEnumerable<string> GetWorkplaceNames()
        {
            var stores = RetailStoreRepository.GetRetailStores();
            var warehouses = WarehouseRepository.GetWarehouses();
            return (from store in stores select store.Name)
                .Concat(from warehouse in warehouses select warehouse.Name);
        }
        
        
    }
}