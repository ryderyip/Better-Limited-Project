using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Better_Limited_Project.ServiceUtility.DeliveryUtility.Entity;

namespace Better_Limited_Project.ServiceUtility.DeliveryUtility.UI
{
    public partial class CourierSelectorForm : Form
    {
        private readonly List<Courier> _couriers;
        public EventHandler<List<Courier>>? CouriersSelected;

        public CourierSelectorForm(IEnumerable<Courier> freeCouriers)
        {
            InitializeComponent();
            _couriers = freeCouriers.ToList();
            Shown += (_, _) => PopulateDgv(_couriers);
        }

        private void PopulateDgv(List<Courier> couriers)
        {
            couriers.ForEach(c => dgvCouriers.Rows.Add(c.Id, c.Name, c.Phone));
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (dgvCouriers.SelectedRows.Count == 0)
            {
                MessageBox.Show(DeliveryStringResources.cant_choose_0_courier);
                return;
            }

            var selectedCouriers = dgvCouriers.SelectedRows.Cast<DataGridViewRow>()
                .Select(row => row.Cells[idColumn.Name].Value.ToString())
                .Select(id => _couriers.Find(c => c.Id == id));

            CouriersSelected?.Invoke(this, selectedCouriers.ToList());
            Close();
        }
    }
}