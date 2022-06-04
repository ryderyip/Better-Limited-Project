using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using Better_Limited_Project.Sales.OrderPlacing.Entity;
using Better_Limited_Project.Sales.OrderPlacing.Repository;

namespace Better_Limited_Project.Sales.OrderPlacing
{
    public partial class SalesOrderListForm : Form
    {
        private List<SalesOrder> _salesOrders;

        public SalesOrderListForm()
        {
            _salesOrders = new SalesOrderRepository().GetAll().ToList();
            InitializeComponent();
        }

        private void OnFormShown(object sender, EventArgs e)
        {
            FillSalesOrderDgv(_salesOrders);
            dtpSearchDate.MaxDate = DateTime.Today;
        }

        private void FillSalesOrderDgv(List<SalesOrder> salesOrders)
        {
            dgvSalesOrders.Rows.Clear();
            salesOrders.ForEach(order => dgvSalesOrders.Rows.Add(order.OrderNumber, 
                order.Customer != null ? order.Customer.Name : "-",
                order.Customer != null ? order.Customer.Phone : "-",
                order.GetTotalAmount().ToString("C", new CultureInfo("zh-HK")),
                order.CreatedOn.ToShortDateString() + " : " + order.CreatedOn.ToShortTimeString(),
                order.RetailStore.Name,
                order.Staff.Name));
            dgvSalesOrders.Sort(createdOnColumn, ListSortDirection.Descending);
        }

        private void dtpSearchDate_ValueChanged(object sender, EventArgs e)
        {
            FilterSalesOrderDgv();
        }
        
        private void tbSearchBox_TextChanged(object sender, EventArgs e)
        {
            FilterSalesOrderDgv();
        }
       
        private void cbEnableSearchByDate_CheckedChanged(object sender, EventArgs e)
        {
            dtpSearchDate.Enabled = !dtpSearchDate.Enabled;
            FilterSalesOrderDgv();
        }
        
        private void FilterSalesOrderDgv()
        {
            string searchKeyword = tbSearchBox.Text.ToLower().Trim();
            var ordersFilteredByKeyword = 
                _salesOrders.Where(order => order.OrderNumber.ToLower().Contains(searchKeyword)
                || order.Customer != null && order.Customer.Name.ToLower().Contains(searchKeyword)
                || order.Customer != null && order.Customer.Phone.Contains(searchKeyword)
                || order.Customer is {Email: { }} && order.Customer.Email.ToLower().Contains(searchKeyword));
            
            if (dtpSearchDate.Enabled)
            {
                var selectedDate = dtpSearchDate.Value.Date;
                ordersFilteredByKeyword = _salesOrders.Where(order => order.CreatedOn.Date == selectedDate);
            }
            
            FillSalesOrderDgv(ordersFilteredByKeyword.ToList());
        }

        private void dgvSalesOrders_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var orderNumber = dgvSalesOrders.Rows[e.RowIndex].Cells[salesOrderNumberColumn.Name].Value.ToString();
            var selectedOrder = _salesOrders.Find(so => so.OrderNumber == orderNumber);
            var form = new SalesOrderDetailsForm(selectedOrder);
            form.StartPosition = FormStartPosition.CenterScreen;
            form.OrderUpdated += (_, _) =>
            {
                _salesOrders = new SalesOrderRepository().GetAll().ToList();
                FillSalesOrderDgv(_salesOrders);
            };
            form.ShowDialog();
        }
    }
}
