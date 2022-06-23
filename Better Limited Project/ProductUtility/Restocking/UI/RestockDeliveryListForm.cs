using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Better_Limited_Project.ProductUtility.Restocking.Entity;
using Better_Limited_Project.ProductUtility.Restocking.Repository;

namespace Better_Limited_Project.ProductUtility.Restocking.UI
{
    public partial class RestockDeliveryListForm : Form
    {
        private List<RestockDelivery> _restockDeliveries;

        public RestockDeliveryListForm()
        {
            _restockDeliveries = RestockDeliveryRepository.GetAll().ToList();
            InitializeComponent();
            Load += (_, _) => Initialize();
        }

        private void Initialize()
        {
            dtpDateCreated.Enabled = false;
            cbSearchByDateCreated.CheckedChanged += (_, _) => dtpDateCreated.Enabled = cbSearchByDateCreated.Checked;
            cbSearchByDateCreated.CheckedChanged += (_, _) => FilterDgv();
            dtpDateCreated.ValueChanged += (_, _) => FilterDgv();
            PopulateDgv(_restockDeliveries);
        }

        private void FilterDgv()
        {
            var dateCreated = dtpDateCreated.Value.Date;
            var filtered = cbSearchByDateCreated.Checked
                ? _restockDeliveries.Where(rd => rd.CreatedOn.Date == dateCreated)
                : _restockDeliveries;
            PopulateDgv(filtered);
        }

        private void PopulateDgv(IEnumerable<RestockDelivery> restockDeliveries)
        {
            dgvRestockDeliveries.Rows.Clear();
            foreach (var delivery in restockDeliveries)
                dgvRestockDeliveries.Rows.Add(delivery.Id,
                    delivery.CreatedOn.ToString("f"),
                    delivery.DepartureScheduledOn.ToString("f"));
        }

        private void btnRestockRequests_Click(object sender, EventArgs e)
        {
            var form = new RestockRequestListForm();
            form.Updated += (_, _) => RefreshDgv();
            form.ShowDialog();
        }

        private void RefreshDgv()
        {
            _restockDeliveries = RestockDeliveryRepository.GetAll().ToList();
            FilterDgv();
        }

        private void dgvRestockDeliveries_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var restockDelivery = _restockDeliveries.Find(rd =>
                rd.Id == dgvRestockDeliveries.Rows[e.RowIndex].Cells[idColumn.Name].Value.ToString());
            var form = new RestockDeliveryDetailsForm(restockDelivery);
            form.ShowDialog();
        }
    }
}