using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Better_Limited_Project.ProductUtility.GoodsPurchasing.Entity;
using Better_Limited_Project.ProductUtility.GoodsPurchasing.Repository;

namespace Better_Limited_Project.ProductUtility.InwardGoodsUtility.UI
{
    public partial class PurchaseOrderPickerForm : Form
    {
        private readonly List<PurchaseOrder> _purchaseOrders;
        public PurchaseOrder? SelectedPurchaseOrder { get; private set; }

        public PurchaseOrderPickerForm(PurchaseOrder? purchaseOrder = null)
        {
            _purchaseOrders = PurchaseOrderRepository.GetAll().Where(po => po.IsApproved() && po.GetNotYetReceivedProducts().Any()).ToList();
            SelectedPurchaseOrder = purchaseOrder;
            StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
            Shown += (_, _) => Initialize();
        }

        private void Initialize()
        {
            dgvPurchaseOrders.SelectionChanged +=
                (_, _) => btnSelect.Enabled = dgvPurchaseOrders.SelectedRows.Count != 0;
            PopulateDgv(_purchaseOrders);
            btnSelect.Enabled = dgvPurchaseOrders.Rows.Count != 0;
            if (SelectedPurchaseOrder != null)
                SelectPreselectedRow(SelectedPurchaseOrder.Id);
        }

        private void SelectPreselectedRow(string preselectedPurchaseOrderId)
        {
            dgvPurchaseOrders.Rows.Cast<DataGridViewRow>()
                .First(r => r.Cells[idColumn.Name].Value.ToString() == preselectedPurchaseOrderId)
                .Selected = true;
        }

        private void PopulateDgv(List<PurchaseOrder> purchaseOrders)
        {
            dgvPurchaseOrders.Rows.Clear();
            purchaseOrders.ForEach(po => dgvPurchaseOrders.Rows.Add(po.Id,
                po.PurchaseOrderNumber, po.ReorderRequest.RequestNumber, 
                po.CreatedOn.ToString("g"),
                po.ApprovedOn!.Value.ToString("g")));
        }

        private void dgvPurchaseOrders_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            PickPurchaseOrderAndExit(e.RowIndex);
        }

        private void PickPurchaseOrderAndExit(int rowIndex)
        {
            string id = dgvPurchaseOrders.Rows[rowIndex].Cells[idColumn.Name].Value.ToString();
            if (SelectedPurchaseOrder != null && SelectedPurchaseOrder.Id == id)
                DialogResult = DialogResult.Ignore;
            SelectedPurchaseOrder = _purchaseOrders.First(po => po.Id == id);
            DialogResult = DialogResult.OK;
        }

        private void btnSelect_Click(object sender, System.EventArgs e)
        {
            PickPurchaseOrderAndExit(dgvPurchaseOrders.SelectedRows[0].Index);
        }

        private void tbSearchBox_TextChanged(object sender, System.EventArgs e)
        {
            string searchKeywords = tbSearchBox.Text.Trim().ToLower();
            var filteredPurchaseOrders = _purchaseOrders.Where(po =>
                po.PurchaseOrderNumber.ToLower().Contains(searchKeywords)
                || po.ReorderRequest.RequestNumber.ToLower().Contains(searchKeywords));
            PopulateDgv(filteredPurchaseOrders.ToList());
        }
    }
}
