using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using Better_Limited_Project.Login;
using Better_Limited_Project.ProductUtility.GoodsPurchasing.Entity;
using Better_Limited_Project.ProductUtility.GoodsPurchasing.Repository;
using Better_Limited_Project.StaffUtility.StaffEntity;

namespace Better_Limited_Project.ProductUtility.GoodsPurchasing.UI
{
    public partial class PurchaseOrderListForm : Form
    {
        private List<PurchaseOrder> _purchaseOrders;

        public PurchaseOrderListForm()
        {
            _purchaseOrders = PurchaseOrderRepository.GetAll().ToList();
            InitializeComponent();
            Load += (_, _) => Initialize();
        }

        private void Initialize()
        {
            if (LoginSession.GetSession().CurrentStaff.Title is StaffTitle.ReceivingClerk)
            {
                cbShowApproved.Checked = true;
                cbShowApproved.Enabled = false;
                _purchaseOrders = _purchaseOrders.Where(po => po.IsApproved()).ToList();
                isApprovedColumn.Visible = false;
            }
            tbSearchBox.TextChanged += (_, _) => FilterDgv();
            cbShowApproved.CheckedChanged += (_, _) => FilterDgv();
            FilterDgv();
        }

        private void PopulateDgv(List<PurchaseOrder> purchaseOrders)
        {
            dgvPurchaseOrders.Rows.Clear();
            purchaseOrders.ForEach(po => dgvPurchaseOrders.Rows.Add(po.Id, 
                po.PurchaseOrderNumber,
                po.ReorderRequest.RequestNumber,
                po.CreatedOn.ToString("g"), 
                po.IsApproved() ? "Yes" : "No", 
                po.ApprovedOn?.ToString("g") ?? "-"));
            dgvPurchaseOrders.Sort(createdOnColumn, ListSortDirection.Descending);
        }

        private void FilterDgv()
        {
            string searchKeywords = tbSearchBox.Text.Trim().ToLower();
            var filteredPurchaseOrders = cbShowApproved.Checked
                ? _purchaseOrders.Where(po => po.PurchaseOrderNumber.ToLower().Contains(searchKeywords)
                                        || po.ReorderRequest.RequestNumber.ToLower().Contains(searchKeywords))
                : _purchaseOrders.Where(po => (po.PurchaseOrderNumber.ToLower().Contains(searchKeywords)
                                               || po.ReorderRequest.RequestNumber.ToLower().Contains(searchKeywords))
                                              && !po.IsApproved());
            PopulateDgv(filteredPurchaseOrders.ToList());
        }

        private void dgvPurchaseOrders_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string id = dgvPurchaseOrders.Rows[e.RowIndex].Cells[idColumn.Name].Value.ToString();
            var selected = _purchaseOrders.Find(po => po.Id == id);
            new PurchaseOrderDetailsForm(selected).ShowDialog();
            RefreshDgv();
        }

        private void RefreshDgv()
        {
            _purchaseOrders = PurchaseOrderRepository.GetAll().ToList();
            Initialize();
        }
    }
}
