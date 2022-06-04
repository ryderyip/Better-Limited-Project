using System;
using System.Collections.Generic;
using System.Linq;
using Better_Limited_Project.Sales.OrderPlacing;
using Better_Limited_Project.Sales.OrderPlacing.Entity;
using Better_Limited_Project.Sales.OrderPlacing.Repository;
using Better_Limited_Project.ServiceUtility.Delivery.Repository;
using Better_Limited_Project.StaffUtility.StaffEntity;

namespace Better_Limited_Project.ServiceUtility.Delivery
{
    public class DeliveryRequest
    {
        public DeliveryRequest(string id, string salesOrderId, DateTime createdOn, string createdByStaffId, DeliverySession deliverySession)
        {
            Id = id;
            SalesOrderId = salesOrderId;
            CreatedOn = createdOn;
            CreatedByStaffId = createdByStaffId;
            DeliverySession = deliverySession;
        }

        public string Id { get; }
        public string SalesOrderId { get; }
        public DateTime CreatedOn { get; }
        public string CreatedByStaffId { get; }
        public DeliverySession DeliverySession { get; }
        public DateTime? ArrangedOn { get; set; }
        public string? ArrangedByStaffId { get; set; }

        public void Save()
        {
            DeliveryRequestRepository.InsertOrUpdate(this);
        }

        public Staff GetCreatedByStaff()
        {
            return new StaffRepository().FindById(CreatedByStaffId);
        }
        
        public Staff? GetArrangedByStaff()
        {
            return ArrangedByStaffId != null ? new StaffRepository().FindById(ArrangedByStaffId) : null;
        }

        public SalesOrder GetSalesOrder()
        {
            return new SalesOrderRepository().FindById(SalesOrderId);
        }

        public bool IsArranged()
        {
            return ArrangedByStaffId != null || ArrangedOn != null;
        }

        public void Remove()
        {
            DeliveryRequestRepository.Delete(this);
        }

        public bool IsStockReadyForDelivery()
        {
            foreach (var salesOrderProduct in GetSalesOrder().SalesOrderProducts)
            {
                var reservedStock = salesOrderProduct.GetReservedStock();
                if (reservedStock == null || reservedStock.Quantity < salesOrderProduct.Quantity)
                    return false;
            }

            return true;
        }

        public IEnumerable<Delivery> GetDeliveries()
        {
            return DeliveryRepository.FindAll(d => d.DeliveryRequestId == Id);
        }
    }
}