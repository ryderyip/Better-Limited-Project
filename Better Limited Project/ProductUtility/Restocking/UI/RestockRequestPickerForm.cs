using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Better_Limited_Project.ProductUtility.Restocking.Entity;

namespace Better_Limited_Project.ProductUtility.Restocking.UI
{
    public partial class RestockRequestPickerForm : Form
    {
        private readonly List<RestockRequest> _restockRequests;
        public event EventHandler<IEnumerable<RestockRequest>>? Finished;
        
        public RestockRequestPickerForm(IEnumerable<RestockRequest> restockRequests, 
            IEnumerable<RestockRequest>? preselected = null)
        {
            _restockRequests = restockRequests.ToList();
            StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
            Load += (_, _) => Initialize(preselected);
        }

        private void Initialize(IEnumerable<RestockRequest>? preselected)
        {
            dgvRestockRequests.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            btnConfirm.Click += BtnConfirmOnClick;
            btnConfirm.Enabled = false;
            dgvRestockRequests.SelectionChanged += (_, _) => EnableOrDisableConfirmButton();
            foreach (var restockRequest in _restockRequests)
                dgvRestockRequests.Rows.Add(restockRequest.Id, restockRequest.RequestNumber, 
                    restockRequest.RequestedForRetailStore.Name, restockRequest.RequestedOn.ToString("g"));
            if (preselected != null)
                HighlightPreselectedRows(preselected);
        }

        private void BtnConfirmOnClick(object sender, EventArgs e)
        {
            if (dgvRestockRequests.Rows.Count == 0)
                return;
            Finished?.Invoke(this, GetSelected());
            Close();
        }

        private IEnumerable<RestockRequest> GetSelected()
        {
            return from DataGridViewRow row in dgvRestockRequests.Rows
                where row.Selected
                select _restockRequests.Find(rr => rr.Id == row.Cells[idColumn.Name].Value.ToString());
        }

        private void HighlightPreselectedRows(IEnumerable<RestockRequest> preselected)
        {
            var preselectedList = preselected.ToList();
            foreach (DataGridViewRow row in dgvRestockRequests.Rows)
                if (preselectedList.Any(rr => rr.Id == row.Cells[idColumn.Name].Value.ToString()))
                    row.Selected = true;
        }

        private void EnableOrDisableConfirmButton()
        {
            btnConfirm.Enabled = dgvRestockRequests.SelectedRows.Count != 0;
        }
    }
}
