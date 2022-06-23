using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using Better_Limited_Project.Login;
using Better_Limited_Project.ProductUtility.Entity;
using Better_Limited_Project.ProductUtility.Reordering.UI;
using Better_Limited_Project.ProductUtility.Restocking.Entity;
using Better_Limited_Project.ProductUtility.Restocking.Repository;
using Better_Limited_Project.StaffUtility.StaffEntity;

namespace Better_Limited_Project.ProductUtility.Restocking.UI
{
    public partial class RestockRequestListForm : Form
    {
        public event EventHandler? Updated;
        private List<RestockRequest> _restockRequests;

        public RestockRequestListForm()
        {
            StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
            _restockRequests = RestockRequestRepository.GetAll().ToList();
            Load += (_, _) => Initialize();
        }

        private void Initialize()
        {
            if (LoginSession.GetSession().CurrentStaff.Department is Department.Inventory)
                btnNewRequest.Visible = false;
            else
                btnArrangeRestock.Visible = false;
            btnArrangeRestock.Click += BtnArrangeRestockOnClick;
            btnNewRequest.Click += BtnNewRequestOnClick; 
            dgvRestockRequests.CellDoubleClick += (_, args) => DgvCellDoubleClicked(args.RowIndex);
            tbSearchBox.TextChanged += (_, _) => FilterDgv();
            PopulateDgv(_restockRequests);
        }

        private void BtnArrangeRestockOnClick(object sender, EventArgs e)
        {
            var form = new ArrangeRestockForm();
            var result = form.ShowDialog();
            if (result is not DialogResult.OK)
                return;
            RefreshDgv();
            Updated?.Invoke(this, EventArgs.Empty);
        }

        private void BtnNewRequestOnClick(object sender, EventArgs e)
        {
            var form = new NewReorderRestockRequestForm(new RestockService());
            var result = form.ShowDialog();
            if (result is not DialogResult.OK)
                return;
            RefreshDgv();
        }

        private void FilterDgv()
        {
            string searchKeyword = tbSearchBox.Text.Trim().ToLower();
            var filtered = _restockRequests.Where(rr => rr.RequestNumber.ToLower().Contains(searchKeyword));
            PopulateDgv(filtered);
        }

        private void DgvCellDoubleClicked(int rowIndex)
        {
            var restockRequest = _restockRequests.Find(rr =>
                rr.Id == dgvRestockRequests.Rows[rowIndex].Cells[idColumn.Name].Value.ToString());
            var form = new RestockRequestDetailsForm(restockRequest);
            form.Updated += (_, _) => RefreshDgv();
            form.ShowDialog();
        }

        private void RefreshDgv()
        {
            _restockRequests = RestockRequestRepository.GetAll().ToList();
            FilterDgv();
        }

        private void PopulateDgv(IEnumerable<RestockRequest> restockRequests)
        {
            dgvRestockRequests.Rows.Clear();
            foreach (var restockRequest in restockRequests)
                dgvRestockRequests.Rows.Add(restockRequest.Id,
                    restockRequest.RequestNumber,
                    restockRequest.RequestedForRetailStore.Name,
                    restockRequest.RequestedOn.ToString("g"),
                    restockRequest.IsReceived() ? "Yes" : "No");
            dgvRestockRequests.Sort(requestedOnColumn, ListSortDirection.Descending);
        }
    }
}