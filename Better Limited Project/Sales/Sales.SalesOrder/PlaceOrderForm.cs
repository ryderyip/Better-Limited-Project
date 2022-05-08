using System;
using System.Linq;
using System.Windows.Forms;
using Better_Limited_Project.Sales.Sales.SalesOrder.SalesOrderPager;

namespace Better_Limited_Project.Sales.Sales.SalesOrder
{
    public partial class PlaceOrderForm : Form
    {
        private readonly PlaceOrderFormPageFiller _pageFiller;
        private readonly PlaceOrderViewProductsPager _pager;
        
        public PlaceOrderForm(PlaceOrderViewProductsPager pager)
        {
            _pager = pager;
            _pageFiller = new PlaceOrderFormPageFiller();
            InitializeComponent();
        }
        
        private void OnFormShown(object sender, EventArgs e)
        {
            CollectControls();
            var products = _pager.GetCurrentPageProducts().ToArray();
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
            var products = _pager.GetPreviousPageProducts().ToArray();
            _pageFiller.FillPageWithProducts(products);
        }
        
        private void btnNextPage_Click(object sender, EventArgs e)
        {
            var products = _pager.GetNextPageProducts().ToArray();
            _pageFiller.FillPageWithProducts(products);
        }

        private void txtSearchKeywords_TextChanged(object sender, EventArgs e)
        {
            /*var products = _pager.;
            _pageFiller.FillPageWithProducts(products);*/
        }
    }
}
