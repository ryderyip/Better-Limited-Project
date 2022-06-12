using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Better_Limited_Project.Login;
using Better_Limited_Project.ProductUtility.Entity;
using Better_Limited_Project.ProductUtility.ProductList.Forms;
using Better_Limited_Project.ProductUtility.Repository;
using Better_Limited_Project.SettingsUtility;

namespace Better_Limited_Project.ProductUtility.Reordering
{
    public partial class ReorderRequestSendingForm : Form
    {
        private readonly List<Product> _products;

        public ReorderRequestSendingForm()
        {
            _products = ProductRepository.GetAll().ToList();
            StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
            Load += (_, _) => Initialize();
        }

        private void Initialize()
        {
            dgvRequestedGoods.RowsAdded += (_, _) => DgvRequestedGoodsOnRowCountChanged();
            dgvRequestedGoods.RowsRemoved += (_, _) => DgvRequestedGoodsOnRowCountChanged();
            dgvProducts.Click += (_, _) => dgvRequestedGoods.ClearSelection();
            dgvRequestedGoods.Click += (_, _) => dgvProducts.ClearSelection();
            PopulateProductDgv();
        }

        private void DgvRequestedGoodsOnRowCountChanged()
        {
            btnSendReorderRequest.Enabled = dgvRequestedGoods.RowCount != 0;
        }

        private void PopulateProductDgv()
        {
            var stocks = StockRepository.GetWarehouseStocks(UserSettings.GetSettings().Workplace!.Id).ToList();
            foreach (var product in _products)
            {
                var stock = stocks.Find(s => s.Product.Id == product.Id);
                dgvProducts.Rows.Add(product.Id, product.Name, stock.Quantity, product.Category.Name);
            }
        }

        private void btnAdd_Click(object sender, System.EventArgs e)
        {
            foreach (DataGridViewRow row in dgvProducts.SelectedRows)
            {
                string productId = row.Cells[productIdColumn.Name].Value.ToString();
                string productName = row.Cells[productNameColumn.Name].Value.ToString();
                var requestedGoodsProductRow = GetProductRowInDgvRequestedGoods(productId);
                int index;
                if (requestedGoodsProductRow != default)
                {
                    int oldQtyToReorder =
                        int.Parse(requestedGoodsProductRow.Cells[quantityToReorderColumn.Name].Value.ToString());
                    int qtyToReorder = (int) nudAmountToAdd.Value + oldQtyToReorder;
                    requestedGoodsProductRow.Cells[quantityToReorderColumn.Name].Value = qtyToReorder;
                    index = requestedGoodsProductRow.Index;
                }
                else
                {
                    int qtyToReorder = (int) nudAmountToAdd.Value;
                    index = dgvRequestedGoods.Rows.Add(productId, productName, qtyToReorder);
                }

                row.Selected = false;
                dgvRequestedGoods.Rows[index].Selected = true;
            }

            nudAmountToAdd.Value = nudAmountToAdd.Minimum;
        }

        private DataGridViewRow? GetProductRowInDgvRequestedGoods(string productId)
        {
            return dgvRequestedGoods.Rows.Cast<DataGridViewRow>()
                .FirstOrDefault(r => r.Cells[requestedProductIdColumn.Name].Value.ToString() == productId);
        }

        private void btnRemoveSelected_Click(object sender, System.EventArgs e)
        {
            foreach (DataGridViewRow row in dgvRequestedGoods.SelectedRows)
                dgvRequestedGoods.Rows.Remove(row);
            dgvRequestedGoods.ClearSelection();
        }

        private void btnClear_Click(object sender, System.EventArgs e)
        {
            dgvRequestedGoods.Rows.Clear();
        }

        private void btnSendReorderRequest_Click(object sender, System.EventArgs e)
        {
            if (dgvRequestedGoods.RowCount == 0)
                return;

            var result = MessageBox.Show("Confirm Sending Reorder Request?", "Confirmation", MessageBoxButtons.OKCancel);
            if (result is not DialogResult.OK) return;

            var service = new ReorderService();
            foreach (DataGridViewRow row in dgvRequestedGoods.Rows)
            {
                string productId = row.Cells[requestedProductIdColumn.Name].Value.ToString();
                int quantity = int.Parse(row.Cells[quantityToReorderColumn.Name].Value.ToString());
                service.AddProduct(productId, quantity);
            }

            service.Submit();
            DialogResult = DialogResult.OK;
        }

        private void dgvProducts_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string productId = dgvProducts.Rows[e.RowIndex].Cells[productIdColumn.Name].Value.ToString();
            var stock = StockRepository.FindByIds(UserSettings.GetSettings().Workplace!.Id, productId);
            var form = new ProductDetailsForm(stock);
            form.ShowDialog();
        }
    }
}