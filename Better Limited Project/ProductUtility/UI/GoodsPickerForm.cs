using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Better_Limited_Project.ProductUtility.Entity;
using Better_Limited_Project.ProductUtility.ProductList.Forms;
using Better_Limited_Project.ProductUtility.Reordering.Entity;
using Better_Limited_Project.ProductUtility.Repository;
using Better_Limited_Project.SettingsUtility;

namespace Better_Limited_Project.ProductUtility.UI
{
    /// <summary>
    /// For selecting products and their quantity. Returns dialog result <see cref="DialogResult.OK"/> when finished.
    /// </summary>
    public partial class GoodsPickerForm : Form
    {
        private readonly List<Product> _products;
        private readonly List<Category> _categories;
        public List<IProductQuantity> SelectedProducts { get; }

        /// <summary>
        /// Creates a <see cref="GoodsPickerForm"/> instance.
        /// </summary>
        /// <param name="productQuantities">Already selected products to be added
        /// to the selected goods data grid view.</param>
        /// <param name="products"><para>Products for users to pick from.</para>Users can pick any product if unprovided.</param>
        public GoodsPickerForm(IList<IProductQuantity>? productQuantities = null, IEnumerable<Product>? products = null)
        {
            _products = products == null ? ProductRepository.GetAll().ToList() : products.ToList();
            _categories = CategoryRepository.GetAll().ToList();
            StartPosition = FormStartPosition.CenterScreen;
            SelectedProducts = productQuantities != null
                ? new List<IProductQuantity>(productQuantities)
                : new List<IProductQuantity>();
            Load += (_, _) => Initialize();
            InitializeComponent();
        }

        private void Initialize()
        {
            dgvRequestedGoods.RowsAdded += (_, _) => DisableSubmitButtonIfNoProductSelected();
            dgvRequestedGoods.RowsAdded += (_, args) => SelectUpdatedRow(args.RowIndex);
            dgvRequestedGoods.CellValueChanged += (_, args) => SelectUpdatedRow(args.RowIndex);
            dgvRequestedGoods.RowsRemoved += (_, _) => DisableSubmitButtonIfNoProductSelected();
            tbSearchKeywords.TextChanged += (_, _) => FilterProductDgv();
            cbCategory.SelectedIndexChanged += (_, _) => FilterProductDgv();
            dgvProducts.Click += (_, _) => dgvRequestedGoods.ClearSelection();
            dgvRequestedGoods.Click += (_, _) => dgvProducts.ClearSelection();
            PopulateProductDgv(_products);
            _categories.ForEach(c => cbCategory.Items.Add(c.Name));
            cbCategory.Items.Add(string.Empty);
            SelectedProducts.ForEach(sp => AddToSelectedGoodsDgv(sp.Product, sp.Quantity));
        }

        private void DisableSubmitButtonIfNoProductSelected()
        {
            btnConfirm.Enabled = dgvRequestedGoods.RowCount != 0;
        }

        private void SelectUpdatedRow(int rowIndex)
        {
            dgvRequestedGoods.Rows[rowIndex].Selected = true;
        }

        private void PopulateProductDgv(List<Product> products)
        {
            dgvProducts.Rows.Clear();
            var stocks = StockRepository.GetStocks(UserSettings.GetSettings().Workplace!.Id).ToList();
            foreach (var product in products)
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
                var product = _products.Find(p => p.Id == productId);
                int quantity = (int) nudAmountToAdd.Value;
                // AddToSelectedProducts(productId, quantity);
                AddToSelectedGoodsDgv(product, quantity);
                row.Selected = false;
            }

            nudAmountToAdd.Value = nudAmountToAdd.Minimum;
        }

        private void AddToSelectedGoodsDgv(Product product, int quantity)
        {
            var requestedGoodsProductRow = GetRowInDgvRequestedGoods(product.Id);
            if (requestedGoodsProductRow != default)
            {
                quantity += int.Parse(requestedGoodsProductRow.Cells[quantityToReorderColumn.Name].Value.ToString());
                requestedGoodsProductRow.Cells[quantityToReorderColumn.Name].Value = quantity;
            }
            else
                dgvRequestedGoods.Rows.Add(product.Id, product.Name, quantity);
        }

        private DataGridViewRow? GetRowInDgvRequestedGoods(string productId)
        {
            return dgvRequestedGoods.Rows.Cast<DataGridViewRow>()
                .FirstOrDefault(r => r.Cells[requestedProductIdColumn.Name].Value.ToString() == productId);
        }

        private void btnRemoveSelected_Click(object sender, System.EventArgs e)
        {
            foreach (DataGridViewRow row in dgvRequestedGoods.SelectedRows)
            {
                string productId = row.Cells[requestedProductIdColumn.Name].Value.ToString();
                SelectedProducts.RemoveAll(p => p.ProductId == productId);
                dgvRequestedGoods.Rows.Remove(row);
            }
            dgvRequestedGoods.ClearSelection();
        }

        private void btnClear_Click(object sender, System.EventArgs e)
        {
            dgvRequestedGoods.Rows.Clear();
            SelectedProducts.Clear();
        }

        private void btnConfirm_Click(object sender, System.EventArgs e)
        {
            SelectedProducts.Clear();
            foreach (DataGridViewRow row in dgvRequestedGoods.Rows)
            {
                string productId = row.Cells[requestedProductIdColumn.Name].Value.ToString();
                int quantity = int.Parse(row.Cells[quantityToReorderColumn.Name].Value.ToString());
                SelectedProducts.Add(new ProductQuantity(productId, quantity));
            }

            DialogResult = DialogResult.OK;
        }

        private void dgvProducts_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string productId = dgvProducts.Rows[e.RowIndex].Cells[productIdColumn.Name].Value.ToString();
            var stock = StockRepository.FindByIds(UserSettings.GetSettings().Workplace!.Id, productId);
            var form = new ProductDetailsForm(stock);
            form.ShowDialog();
        }

        private void FilterProductDgv()
        {
            string keywords = tbSearchKeywords.Text.Trim().ToLower();
            var filteredProducts = cbCategory.SelectedIndex == -1
                ? _products.Where(p => p.Name.ToLower().Contains(keywords))
                : _products.Where(p => p.Name.ToLower().Contains(keywords)
                                       && p.Category.Name == cbCategory.SelectedItem.ToString());
            PopulateProductDgv(filteredProducts.ToList());
        }
    }
}