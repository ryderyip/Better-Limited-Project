using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Better_Limited_Project.ServiceUtility.Reordering;

namespace Better_Limited_Project.ProductUtility.Reordering
{
    public partial class ReorderRequestListForm : Form
    {
        private List<ReorderRequest> _requests;

        public ReorderRequestListForm()
        {
            _requests = ReorderRequestRepository.GetAll().ToList();
            InitializeComponent();
            Shown += (_, _) => Initialize();
        }

        private void Initialize()
        {
            PopulateDgv(_requests);
        }

        private void PopulateDgv(List<ReorderRequest> requests)
        {
            dgvReorderRequests.Rows.Clear();
            requests.ForEach(r => dgvReorderRequests.Rows.Add(r.Id, 
                r.RequestNumber, r.IsApproved() ? "Yes" : "No", r.RequestedOn.ToString("g")));
        }

        private void dgvReorderRequest_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string id = dgvReorderRequests.Rows[e.RowIndex].Cells[idColumn.Name].Value.ToString();
            var selected = _requests.Find(r => r.Id == id);
            var form = new ReorderRequestDetailsForm(selected);
            form.ShowDialog();
        }

        private void btnNewRequest_Click(object sender, System.EventArgs e)
        {
            var form = new ReorderRequestSendingForm();
            var result = form.ShowDialog();
            if (result is not DialogResult.OK)
                return;
            RefreshDgv();
        }

        private void RefreshDgv()
        {
            _requests = ReorderRequestRepository.GetAll().ToList();
            Initialize();
        }

        private void tbSearchBox_TextChanged(object sender, System.EventArgs e)
        {
            PopulateDgv(_requests.FindAll(r => r.RequestNumber.ToLower().Contains(tbSearchBox.Text.ToLower().Trim())));
        }
    }
}
