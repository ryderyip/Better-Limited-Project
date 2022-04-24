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
            dgvProductList.ColumnCount = 5;
    
            dgvProductList.Columns[0].Name = "Name";
            dgvProductList.Columns[1].Name = "Price";
            dgvProductList.Columns[2].Name = "Description";
            dgvProductList.Columns[3].Name = "IsPhasingOut";
            dgvProductList.Columns[4].Name = "Category";


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
                    productQuantity.Product.SellingPrice.ToString("C", new CultureInfo("zh-HK")),
                    productQuantity.Product.Description,
                    productQuantity.Product.IsPhasingOut,
                    productQuantity.Product.Category,
                      
                    
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
    }
}