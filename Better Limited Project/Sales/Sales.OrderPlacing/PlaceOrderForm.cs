using System;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using Better_Limited_Project.ProductUtility.Entity;
using Better_Limited_Project.Sales.Sales.SalesOrder.SalesOrderPager;
using Better_Limited_Project.Tools;

namespace Better_Limited_Project.Sales.Sales.OrderPlacing
{
    public partial class PlaceOrderForm : Form
    {
        private readonly PlaceOrderFormPageFiller _pageFiller;
        private readonly Pager<RetailStoreStock> _pager;
        private readonly Cart _cart;
        private Pager<RetailStoreStock> _filteredPager;

        public PlaceOrderForm(Pager<RetailStoreStock> pager, Cart cart)
        {
            _pager = pager;
            _cart = cart;
            _filteredPager = pager;
            _pageFiller = new PlaceOrderFormPageFiller();
            InitializeComponent();
        }
        
        private void OnFormShown(object sender, EventArgs e)
        {
            CollectControls();
            var products = _pager.GetCurrentPage().ToArray();
            _pageFiller.FillPageWithProducts(products);
        }
        
        private void CollectControls()
        {
            _pageFiller.AddControlCollection(new PlaceOrderItemControlCollection(lblProduct1Name,
                lblProduct1Price,
                lblProduct1Quantity,
                pbProduct1,
                btnAddProduct1,
                panProduct1));
            _pageFiller.AddControlCollection(new PlaceOrderItemControlCollection(lblProduct2Name,
                lblProduct2Price,
                lblProduct2Quantity,
                pbProduct2,
                btnAddProduct2,
                panProduct2));
            _pageFiller.AddControlCollection(new PlaceOrderItemControlCollection(lblProduct3Name,
                lblProduct3Price,
                lblProduct3Quantity,
                pbProduct3,
                btnAddProduct3,
                panProduct3));
            _pageFiller.AddControlCollection(new PlaceOrderItemControlCollection(lblProduct4Name,
                lblProduct4Price,
                lblProduct4Quantity,
                pbProduct4,
                btnAddProduct4,
                panProduct4));
            _pageFiller.AddControlCollection(new PlaceOrderItemControlCollection(lblProduct5Name,
                lblProduct5Price,
                lblProduct5Quantity,
                pbProduct5,
                btnAddProduct5,
                panProduct5));
            _pageFiller.AddControlCollection(new PlaceOrderItemControlCollection(lblProduct6Name,
                lblProduct6Price,
                lblProduct6Quantity,
                pbProduct6,
                btnAddProduct6,
                panProduct6));
        }

        private void btnPreviousPage_Click(object sender, EventArgs e)
        {
            var products = _filteredPager.GetPreviousPage().ToArray();
            _pageFiller.FillPageWithProducts(products);
        }
        
        private void btnNextPage_Click(object sender, EventArgs e)
        {
            var products = _filteredPager.GetNextPage().ToArray();
            _pageFiller.FillPageWithProducts(products);
        }

        private void txtSearchKeywords_TextChanged(object sender, EventArgs e)
        {
            _filteredPager = GetKeywordFilteredPager();
            var products = _filteredPager.GetCurrentPage().ToArray();
            _pageFiller.FillPageWithProducts(products);
        }

        private Pager<RetailStoreStock> GetKeywordFilteredPager()
        {
            string keyword = txtSearchKeywords.Text;
            return _pager.ApplyFilter(
                productQuantity => productQuantity.Product.Name.ToLower().Contains(keyword.ToLower()));
        }

        private void PlaceOrderForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString().Equals("/"))
                txtSearchKeywords.Focus();
        }

        private void AddProductButtonClicked(object sender, EventArgs e)
        {
            var products = _filteredPager.GetCurrentPage().ToArray();
            var button = (Button) sender;
            var product = button.Name switch
            {
                "btnAddProduct1" => products[0].Product,
                "btnAddProduct2" => products[1].Product,
                "btnAddProduct3" => products[2].Product,
                "btnAddProduct4" => products[3].Product,
                "btnAddProduct5" => products[4].Product,
                "btnAddProduct6" => products[5].Product,
                _ => throw new ArgumentOutOfRangeException(nameof(button.Name), $"Unexpected button name: {button.Name}")
            };
            AddProductToCart(product);
            CalculateTotalPrice();
        }

        private void AddProductToCart(Product product)
        {
            var selectedProductName = product.Name;
            var price = _filteredPager.GetCurrentPage()
                .First(stock => stock.Product.Name == selectedProductName);
            var category = product.Category;
            
            var productRow = dgvCart.Rows
                .Cast<DataGridViewRow>()
                .FirstOrDefault(row => row.Cells["name"].Value.ToString().Equals(selectedProductName));
            if (productRow == null)
            {
                dgvCart.Rows.Add(selectedProductName, price, 1, category);
                return;
            }

            int addedQuantity = int.Parse(productRow.Cells["quantity"].Value.ToString());
            productRow.Cells["quantity"].Value = addedQuantity + 1;
            
            _cart.Add(product, 1);
        }

        private void CalculateTotalPrice()
        {
            decimal total = 0;
            foreach (DataGridViewRow row in dgvCart.Rows)
            {
                decimal price = decimal.Parse(row.Cells["price"].Value.ToString());
                int quantity = int.Parse(row.Cells["quantity"].Value.ToString());
                total += price * quantity;
            }
            txtTotalPrice.Text = total.ToString("C", new CultureInfo("zh-HK"));
        }
        
        private void btnClearCart_Click(object sender, EventArgs e)
        {
            dgvCart.Rows.Clear();
            _cart.Clear();
        }
    }
}
