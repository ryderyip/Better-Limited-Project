using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Better_Limited_Project.ServiceUtility.Delivery.Entity;
using Better_Limited_Project.ServiceUtility.Delivery.Repository;

namespace Better_Limited_Project.ServiceUtility.Delivery.UI
{
    public partial class CourierListForm : Form
    {
        private List<Courier> _couriers;

        public CourierListForm()
        {
            _couriers = CourierRepository.GetAll().ToList();
            InitializeComponent();
            Shown += (_, _) => Initialize();
        }

        private void Initialize()
        {
            PopulateDgv(_couriers);
        }

        private void PopulateDgv(List<Courier> couriers)
        {
            dgvCouriers.Rows.Clear();
            couriers.ForEach(c => dgvCouriers.Rows.Add(c.Id, c.Name, c.Phone, c.HiredOn.ToLongDateString()));
        }

        private void btnNewCourier_Click(object sender, EventArgs e)
        {
            
        }

        private void dgvCouriers_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void tbSearchBox_TextChanged(object sender, EventArgs e)
        {
            string searchKeyword = tbSearchBox.Text.ToLower().Trim();
            var filtered = _couriers.Where(c => c.Name.ToLower().Contains(searchKeyword)
                                                || c.Phone.Contains(searchKeyword));
            PopulateDgv(filtered.ToList());
        }
    }
}
