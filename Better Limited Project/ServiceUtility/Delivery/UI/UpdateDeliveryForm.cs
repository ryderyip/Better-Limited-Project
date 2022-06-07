using System;
using System.Windows.Forms;

namespace Better_Limited_Project.ServiceUtility.Delivery.UI
{
    public partial class UpdateDeliveryForm : Form
    {
        public event EventHandler? Updated;
        private readonly Delivery _delivery;

        public UpdateDeliveryForm(Delivery delivery)
        {
            _delivery = delivery;
            InitializeComponent();
            Shown += (_, _) => Initialize();
        }

        private void Initialize()
        {
            FillFields();
            dtpNewDispatchedOnDateOrTime_ValueChanged(this, EventArgs.Empty);
            dtpNewDispatchedOnDate_ValueChanged(this, EventArgs.Empty);
        }

        private void FillFields()
        {
            tbScheduledOn.Text = _delivery.ScheduledOn.ToString("f");
            tbDispatchedOn.Text = _delivery.DispatchedOn?.ToString("f") ?? "Not yet dispatched";
            tbDeliveredOn.Text = _delivery.DeliveredOn?.ToString("f") ?? "Not yet delivered";
            
            dtpNewScheduledOnDate.Value = _delivery.ScheduledOn.Date;
            dtpNewScheduledOnTime.Value = _delivery.ScheduledOn;

            dtpNewScheduledOnDate.MinDate = Delivery.GetEarliestDeliveryDate(_delivery.GetDeliveryRequest().DeliverySession);
            dtpNewDispatchedOnDate.MinDate = DateTime.Today.Date - TimeSpan.FromDays(7);
            dtpNewDeliveredOnDate.MinDate = DateTime.Today.Date - TimeSpan.FromDays(7);
            
            dtpNewScheduledOnDate.MaxDate = dtpNewScheduledOnDate.MinDate + TimeSpan.FromDays(30);
            dtpNewDispatchedOnDate.MaxDate = DateTime.Today.Date;
            dtpNewDeliveredOnDate.MaxDate = DateTime.Today.Date;

            dtpNewScheduledOnTime.MinDate = dtpNewScheduledOnDate.MinDate;
            dtpNewDispatchedOnTime.MinDate = dtpNewDispatchedOnDate.MinDate;
            dtpNewDeliveredOnTime.MinDate = dtpNewDispatchedOnTime.MinDate;
            
            dtpNewScheduledOnTime.MaxDate = dtpNewScheduledOnDate.MaxDate + TimeSpan.FromDays(1);
            dtpNewDispatchedOnTime.MaxDate = dtpNewDispatchedOnDate.MaxDate + TimeSpan.FromDays(1);
            dtpNewDeliveredOnTime.MaxDate = dtpNewDeliveredOnDate.MaxDate + TimeSpan.FromDays(1);
            
            DisableUnneededButtons();
        }

        private void DisableUnneededButtons()
        {
            if (_delivery.DispatchedOn != null || _delivery.DeliveredOn != null)
            {
                dtpNewScheduledOnDate.Enabled = false;
                dtpNewScheduledOnTime.Enabled = false;
            }

            if (_delivery.DispatchedOn != null)
            {
                dtpNewDispatchedOnDate.Value = _delivery.DispatchedOn.Value.Date;
                dtpNewDispatchedOnTime.Value = _delivery.DispatchedOn.Value;
            }
            else
            {
                dtpNewDispatchedOnDate.Enabled = false;
                dtpNewDispatchedOnTime.Enabled = false;
            }

            if (_delivery.DeliveredOn != null)
            {
                dtpNewDeliveredOnDate.Value = _delivery.DeliveredOn.Value.Date;
                dtpNewDeliveredOnTime.Value = _delivery.DeliveredOn.Value;
            }
            else
            {
                dtpNewDeliveredOnDate.Enabled = false;
                dtpNewDeliveredOnTime.Enabled = false;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var scheduledOn = dtpNewScheduledOnDate.Value.Date + dtpNewScheduledOnTime.Value.TimeOfDay;
            var dispatchedOn = dtpNewDispatchedOnDate.Value.Date + dtpNewDispatchedOnTime.Value.TimeOfDay;
            var deliveredOn = dtpNewDeliveredOnDate.Value.Date + dtpNewDeliveredOnTime.Value.TimeOfDay;

            _delivery.ScheduledOn = scheduledOn;
            _delivery.DispatchedOn = dispatchedOn;
            _delivery.DeliveredOn = deliveredOn;
            
            _delivery.Save();
            Close();
            Updated?.Invoke(this, EventArgs.Empty);
        }

        private void dtpNewDispatchedOnDateOrTime_ValueChanged(object sender, EventArgs e)
        {
            dtpNewDeliveredOnDate.MinDate = dtpNewDispatchedOnDate.Value.Date;
        }

        private void dtpNewDispatchedOnDate_ValueChanged(object sender, EventArgs e)
        {
            if (dtpNewDispatchedOnDate.Value.Date == dtpNewDeliveredOnDate.Value.Date)
                dtpNewDeliveredOnTime.MinDate = dtpNewDispatchedOnTime.Value;
            else
                dtpNewDeliveredOnTime.MinDate = dtpNewDeliveredOnDate.Value.Date;
        }

        private void dtpNewDeliveredOnDate_ValueChanged(object sender, EventArgs e)
        {
            if (dtpNewDispatchedOnDate.Value.Date == dtpNewDeliveredOnDate.Value.Date)
                dtpNewDeliveredOnTime.MinDate = dtpNewDispatchedOnTime.Value;
            else
                dtpNewDeliveredOnTime.MinDate = dtpNewDeliveredOnDate.Value.Date;
        }

        private void dtpNewDispatchedOnTime_ValueChanged(object sender, EventArgs e)
        {
            if (dtpNewDispatchedOnDate.Value.Date == dtpNewDeliveredOnDate.Value.Date)
                dtpNewDeliveredOnTime.MinDate = dtpNewDispatchedOnTime.Value;
        }
    }
}
