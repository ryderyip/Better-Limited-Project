using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using Better_Limited_Project.Sales.OrderPlacing.Controller;
using Better_Limited_Project.Sales.OrderPlacing.Entity;
using Better_Limited_Project.Sales.OrderPlacing.Repository;

namespace Better_Limited_Project.ProductUtility.PickerForms
{
    public partial class SalesOrderPickerForm : Form
    {
        public SalesOrder? SelectedSalesOrder { get; private set; }
        private readonly List<SalesOrder> _salesOrders;

        public SalesOrderPickerForm(IEnumerable<SalesOrder> salesOrders)
        {
            StartPosition = FormStartPosition.CenterScreen;
            _salesOrders = salesOrders.ToList();
            InitializeComponent();
            Shown += (_, _) => Initialize();
        }
        
        private void Initialize()
        {
            dtpSearchDate.MaxDate = DateTime.Today;
        }

        private void PopulateDgv(List<SalesOrder> salesOrders)
        {
            dgvSalesOrders.Rows.Clear();
            salesOrders.ForEach(order => dgvSalesOrders.Rows.Add(order.Id,
                order.OrderNumber, 
                order.Customer?.Name ?? "-",
                order.Customer?.Phone ?? "-",
                order.Customer?.Email ?? "-",
                order.CreatedOn.ToShortDateString() + " : " + order.CreatedOn.ToShortTimeString(),
                new SalesOrderCalculator(order.GetSalesOrderProducts()).GetTotalAmount().ToString("C", new CultureInfo("zh-HK"))));
            dgvSalesOrders.Sort(createdOnColumn, ListSortDirection.Descending);
        }

        private void dgvSalesOrders_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            SelectedSalesOrder = _salesOrders.Find(so =>
                so.Id == dgvSalesOrders.Rows[e.RowIndex].Cells[idColumn.Name].Value.ToString());
            DialogResult = DialogResult.OK;
        }

        private void cbEnableSearchByDate_CheckedChanged(object sender, EventArgs e)
        {
            dtpSearchDate.Enabled = !dtpSearchDate.Enabled;
            FilterSalesOrderDgv();
        }

        private void tbSearchBox_TextChanged(object sender, EventArgs e)
        {
            FilterSalesOrderDgv();
        }
        
        private void FilterSalesOrderDgv()
        {
            string searchKeyword = tbSearchBox.Text.ToLower().Trim();
            var ordersFilteredByKeyword = (dtpSearchDate.Enabled)
                ? _salesOrders.Where(order => (order.OrderNumber.ToLower().Contains(searchKeyword)
                                               || order.Customer != null &&
                                               order.Customer.Name.ToLower().Contains(searchKeyword)
                                               || order.Customer != null && order.Customer.Phone.Contains(searchKeyword)
                                               || order.Customer is {Email: { }} && order.Customer.Email.ToLower()
                                                   .Contains(searchKeyword))
                                              && order.CreatedOn.Date == dtpSearchDate.Value.Date)
                : _salesOrders.Where(order => order.OrderNumber.ToLower().Contains(searchKeyword)
                                            || order.Customer != null && order.Customer.Name.ToLower().Contains(searchKeyword)
                                            || order.Customer != null && order.Customer.Phone.Contains(searchKeyword)
                                            || order.Customer is {Email: { }} && order.Customer.Email.ToLower().Contains(searchKeyword));
            
            PopulateDgv(ordersFilteredByKeyword.ToList());
        }

        private void dtpSearchDate_ValueChanged(object sender, EventArgs e)
        {
            FilterSalesOrderDgv();
        }
    }
}
