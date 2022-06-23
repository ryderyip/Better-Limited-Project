using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Better_Limited_Project.Login;
using Better_Limited_Project.ProductUtility.Reordering.Controller;
using Better_Limited_Project.ProductUtility.Reordering.Entity;
using Better_Limited_Project.ProductUtility.Reordering.Repository;
using Better_Limited_Project.StaffUtility.StaffEntity;
using Better_Limited_Project.Tools;

namespace Better_Limited_Project.ProductUtility.Reordering.UI
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
            if (LoginSession.GetSession().CurrentStaff.Department is not Department.Inventory)
                btnNewRequest.Visible = false;
            dgvReorderRequests.RowsAdded += (_, args) => HighLightNewRow(args.RowIndex);
            cbShowApproved.CheckedChanged += (_, _) => FilterDgv();
            tbSearchBox.TextChanged += (_, _) => FilterDgv();
            FilterDgv();
        }

        private void HighLightNewRow(int rowIndex)
        {
            foreach (DataGridViewRow row in dgvReorderRequests.Rows)
            {
                if (row.Index == rowIndex)
                    row.DefaultCellStyle.BackColor = FormColors.DgvRowAttention;
                row.DefaultCellStyle.BackColor = Color.White;
            }
        }

        private void PopulateDgv(List<ReorderRequest> requests)
        {
            dgvReorderRequests.Rows.Clear();
            requests.ForEach(r => dgvReorderRequests.Rows.Add(r.Id,
                r.RequestNumber, r.IsApproved() ? "Yes" : "No", r.RequestedOn.ToString("g")));
            dgvReorderRequests.Sort(requestedOnColumn, ListSortDirection.Descending);
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

        private void btnNewRequest_Click(object sender, EventArgs e)
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

        private void FilterDgv()
        {
            PopulateDgv(_requests.FindAll(r => (cbShowApproved.Checked || !r.IsApproved())
                                               && r.RequestNumber.ToLower()
                                                   .Contains(tbSearchBox.Text.ToLower().Trim())));
        }
    }
}