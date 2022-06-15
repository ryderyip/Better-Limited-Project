using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using Better_Limited_Project.Login;
using Better_Limited_Project.ProductUtility.InwardGoodsUtility.Entity;
using Better_Limited_Project.ProductUtility.InwardGoodsUtility.Repository;
using Better_Limited_Project.StaffUtility.StaffEntity;

namespace Better_Limited_Project.ProductUtility.InwardGoodsUtility.UI
{
    public partial class InwardGoodsRecordListForm : Form
    {
        private List<InwardGoods> _inwardGoodsList;

        public InwardGoodsRecordListForm()
        {
            _inwardGoodsList = InwardGoodsRepository.GetAll().ToList();
            InitializeComponent();
            Load += (_, _) => Initialize();
        }

        private void Initialize()
        {
            if (LoginSession.GetSession().CurrentStaff.Title is not StaffTitle.ReceivingClerk)
                btnReceiveGoods.Visible = false;
            tbSearchBox.TextChanged += (_, _) => FilterDgv();
            PopulateDgv(_inwardGoodsList);
        }

        private void FilterDgv()
        {
            string searchKeywords = tbSearchBox.Text.Trim().ToLower();
            var filteredList = _inwardGoodsList
                .Where(ig => ig.PurchaseOrder.PurchaseOrderNumber.ToLower().Contains(searchKeywords));
            PopulateDgv(filteredList.ToList());
        }

        private void PopulateDgv(List<InwardGoods> inwardGoodsList)
        {
            dgvInwardGoods.Rows.Clear();
            inwardGoodsList.ForEach(ig => dgvInwardGoods.Rows.Add(ig.Id,
                ig.PurchaseOrder.PurchaseOrderNumber, ig.ReceivedOn, 
                !ig.PurchaseOrder.GetNotYetReceivedProducts().Any() ? "Yes" : "No"));
            dgvInwardGoods.Sort(receivedOnColumn, ListSortDirection.Descending);
        }

        private void btnNewRecord_Click(object sender, System.EventArgs e)
        {
            var form = new NewInwardGoodsRecordForm();
            var result = form.ShowDialog();
            if (result is DialogResult.OK)
                RefreshDgv();
        }

        private void RefreshDgv()
        {
            _inwardGoodsList = InwardGoodsRepository.GetAll().ToList();
            Initialize();
        }

        private void dgvInwardGoods_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var selected = _inwardGoodsList.Find(ig => ig.Id == dgvInwardGoods.Rows[e.RowIndex].Cells[idColumn.Name].Value.ToString());
            var form = new InwardGoodsDetailsForm(selected);
            var result = form.ShowDialog();
            if (result is DialogResult.OK)
                RefreshDgv();
        }
    }
}
