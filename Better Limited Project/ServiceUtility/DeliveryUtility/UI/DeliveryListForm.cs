using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using Better_Limited_Project.ServiceUtility.DeliveryUtility.Entity;
using Better_Limited_Project.ServiceUtility.DeliveryUtility.Repository;
using Better_Limited_Project.Tools;

namespace Better_Limited_Project.ServiceUtility.DeliveryUtility.UI
{
    public partial class DeliveryListForm : Form
    {
        private List<Delivery> _deliveries;

        public DeliveryListForm()
        {
            _deliveries = DeliveryRepository.GetAll().ToList();
            InitializeComponent();
            Shown += (_, _) => Initialize();
        }

        private void Initialize()
        {
            PopulateDgvDeliveries(_deliveries);
        }

        private void PopulateDgvDeliveries(List<Delivery> deliveryList)
        {
            dgvDeliveries.Rows.Clear();
            deliveryList.ForEach(delivery => dgvDeliveries.Rows.Add(delivery.Id, delivery.DeliveryRequestId,
                delivery.GetSalesOrder().OrderNumber,
                EnumToStringHelper.GetDisplayValue(delivery.DeliveryStatus),
                $"{delivery.GetLastUpdatedTime().ToShortDateString()} | {delivery.GetLastUpdatedTime().ToShortTimeString()}",
                delivery.GetDeliveryRequest().GetArrangedByStaff()?.Name ?? "-"));
            dgvDeliveries.Sort(updatedOnColumn, ListSortDirection.Descending);
        }

        private void tbSearchBox_TextChanged(object sender, EventArgs e)
        {
            string searchKeyword = tbSearchBox.Text.ToLower().Trim();
            var filteredDeliveries =
                _deliveries.Where(d => d.GetSalesOrder().OrderNumber.ToLower().Contains(searchKeyword));
            PopulateDgvDeliveries(filteredDeliveries.ToList());
        }

        private void dgvDeliveries_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string selectedDeliveryId = dgvDeliveries.Rows[e.RowIndex].Cells[idColumn.Name].Value.ToString();
            var selectedDelivery = _deliveries.Find(d => d.Id == selectedDeliveryId);
            var form = new DeliveryDetailsForm(selectedDelivery);
            form.StartPosition = FormStartPosition.CenterScreen;
            form.DeliveryUpdated += (_, _) =>
            {
                _deliveries = DeliveryRepository.GetAll().ToList();
                Initialize();
            };
            form.ShowDialog();
        }

        private void btnDailyDeliveryList_Click(object sender, EventArgs e)
        {
            var form = new DailyDeliveryListForm();
            form.StartPosition = FormStartPosition.CenterScreen;
            form.ShowDialog();
        }

        private void btnDeliveryRequests_Click(object sender, EventArgs e)
        {
            var form = new DeliveryRequestListForm();
            form.StartPosition = FormStartPosition.CenterScreen;
            form.ShowDialog();
        }
    }
}