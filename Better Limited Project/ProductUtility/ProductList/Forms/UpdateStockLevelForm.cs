using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Better_Limited_Project.DatabaseUtility;
using Better_Limited_Project.SettingsUtility;
using MySql.Data.MySqlClient;

namespace Better_Limited_Project.ProductUtility.ProductList
{
    public partial class UpdateStockLevelForm : Form
    {
        public delegate void StockLevelUpdatedEventHandler(object sender, EventArgs e);
        public event StockLevelUpdatedEventHandler StockLevelUpdated;
        private readonly DataTable _productTable;
        private readonly DataTable _selectedProductTable;
        
        public UpdateStockLevelForm()
        {
            _productTable = GetProductTable();
            _selectedProductTable = _productTable.Clone();
            InitializeComponent();
            Shown += SetDataSourcesOnShown;
        }

        private void SetDataSourcesOnShown(object sender, EventArgs e)
        {
            dgvProducts.DataSource = _productTable;
            dgvSelectedProducts.DataSource = _selectedProductTable;
            HideIdColumn();
        }

        private void HideIdColumn()
        {
            if (dgvProducts.Columns["ID"] != null)
                dgvProducts.Columns["ID"].Visible = false;
            if (dgvSelectedProducts.Columns["ID"] != null)
                dgvSelectedProducts.Columns["ID"].Visible = false;
        }

        private DataTable GetProductTable()
        {
            string storeId = UserSettings.GetSettings().Workplace!.Id;
            
            var command = new MySqlCommand(@"select p.id as ID, p.name as Name, rss.quantity as Quantity
                        FROM retail_store_stock rss
                        INNER JOIN product p on rss.product_id = p.id
                        INNER JOIN retail_store rs on rss.retail_store_id = rs.id
                        WHERE rs.id = @retailStoreId;");
            command.Parameters.AddWithValue("@retailStoreId", storeId);
            var dataTable = DataTableRepository.RetrieveDataTable(command);
            return dataTable;
        }

        private void txtSearchKeywords_TextChanged(object sender, EventArgs e)
        {
            string keywords = txtSearchKeywords.Text;
            var rows = _productTable.AsEnumerable()
                .Where(row => row.Field<string>("Name").ToLower().Contains(keywords.ToLower()));
            dgvProducts.DataSource = rows.Any() ? 
                rows.CopyToDataTable() : _productTable.Clone();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (dgvProducts.SelectedRows.Count == 0)
                return;

            var selectedRow = dgvProducts.SelectedRows[0];
            string selectedProductId = selectedRow.Cells["ID"].Value.ToString();
            string selectedProductName = selectedRow.Cells["Name"].Value.ToString();
            int newAmount = (int) nudNewAmount.Value;

            if (HasAlreadyAdded(selectedProductName))
                _selectedProductTable.Select($"Name = '{selectedProductName}'")[0]["Quantity"] = newAmount;
            else
                _selectedProductTable.Rows.Add(selectedProductId, selectedProductName, newAmount);
        }

        private bool HasAlreadyAdded(string selectedProduct)
        {
            return _selectedProductTable
                .AsEnumerable()
                .Count(row => row["Name"].ToString() == selectedProduct) > 0;
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (dgvSelectedProducts.SelectedRows.Count == 0)
                return;

            var selectedRow = dgvSelectedProducts.SelectedRows[0];
            dgvSelectedProducts.Rows.Remove(selectedRow);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            _selectedProductTable.Rows.Clear();
        }

        private void UpdateStock_OnUpdateClicked(object sender, EventArgs e)
        {
            List<MySqlCommand> commands = new();

            string storeId = UserSettings.GetSettings().Workplace!.Id;
            foreach (DataGridViewRow row in dgvSelectedProducts.Rows)
            {
                string productId = row.Cells["ID"].Value.ToString();
                int newQuantity = int.Parse(row.Cells["Quantity"].Value.ToString());
                var command = new MySqlCommand(@"update retail_store_stock
                                set quantity = @quantity
                                where product_id = @productId
                                and retail_store_id = @retailStoreId;");
                command.Parameters.AddWithValue("@quantity", newQuantity);
                command.Parameters.AddWithValue("@productId", productId);
                command.Parameters.AddWithValue("@retailStoreId", storeId);
                
                commands.Add(command);
            }
            
            DataTableRepository.ExecuteNonQuery(commands.ToArray());
            
            StockLevelUpdated?.Invoke(this, EventArgs.Empty);
            Close();
        }
    }
}
