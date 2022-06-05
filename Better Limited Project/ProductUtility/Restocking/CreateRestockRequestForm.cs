using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Better_Limited_Project.Login;
using Better_Limited_Project.ProductUtility.Entity;
using Better_Limited_Project.ProductUtility.Reordering;
using Better_Limited_Project.ProductUtility.Repository;
using Better_Limited_Project.SettingsUtility;
using Better_Limited_Project.StaffUtility.StaffEntity;

namespace Better_Limited_Project.ProductUtility.Restocking
{
    public partial class CreateRestockRequestForm : Form
    {
        private readonly List<IStock> _stocks;
        private readonly List<Category> _categories;

        public CreateRestockRequestForm() // TODO Keep in mind this for is for retail and inventory
        {
            _stocks = StockRepository.GetStocks(UserSettings.GetSettings().Workplace!.Id).ToList();
            _categories = CategoryRepository.GetCategories().ToList();
            InitializeComponent();
        }

        private void OnFormShown(object sender, EventArgs e)
        {
            PopulateProductStockList(_stocks);

            cbCategory.Items.Add(string.Empty);
            _categories.ForEach(c => cbCategory.Items.Add(c.Name));
        }

        private void PopulateProductStockList(List<IStock> stocks)
        {
            dgvProductStock.Rows.Clear();
            stocks.ToList().ForEach(
                stock => dgvProductStock.Rows.Add(stock.Product.Name,
                    stock.Quantity, stock.Product.Category.Name));
        }

        private void FilterProductStockList(object sender, EventArgs e)
        {
            string searchKeyword = tbSearchBox.Text.ToLower().Trim();
            var keywordFilteredStock = _stocks.Where(s => s.Product.Name.ToLower().Contains(searchKeyword)
                                                          || s.Product.Supplier.Name.ToLower()
                                                              .Contains(searchKeyword));

            if (cbCategory.SelectedItem.ToString() != string.Empty)
            {
                var selectedCategory = _categories.Find(c => c.Name == cbCategory.SelectedItem.ToString());
                keywordFilteredStock = keywordFilteredStock.Where(s => s.Product.Category.Id == selectedCategory.Id);
            }

            PopulateProductStockList(keywordFilteredStock.ToList());
        }

        private void btnAddToRequest_Click(object sender, EventArgs e)
        {
            if (dgvProductStock.SelectedRows.Count == 0)
                return;

            var selectedProducts = dgvProductStock.SelectedRows.Cast<DataGridViewRow>().ToList()
                .Select(row => _stocks.Find(s =>
                    s.Product.Name == row.Cells[productStockNameColumn.DataPropertyName].Value.ToString()));

            foreach (var selectedProduct in selectedProducts)
                AddToRestockRequest(selectedProduct);
        }

        private void AddToRestockRequest(IStock selectedProduct)
        {
            var selectedProductRow = dgvRestockItems.Rows.Cast<DataGridViewRow>().FirstOrDefault(row =>
                row.Cells[restockItemsNameColumn.Name].Value.ToString() == selectedProduct.Product.Name);
            if (selectedProductRow == null)
            {
                int rowIndex = dgvRestockItems.Rows.Add();
                selectedProductRow = dgvRestockItems.Rows[rowIndex];
                selectedProductRow.Cells[restockItemsNameColumn.Name].Value = selectedProduct.Product.Name;
                selectedProductRow.Cells[restockItemsQuantityColumn.Name].Value = 1;
            }

            dgvProductStock.ClearSelection();
            dgvRestockItems.ClearSelection();
            selectedProductRow.Selected = true;
        }

        private void btnRemoveSelected_Click(object sender, EventArgs e)
        {
            var selectedRows = dgvRestockItems.SelectedCells.Cast<DataGridViewCell>()
                .Select(cell => cell.OwningRow).Distinct();
            foreach (var row in selectedRows)
                dgvRestockItems.Rows.Remove(row);
            dgvRestockItems.ClearSelection();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            dgvRestockItems.Rows.Clear();
        }

        private void btnSendRequest_Click(object sender, EventArgs e)
        {
            if (dgvRestockItems.Rows.Count == 0)
            {
                MessageBox.Show("Please select Requested items");
                return;
            }

            if (_stocks.First() is RetailStoreStock)
            {
                var newGuid = Guid.NewGuid();
                var restockRequestProducts = dgvRestockItems.Rows.Cast<DataGridViewRow>().ToList()
                    .Select(row => new RestockRequestProduct
                    {
                        RestockRequestId = newGuid,
                        Product = _stocks
                            .Find(s => s.Product.Name == row.Cells[restockItemsNameColumn.Name].Value.ToString())
                            .Product,
                        Quantity = int.Parse(row.Cells[restockItemsQuantityColumn.Name].Value.ToString())
                    }).ToList();
                var request = new RestockRequest
                {
                    Id = newGuid,
                    RequestedFor = (RetailStore) UserSettings.GetSettings().Workplace!,
                    RequestedBy = LoginSession.GetSession().CurrentStaff,
                    RequestedOn = DateTime.Now,
                    RequestedProducts = restockRequestProducts
                };
                RestockRequestService.SendRequest(request);
            }
            else
            {
                var newGuid = Guid.NewGuid();
                var reorderRequestProducts = dgvRestockItems.Rows.Cast<DataGridViewRow>().ToList()
                    .Select(row => new ReorderRequestProduct
                    {
                        ReorderRequestId = newGuid,
                        Product = _stocks
                            .Find(s => s.Product.Name == row.Cells[restockItemsNameColumn.Name].Value.ToString())
                            .Product,
                        Quantity = int.Parse(row.Cells[restockItemsQuantityColumn.Name].Value.ToString())
                    }).ToList();
                var request = new ReorderRequest
                {
                    Id = newGuid,
                    RequestedFor = (Warehouse) UserSettings.GetSettings().Workplace!,
                    RequestedBy = LoginSession.GetSession().CurrentStaff,
                    RequestedOn = DateTime.Now,
                    RequestedProducts = reorderRequestProducts
                };
                ReorderRequestService.SendRequest(request);
            }

            Close();
        }

        private void dgvRestockItems_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            var changedCell = dgvRestockItems.Rows[e.RowIndex].Cells[e.ColumnIndex];
            if (changedCell.OwningColumn.Name != restockItemsQuantityColumn.Name)
                return;
            if (!int.TryParse(changedCell.Value.ToString(), out int restockQuantity)
                || restockQuantity < 0)
            {
                changedCell.Value = 0;
                MessageBox.Show("Please enter only positive integer values!");
            }
        }

        private void dgvProductStock_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var selectedProduct = _stocks.Find(s =>
                s.Product.Name == dgvProductStock.Rows[e.RowIndex].Cells[productStockNameColumn.Name].Value.ToString());
            AddToRestockRequest(selectedProduct);
        }
    }
}