using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using Better_Limited_Project.Sales.OrderPlacing.Entity;

namespace Better_Limited_Project.ProductUtility.PickerForms
{
    public partial class SalesOrderProductPickerForm : Form
    {
        public SalesOrderProduct? SelectedProduct { get; private set; }
        private readonly List<SalesOrderProduct> _salesOrderProducts;

        public SalesOrderProductPickerForm(IEnumerable<SalesOrderProduct> orderProducts)
        {
            StartPosition = FormStartPosition.CenterScreen;
            _salesOrderProducts = orderProducts.ToList();
            InitializeComponent();
            Shown += (_, _) => PopulateDgv(_salesOrderProducts);
        }

        private void PopulateDgv(IEnumerable<SalesOrderProduct> orderProducts)
        {
            dgvProductList.Rows.Clear();
            foreach (var salesOrderProduct in orderProducts)
            {
                var product = salesOrderProduct.GetProduct();
                dgvProductList.Rows.Add(salesOrderProduct.SalesOrderId,
                    salesOrderProduct.ProductId, product.Name, 
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
                where product.Name.ToLower().Contains(searchKeyword)
                      || product.Supplier.Name.ToLower().Contains(searchKeyword)
                      || product.Category.Name.ToLower().Contains(searchKeyword)
                select sop
                : from sop in _salesOrderProducts
                let product = sop.GetProduct()
                where product.Name.ToLower().Contains(searchKeyword)
                      || product.Supplier.Name.ToLower().Contains(searchKeyword)
                select sop;
            PopulateDgv(salesOrderProducts);
        }

        private void tbSearchBox_TextChanged(object sender, EventArgs e)
        {
            FilterDgv();
        }

        private void cbCategoryFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterDgv();
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