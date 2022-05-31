using System;
using Better_Limited_Project.Sales.OrderPlacing;
using Better_Limited_Project.Sales.OrderPlacing.Entity;

namespace Better_Limited_Project.ServiceUtility.Delivery
{
    public class DeliveryService
    {
        public void SendRequest(SalesOrder salesOrder, DeliverySession deliverySession)
        {
            var id = Guid.NewGuid().ToString();
            string orderId = salesOrder.Id;
            var createdOn = DateTime.Now;
            var createdBy = salesOrder.Staff;
            var request = new DeliveryRequest(id, orderId, createdOn, createdBy, deliverySession);
            request.Save();
        }
    }
}