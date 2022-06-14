using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using Better_Limited_Project.ProductUtility.Entity;
using Better_Limited_Project.Sales.OrderPlacing.Entity;

namespace Better_Limited_Project.ProductUtility.PickerForms
{
    public partial class SalesOrderProductPickerForm : Form
    {
        public SalesOrderProduct? SelectedProduct { get; private set; }
        private readonly List<SalesOrderProduct> _salesOrderProducts;
        private readonly List<Category> _categories;

        public SalesOrderProductPickerForm(IEnumerable<SalesOrderProduct> orderProducts)
        {
            StartPosition = FormStartPosition.CenterScreen;
            _salesOrderProducts = orderProducts.ToList();
            _categories = _salesOrderProducts.Select(sop => sop.GetProduct().Category).ToList();
            InitializeComponent();
            Shown += (_, _) => Initialize();
        }

        private void Initialize()
        {
            tbSearchBox.TextChanged += (_, _) => FilterDgv();
            cbCategoryFilter.SelectedIndexChanged += (_, _) => FilterDgv();
            cbCategoryFilter.Items.Add(string.Empty);
            _categories.ForEach(c => cbCategoryFilter.Items.Add(c.Name));
            cbCategoryFilter.SelectedIndex = 0;
            PopulateDgv(_salesOrderProducts);
        }

        private void PopulateDgv(IEnumerable<SalesOrderProduct> orderProducts)
        {
            dgvProductList.Rows.Clear();
            foreach (var salesOrderProduct in orderProducts)
            {
                var product = salesOrderProduct.GetProduct();
                dgvProductList.Rows.Add(salesOrderProduct.SalesOrderId,
                    salesOrderProduct.ProductId, product.Name, salesOrderProduct.Quantity,
                    salesOrderProduct.Price.ToString("C", new CultureInfo("zh-HK")),
                    product.Category.Name, product.Supplier.Name);
            }
        }

        private void FilterDgv()
        {
            string searchKeyword = tbSearchBox.Text.ToLower().Trim();
            var salesOrderProducts = (cbCategoryFilter.SelectedIndex != 0)
                ? from sop in _salesOrderProducts
                let product = sop.GetProduct()
                where (product.Name.ToLower().Contains(searchKeyword)
                       || product.Supplier.Name.ToLower().Contains(searchKeyword))
                      && product.Category.Name == cbCategoryFilter.SelectedItem.ToString()
                select sop
                : from sop in _salesOrderProducts
                let product = sop.GetProduct()
                where product.Name.ToLower().Contains(searchKeyword)
                      || product.Supplier.Name.ToLower().Contains(searchKeyword)
                select sop;
            PopulateDgv(salesOrderProducts);
        }

        private void dgvProductList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var orderId = dgvProductList.Rows[e.RowIndex].Cells[orderIdColumn.Name].Value.ToString();
            var productId = dgvProductList.Rows[e.RowIndex].Cells[productIdColumn.Name].Value.ToString();
            SelectedProduct = _salesOrderProducts.Find(sop => sop.SalesOrderId == orderId
                                                              && sop.ProductId == productId);
            DialogResult = DialogResult.OK;
        }
    }
}