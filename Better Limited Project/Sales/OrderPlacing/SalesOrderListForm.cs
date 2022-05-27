using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using Better_Limited_Project.RepositoryUtility;
using Better_Limited_Project.Sales.OrderPlacing.Entity;
using Better_Limited_Project.Sales.OrderPlacing.Repository;

namespace Better_Limited_Project.Sales.OrderPlacing
{
    public partial class SalesOrderListForm : Form
    {
        private List<SalesOrder> _salesOrders;
        private readonly IRepository<SalesOrder> _repository;

        public SalesOrderListForm()
        {
            _repository = new SalesOrderRepository();
            _salesOrders = _repository.GetAll().ToList();
            InitializeComponent();
        }

        private void OnFormShown(object sender, System.EventArgs e)
        {
            FillSalesOrderDgv(_salesOrders);

        }

        private void FillSalesOrderDgv(List<SalesOrder> salesOrders)
        {
            dgvSalesOrders.Rows.Clear();
            salesOrders.ForEach(order => dgvSalesOrders.Rows.Add(order.Id, 
                order.Customer != null ? order.Customer.Name : "-",
                order.Customer != null ? order.Customer.Phone : "-",
                order.GetTotalPrice().ToString("C", new CultureInfo("zh-HK")),
                order.CreatedOn.ToShortDateString() + " : " + order.CreatedOn.ToShortTimeString(),
                order.RetailStore.Name,
                order.Staff.Name));
        }

        private void dtpSearchDate_ValueChanged(object sender, System.EventArgs e)
        {
            FilterSalesOrderDgv();
        }
        
        private void tbSearchBox_TextChanged(object sender, System.EventArgs e)
        {
            FilterSalesOrderDgv();
        }
       
        private void cbEnableSearchByDate_CheckedChanged(object sender, System.EventArgs e)
        {
            dtpSearchDate.Enabled = !dtpSearchDate.Enabled;
            FilterSalesOrderDgv();
        }
        
        private void FilterSalesOrderDgv()
        {
            string searchKeyword = tbSearchBox.Text.ToLower().Trim();
            var ordersFilteredByKeyword = 
                _salesOrders.Where(order => order.Id.ToLower().Contains(searchKeyword)
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
    }
}
