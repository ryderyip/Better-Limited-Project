using System;
using Better_Limited_Project.Sales.OrderPlacing;
using Better_Limited_Project.StaffUtility.StaffEntity;

namespace Better_Limited_Project.ServiceUtility.Delivery
{
    public class DeliveryRequest
    {
        public DeliveryRequest(string id, string salesOrderId, DateTime createOn, Staff createdBy, DeliverySession deliverySession)
        {
            Id = id;
            SalesOrderId = salesOrderId;
            CreateOn = createOn;
            CreatedBy = createdBy;
            DeliverySession = deliverySession;
        }

        public string Id { get; }
        public string SalesOrderId { get; }
        public DateTime CreateOn { get; }
        public Staff CreatedBy { get; }
        public DeliverySession DeliverySession { get; }
        public DateTime? ArrangedOn { get; set; }
        public Staff? ArrangedBy { get; set; }

        public void Save()
        {
            DeliveryRequestRepository.InsertOrUpdate(this);
        }
    }
}