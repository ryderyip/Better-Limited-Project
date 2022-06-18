using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Better_Limited_Project.Login;
using Better_Limited_Project.Sales.OrderPlacing.Controller;
using Better_Limited_Project.ServiceUtility.DeliveryUtility.Entity;
using Better_Limited_Project.ServiceUtility.DeliveryUtility.Repository;

namespace Better_Limited_Project.ServiceUtility.DeliveryUtility.UI
{
    public partial class ArrangeSingleDeliveryForm : Form, IArrangeDeliveryForm
    {
        public event EventHandler? SwitchFormClicked;
        public event EventHandler? DeliveryArranged;
        private readonly DeliveryRequest _deliveryRequest;
        private List<Courier> _selectedCouriers;

        public ArrangeSingleDeliveryForm(DeliveryRequest deliveryRequest, ICollection<Courier> selectedCouriers)
        {
            _deliveryRequest = deliveryRequest;
            InitializeComponent();
            _selectedCouriers = selectedCouriers.ToList();
        }

        private void OnFormShown(object sender, EventArgs e)
        {
            btnArrangeDelivery.Enabled = false;
            tbCustomerChosenDeliverySession.Text = _deliveryRequest.DeliverySession.ToString();
            var earliestDeliveryDate = Delivery.GetEarliestDeliveryDate(_deliveryRequest.DeliverySession);
            tbEarliestDeliveryDate.Text = earliestDeliveryDate.ToLongDateString();
            dtpSelectDeliveryDate.MinDate = earliestDeliveryDate;
            dtpSelectDeliveryDate.Value = dtpSelectDeliveryDate.MinDate;
            int daysInMonth = 30;
            dtpSelectDeliveryDate.MaxDate = dtpSelectDeliveryDate.MinDate + TimeSpan.FromDays(3 * daysInMonth);
            _deliveryRequest.GetSalesOrder().GetSalesOrderProducts().ToList()
                .ForEach(sop => dgvProductsDelivered.Rows.Add(sop.GetProduct().Name, sop.Quantity));
        }

        public void ShowForm()
        {
            StartPosition = FormStartPosition.CenterScreen;
            ShowDialog();
        }

        public void CloseForm()
        {
            Close();
        }

        private void btnChooseCourier_Click(object sender, EventArgs e)
        {
            var selectedDate = dtpSelectDeliveryDate.Value.Date;
            var freeCouriers = from courier in CourierRepository.GetAll()
                let deliveries = DeliveryCourierRepository.FindByCourierId(courier.Id)
                where !deliveries.Any() 
                      || deliveries.All(d => d.ScheduledOn == null)
                      || deliveries.All(d => d.ScheduledOn.Date != selectedDate)
                select courier;

            var courierSelector = new CourierSelectorForm(freeCouriers);
            courierSelector.CouriersSelected += (_, selectedCouriers) =>
            {
                _selectedCouriers = selectedCouriers;
                tbSelectedCourier.Text = string.Join(", ", selectedCouriers.Select(c => c.Name));
                btnArrangeDelivery.Enabled = _selectedCouriers.Any();
            };
            courierSelector.StartPosition = FormStartPosition.CenterScreen;
            courierSelector.ShowDialog();
        }


        private void btnSplitDelivery_Click(object sender, EventArgs e)
        {
            SwitchFormClicked?.Invoke(this, EventArgs.Empty);
        }

        private void btnArrangeDelivery_Click(object sender, EventArgs e)
        {
            if (_selectedCouriers.Count == 0)
            {
                MessageBox.Show(DeliveryStringResources.cant_choose_0_courier);
                return;
            }

            var scheduledOn = dtpSelectDeliveryDate.Value;

            if (scheduledOn.DayOfWeek is DayOfWeek.Sunday)
            {
                MessageBox.Show("Sunday is company holiday and will not have deliveries. Please choose another day.");
                return;
            }
            
            scheduledOn += _deliveryRequest.DeliverySessionTime;
            var delivery = new Entity.Delivery(_deliveryRequest.Id)
            {
                ScheduledOn = scheduledOn
            };
            delivery.Save();

            _selectedCouriers.Select(c => new DeliveryCourier(delivery.Id, c.Id))
                .ToList().ForEach(dc => dc.Save());

            _deliveryRequest.ArrangedOn = DateTime.Now;
            _deliveryRequest.ArrangedByStaffId = LoginSession.GetSession().CurrentStaff.Id;
            _deliveryRequest.Save();

            DeliveryArranged?.Invoke(this, EventArgs.Empty);
        }

        private void dtpSelectDeliveryDate_ValueChanged(object sender, EventArgs e)
        {
            _selectedCouriers.Clear();
            tbSelectedCourier.Text = string.Empty;
        }
    }
}