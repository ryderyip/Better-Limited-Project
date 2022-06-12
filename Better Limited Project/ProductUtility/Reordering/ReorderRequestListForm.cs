using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Better_Limited_Project.ProductUtility.Reordering.Controller;
using Better_Limited_Project.Tools;

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
            dgvReorderRequests.RowsAdded += (_, args) => HighLightNewRow(args.RowIndex);
            PopulateDgv(_requests);
        }

        private void HighLightNewRow(int rowIndex)
        {
            dgvReorderRequests.Rows[rowIndex].DefaultCellStyle.BackColor = FormColors.DgvRowAttention;
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
            var result = form.ShowDialog();
            if (result is DialogResult.OK)
                RefreshForm();
        }

        private void btnNewRequest_Click(object sender, System.EventArgs e)
        {
            var form = new NewReorderRestockRequestForm(new ReorderService());
            var result = form.ShowDialog();
            if (result is not DialogResult.OK)
                return;
            RefreshForm();
        }

        private void RefreshForm()
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
