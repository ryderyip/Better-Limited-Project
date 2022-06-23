using System;
using System.Windows.Forms;
using Better_Limited_Project.ProductUtility.Restocking.Controller;
using Better_Limited_Project.ProductUtility.Restocking.Entity;

namespace Better_Limited_Project.ProductUtility.Restocking.UI
{
    public partial class RestockDeliveryDetailsForm : Form
    {
        private readonly RestockDelivery _restockDelivery;

        public RestockDeliveryDetailsForm(RestockDelivery restockDelivery)
        {
            _restockDelivery = restockDelivery;
            StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
            Load += (_, _) => Initialze();
        }

        private void Initialze()
        {
            tbScheduledDateTime.Text = _restockDelivery.DepartureScheduledOn.ToString("D");
            PopulateCouriersDgv();
            PopulateGoodsToDeliverDgv();
        }

        private void PopulateGoodsToDeliverDgv()
        {
            dgvGoodsToDeliver.Rows.Clear();
            foreach (var restockRequest in _restockDelivery.RestockRequests)
            foreach (var requestedProduct in restockRequest.RequestedProducts)
                dgvGoodsToDeliver.Rows.Add(restockRequest.Id,
                    restockRequest.RequestNumber,
                    restockRequest.RequestedForRetailStore.Name,
                    requestedProduct.Product.Name,
                    requestedProduct.Quantity,
                    restockRequest.IsReceived() ? "Yes" : "Not Yet");
        }

        private void PopulateCouriersDgv()
        {
            dgvCouriers.Rows.Clear();
            foreach (var courier in _restockDelivery.Couriers)
                dgvCouriers.Rows.Add(courier.Name, courier.Phone);
        }

        private void btnDeliveryNote_Click(object sender, EventArgs e)
        {
            var generator = new RestockDeliveryNoteGenerator(_restockDelivery);
            generator.GenerateAndOpen();
        }
    }
}