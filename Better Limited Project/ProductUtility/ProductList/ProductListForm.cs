using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows.Forms;
using Better_Limited_Project.ProductUtility.Entity;

namespace Better_Limited_Project.ProductUtility.ProductList
{
    public partial class ProductListForm : Form
    {
        private readonly List<ProductQuantity> _stock;

        public delegate void ProductClickedEventHandler<T>(object sender, T t);

        public event ProductClickedEventHandler<ProductQuantity> ProductClicked;

        public ProductListForm()
        {
            InitializeComponent();
        }

        public ProductListForm(List<ProductQuantity> stock) : this()
        {
            _stock = stock;
        }

        private void ProductListForm_Shown(object sender, EventArgs e)
        {
            SetupDataGrid();
            PopulateDataGrid();
        }

        private void SetupDataGrid()
        {
            dgvProductList.ColumnCount = 4;
            dgvProductList.Columns[0].Name = "Name";
            dgvProductList.Columns[1].Name = "Quantity";
            dgvProductList.Columns[2].Name = "Price";
            dgvProductList.Columns[3].Name = "Category";
        }

        private void PopulateDataGrid()
        {
            PopulateDataGrid(_stock);
        }

        private void PopulateDataGrid(List<ProductQuantity> stock)
        {
            dgvProductList.Rows.Clear();
            dgvProductList.Refresh();
            foreach (var productQuantity in stock)
            {
                object[] row =
                {
                    productQuantity.Product.Name,
                    productQuantity.Quantity.ToString(),
                    productQuantity.Product.SellingPrice.ToString("C", new CultureInfo("zh-HK")),
                    productQuantity.Product.Category
                };
                dgvProductList.Rows.Add(row);
            }
        }

        private void txtSearchKeywords_TextChanged(object sender, EventArgs e)
        {
            string keywords = txtSearchKeywords.Text;
            var filteredStock = _stock.FindAll(
                productQuantity => productQuantity.Product.Name.ToLower().Contains(keywords.ToLower()));
            PopulateDataGrid(filteredStock);
     
            txtNoResults.Visible = (filteredStock.Count == 0 && !string.IsNullOrWhiteSpace(keywords));
        }

        private void dgvProductList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var clickedProduct = _stock[e.RowIndex];
            ProductClicked?.Invoke(this, clickedProduct);
        }
    }
}