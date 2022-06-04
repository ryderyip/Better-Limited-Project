using System;
using System.Windows.Forms;
using Better_Limited_Project.Sales.OrderPlacing.Entity;
using Better_Limited_Project.Tools;

namespace Better_Limited_Project.ServiceUtility.Delivery.UI
{
    public partial class DeliveryDetailsForm : Form
    {
        public event EventHandler? DeliveryUpdated;
        private readonly Delivery _delivery;

        public DeliveryDetailsForm(Delivery delivery)
        {
            _delivery = delivery;
            InitializeComponent();
            Shown += (_, _) => Initialize();
        }

        private void Initialize()
        {
            if (_delivery.DispatchedOn != null)
                btnSetAsDispatched.Enabled = false;
            if (_delivery.DeliveredOn != null)
                btnSetAsDelivered.Enabled = false;
            
            FillFields();
        }

        private void FillFields()
        {
            tbCreatedOn.Text = _delivery.CreatedOn.ToString("f");
            tbScheduledOn.Text = _delivery.ScheduledOn.ToString("f");
            tbDispatchedOn.Text = _delivery.DispatchedOn?.ToString("f") ?? "Not yet dispatched";
            tbDeliveredOn.Text = _delivery.DeliveredOn?.ToString("f") ?? "Not yet delivered";
            tbDeliveryStatus.Text = EnumToStringHelper.GetDisplayValue(_delivery.DeliveryStatus);
        }

        private void btnViewDeliveryRequest_Click(object sender, EventArgs e)
        {
            var form = new DeliveryRequestDetailsForm(_delivery.GetDeliveryRequest());
            form.StartPosition = FormStartPosition.CenterScreen;
            form.ShowDialog();
        }

        private void btnUpdateDelivery_Click(object sender, EventArgs e)
        {
            var form = new UpdateDeliveryForm(_delivery);
            form.StartPosition = FormStartPosition.CenterScreen;
            form.Updated += (_, _) => Initialize();
            form.ShowDialog();
            DeliveryUpdated?.Invoke(this, EventArgs.Empty);
        }

        private void btnSetAsDispatched_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Confirm setting dispatch time?", "Set Dispatch Time",
                MessageBoxButtons.YesNo);
            if (result is DialogResult.No)
                return;
            _delivery.DispatchedOn = DateTime.Now;
            _delivery.DeliveryStatus = DeliveryStatus.InTransit;
            _delivery.Save();
            Initialize();
            DeliveryUpdated?.Invoke(this, EventArgs.Empty);
        }

        private void btnSetAsDelivered_Click(object sender, EventArgs e)
        {
            if (_delivery.DeliveredOn != null)
                return;
            var result = MessageBox.Show("Confirm setting delivery time along with dispatch time?", "Set Time Delivered",
                MessageBoxButtons.YesNo);
            if (result is DialogResult.No)
                return;
            _delivery.DispatchedOn ??= DateTime.Now;
            _delivery.DeliveredOn = DateTime.Now;
            _delivery.DeliveryStatus = DeliveryStatus.Delivered;
            _delivery.Save();
            Initialize();
            DeliveryUpdated?.Invoke(this, EventArgs.Empty);
        }
    }
}