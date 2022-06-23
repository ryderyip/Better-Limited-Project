using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Better_Limited_Project.ProductUtility.Restocking.Controller;
using Better_Limited_Project.ProductUtility.Restocking.Entity;
using Better_Limited_Project.ProductUtility.Restocking.Repository;
using Better_Limited_Project.ServiceUtility.DeliveryUtility.Entity;
using Better_Limited_Project.ServiceUtility.DeliveryUtility.Repository;
using Better_Limited_Project.SettingsUtility;
using Better_Limited_Project.StaffUtility.StaffEntity;

namespace Better_Limited_Project.ProductUtility.Restocking.UI
{
    public partial class ArrangeRestockForm : Form
    {
        public ArrangeRestockForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            Load += (_, _) => Initialize();
        }

        private void Initialize()
        {
            btnChooseRequests.Click += btnChooseRequests_Click;
            btnArrange.Click += btnArrange_Click;
            btnChooseCouriers.Click += btnChooseCouriers_Click;
            btnArrange.Enabled = false;
            dgvRestockRequests.Rows.CollectionChanged += (_, _) => PopulateGoodsToDeliverDgv();
            dgvRestockRequests.Rows.CollectionChanged += (_, _) => EnableArrangeButtonIfHaveSelectedRequestAndCourier();
            dgvCouriers.Rows.CollectionChanged += (_, _) => EnableArrangeButtonIfHaveSelectedRequestAndCourier();
            dtpDeliverAt.ValueChanged += (_, _) => ClearSelectedCouriers();
            dtpDeliverOn.ValueChanged += (_, _) => ClearSelectedCouriers();
            dtpDeliverOn.MinDate = DateTime.Today + TimeSpan.FromDays(1);
            dtpDeliverOn.Value = dtpDeliverOn.MinDate;
            dtpDeliverOn.MaxDate = DateTime.Today + TimeSpan.FromDays(30);
            dtpDeliverAt.MinDate = DateTime.Today.Date + TimeSpan.FromHours(9);
            dtpDeliverAt.MaxDate = DateTime.Today.Date + TimeSpan.FromHours(22);
            dtpDeliverAt.Value = dtpDeliverAt.MinDate;
        }

        private void ClearSelectedCouriers()
        {
            dgvCouriers.Rows.Clear();
        }

        private void btnChooseCouriers_Click(object sender, EventArgs e)
        {
            var selectedDate = dtpDeliverOn.Value.Date;
            var couriersFreeOnSelectedDate = CourierRepository.FindAll(c => c.IsFreeOn(selectedDate));
            var form = new CourierPickerForm(couriersFreeOnSelectedDate);
            form.Finished += (_, selectedCouriers) => PopulateCourierDgv(selectedCouriers);
            form.ShowDialog();
        }

        private void PopulateCourierDgv(IEnumerable<Courier> selectedCouriers)
        {
            dgvCouriers.Rows.Clear();
            foreach (var selectedCourier in selectedCouriers)
                dgvCouriers.Rows.Add(selectedCourier.Id, selectedCourier.Name, selectedCourier.Phone);
        }

        private void EnableArrangeButtonIfHaveSelectedRequestAndCourier()
        {
            btnArrange.Enabled = dgvRestockRequests.Rows.Count != 0 && dgvCouriers.Rows.Count != 0;
        }

        private void PopulateGoodsToDeliverDgv()
        {
            dgvGoodsToDeliver.Rows.Clear();
            dgvGoodsToDeliver.ClearSelection();
            foreach (DataGridViewRow row in dgvRestockRequests.Rows)
            {
                var restockRequest =
                    RestockRequestRepository.FindById(row.Cells[restockRequestIdColumn.Name].Value.ToString());
                string retailStoreName = row.Cells[retailStoreNameColumn.Name].Value.ToString();
                foreach (var requestedProduct in restockRequest.RequestedProducts)
                {
                    var rowIndex = dgvGoodsToDeliver.Rows.Add(retailStoreName,
                        requestedProduct.Product.Name, requestedProduct.Quantity);
                    dgvGoodsToDeliver.Rows[rowIndex].Selected = true;
                }
            }
        }

        private void btnChooseRequests_Click(object sender, EventArgs e)
        {
            var requests = RestockRequestRepository.GetAll().Where(rr => !rr.IsArranged());
            var form = new RestockRequestPickerForm(requests);
            form.Finished += (_, selectedRequests) => PopulateRestockRequestDgv(selectedRequests);
            form.ShowDialog();
        }

        private void PopulateRestockRequestDgv(IEnumerable<RestockRequest> selectedRequests)
        {
            dgvRestockRequests.Rows.Clear();
            foreach (var selectedRequest in selectedRequests)
                dgvRestockRequests.Rows.Add(selectedRequest.Id, selectedRequest.RequestNumber,
                    selectedRequest.RequestedForRetailStore.Name);
        }

        private void btnArrange_Click(object sender, EventArgs e)
        {
            var deliveryDateTime = dtpDeliverOn.Value.Date + dtpDeliverAt.Value.TimeOfDay;
            if (deliveryDateTime.DayOfWeek is DayOfWeek.Sunday)
            {
                MessageBox.Show("Sunday is company holiday and will not have deliveries. Please choose another day.");
                return;
            }

            var currentWarehouse = (Warehouse) UserSettings.GetSettings().Workplace!;
            var service = new RestockArrangingService(currentWarehouse, deliveryDateTime);
            foreach (var restockRequest in GetSelectedRestockRequests())
                service.AddRestockRequest(restockRequest);
            foreach (var courier in GetSelectedCourier())
                service.AddCourier(courier);
            service.Arrange();
            DialogResult = DialogResult.OK;
        }

        private IEnumerable<Courier> GetSelectedCourier()
        {
            return from DataGridViewRow row in dgvCouriers.Rows
                select CourierRepository.FindById(row.Cells[courierIdColumn.Name].Value.ToString());
        }

        private IEnumerable<RestockRequest> GetSelectedRestockRequests()
        {
            return from DataGridViewRow row
                    in dgvRestockRequests.Rows
                select RestockRequestRepository.FindById(row.Cells[restockRequestIdColumn.Name].Value.ToString());
        }
    }
}