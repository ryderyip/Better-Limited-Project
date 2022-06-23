using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Better_Limited_Project.Sales.OrderPlacing.Controller;
using Better_Limited_Project.Sales.OrderPlacing.Entity;
using Better_Limited_Project.Sales.OrderPlacing.Repository;

namespace Better_Limited_Project.Sales.OrderPlacing.UI
{
    public partial class SalesOrderListForm : Form
    {
        private List<SalesOrder> _salesOrders = new();

        public SalesOrderListForm()
        {
            InitializeComponent();
            Shown += (_, _) => Initialize();
        }

        private async void Initialize()
        {
            ToggleLoadingScreen();
            if (await GetAllSalesOrdersOrCancelOnClosing())
                return;
            ToggleLoadingScreen();
            FillSalesOrderDgv(_salesOrders);
            dtpSearchDate.MaxDate = DateTime.Today;
        }

        private async Task<bool> GetAllSalesOrdersOrCancelOnClosing()
        {
            var cancellationToken = new CancellationTokenSource();
            Closing += (_, _) => cancellationToken.Cancel();
            await Task.Run(async () => _salesOrders.AddRange(await
                new SalesOrderRepository().GetAllAsync()), cancellationToken.Token);
            return cancellationToken.IsCancellationRequested;
        }

        private void FillSalesOrderDgv(List<SalesOrder> salesOrders)
        {
            dgvSalesOrders.Rows.Clear();
            salesOrders.ForEach(order => dgvSalesOrders.Rows.Add(order.Id,
                order.OrderNumber,
                order.Customer != null ? order.Customer.Name : "-",
                order.Customer != null ? order.Customer.Phone : "-",
                new SalesOrderCalculator(order.GetSalesOrderProducts()).GetTotalAmount()
                    .ToString("C", new CultureInfo("zh-HK")),
                order.CreatedOn.ToShortDateString() + " : " + order.CreatedOn.ToShortTimeString(),
                order.IsActive ? "Yes" : "No"));
            dgvSalesOrders.Sort(salesOrderNumberColumn, ListSortDirection.Descending);
        }

        private void dtpSearchDate_ValueChanged(object sender, EventArgs e)
        {
            if (dtpSearchDate.Enabled)
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
                                            || order.Customer != null &&
                                            order.Customer.Name.ToLower().Contains(searchKeyword)
                                            || order.Customer != null && order.Customer.Phone.Contains(searchKeyword)
                                            || order.Customer is {Email: { }} &&
                                            order.Customer.Email.ToLower().Contains(searchKeyword));

            if (dtpSearchDate.Enabled)
            {
                var selectedDate = dtpSearchDate.Value.Date;
                ordersFilteredByKeyword = _salesOrders.Where(order => order.CreatedOn.Date == selectedDate);
            }

            FillSalesOrderDgv(ordersFilteredByKeyword.ToList());
        }

        private void dgvSalesOrders_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var orderId = dgvSalesOrders.Rows[e.RowIndex].Cells[idColumn.Name].Value.ToString();
            var selectedOrder = _salesOrders.Find(so => so.Id == orderId);
            var form = new SalesOrderDetailsForm(selectedOrder);
            form.StartPosition = FormStartPosition.CenterScreen;
            form.OrderUpdated += (_, _) =>
            {
                _salesOrders = new SalesOrderRepository().GetAll().ToList();
                FillSalesOrderDgv(_salesOrders);
            };
            form.ShowDialog();
        }

        private void ToggleLoadingScreen()
        {
            foreach (var control in Controls.Cast<Control>())
                control.Visible = !control.Visible;
        }
    }
}