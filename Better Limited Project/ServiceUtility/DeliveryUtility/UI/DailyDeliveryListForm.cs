using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Better_Limited_Project.ServiceUtility.DeliveryUtility.Controller;
using Better_Limited_Project.ServiceUtility.DeliveryUtility.Repository;
using Better_Limited_Project.Tools;

namespace Better_Limited_Project.ServiceUtility.DeliveryUtility.UI
{
    public partial class DailyDeliveryListForm : Form
    {
        private readonly List<Entity.Delivery> _deliveries;

        public DailyDeliveryListForm()
        {
            _deliveries = DeliveryRepository.GetAll().ToList();
            InitializeComponent();
            Shown += (_, _) => Initialize();
        }
        
        private void Initialize()
        {
            var orderedDeliveries = _deliveries.OrderBy(d => d.ScheduledOn).ToList();
            dtpDeliveryDate.MinDate = orderedDeliveries.FirstOrDefault()?.ScheduledOn.Date 
                                      ?? DateTime.Today;
            dtpDeliveryDate.MaxDate = orderedDeliveries.LastOrDefault()?.ScheduledOn.Date 
                                      ?? DateTime.Today;
            var todayDeliveries = _deliveries.Where(d => d.ScheduledOn.Date == dtpDeliveryDate.MinDate.Date);
            PopulateDgvDeliveries(todayDeliveries.ToList());
        }

        private void PopulateDgvDeliveries(List<Entity.Delivery> deliveryList)
        {
            dgvDeliveries.Rows.Clear();
            deliveryList.ForEach(delivery => dgvDeliveries.Rows.Add(delivery.Id, delivery.DeliveryRequestId,
                delivery.GetSalesOrder().OrderNumber,
                EnumToStringHelper.GetDisplayValue(delivery.DeliveryStatus),
                $"{delivery.GetLastUpdatedTime().ToShortDateString()} | {delivery.GetLastUpdatedTime().ToShortTimeString()}",
                delivery.GetDeliveryRequest().GetArrangedByStaff()?.Name ?? "-"));
        }

        private void dtpDeliveryDate_ValueChanged(object sender, EventArgs e)
        {
            var deliveriesOfSelectedDate = GetDeliveriesOfSelectedDate();
            PopulateDgvDeliveries(deliveriesOfSelectedDate.ToList());
        }

        private void btnPrintDeliveryList_Click(object sender, EventArgs e)
        {
            var generator = new DeliveryListGenerator(GetDeliveriesOfSelectedDate());
            generator.GenerateAndPrint();
        }
        
        private void btnGenerateDeliveryList_Click(object sender, EventArgs e)
        {
            var generator = new DeliveryListGenerator(GetDeliveriesOfSelectedDate());
            generator.GenerateAndOpen();
        }
        
        private IEnumerable<Entity.Delivery> GetDeliveriesOfSelectedDate()
        {
            return _deliveries.Where(d => d.ScheduledOn.Date == dtpDeliveryDate.Value.Date);
        }
    }
}
