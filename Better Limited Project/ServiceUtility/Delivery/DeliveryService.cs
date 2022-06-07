using System;
using Better_Limited_Project.Sales.OrderPlacing.Entity;
using Better_Limited_Project.ServiceUtility.Delivery.Entity;
using Better_Limited_Project.ServiceUtility.Delivery.Repository;

namespace Better_Limited_Project.ServiceUtility.Delivery
{
    public class DeliveryService
    {
        public void SendRequest(SalesOrder salesOrder, DeliverySession deliverySession)
        {
            var id = DeliveryRequestRepository.GetNewId();
            string orderId = salesOrder.Id;
            var createdOn = DateTime.Now;
            var createdBy = salesOrder.Staff;
            var request = new DeliveryRequest(id, orderId, createdOn, createdBy.Id, deliverySession);
            request.Save();
        }
    }
}