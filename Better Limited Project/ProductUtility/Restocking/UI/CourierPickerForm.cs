using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Better_Limited_Project.ServiceUtility.DeliveryUtility.Entity;

namespace Better_Limited_Project.ProductUtility.Restocking.UI
{
    public partial class CourierPickerForm : Form
    {
        private readonly List<Courier> _couriers;

        public CourierPickerForm(IEnumerable<Courier> couriers, IEnumerable<Courier>? preselected = null)
        {
            _couriers = couriers.ToList();
            StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
            Load += (_, _) => Initialize(preselected);
        }

        public event EventHandler<IEnumerable<Courier>>? Finished;

        private void Initialize(IEnumerable<Courier>? preselected)
        {
            dgvCouriers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            btnConfirm.Click += BtnConfirmOnClick;
            btnConfirm.Enabled = false;
            dgvCouriers.SelectionChanged += (_, _) => EnableOrDisableConfirmButton();
            foreach (var courier in _couriers)
                dgvCouriers.Rows.Add(courier.Id, courier.Name, courier.Phone);
            if (preselected != null)
                HighlightPreselectedRows(preselected);
        }

        private void BtnConfirmOnClick(object sender, EventArgs e)
        {
            if (dgvCouriers.Rows.Count == 0)
                return;
            Finished?.Invoke(this, GetSelected());
            Close();
        }

        private IEnumerable<Courier> GetSelected()
        {
            return from DataGridViewRow row in dgvCouriers.Rows
                where row.Selected
                select _couriers.Find(c => c.Id == row.Cells[idColumn.Name].Value.ToString());
        }

        private void HighlightPreselectedRows(IEnumerable<Courier> preselected)
        {
            var preselectedList = preselected.ToList();
            foreach (DataGridViewRow row in dgvCouriers.Rows)
                if (preselectedList.Any(rr => rr.Id == row.Cells[idColumn.Name].Value.ToString()))
                    row.Selected = true;
        }

        private void EnableOrDisableConfirmButton()
        {
            btnConfirm.Enabled = dgvCouriers.SelectedRows.Count != 0;
        }
    }
}