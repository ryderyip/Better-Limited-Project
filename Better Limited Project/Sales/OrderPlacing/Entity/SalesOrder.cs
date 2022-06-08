using System;
using System.Collections.Generic;
using System.Linq;
using Better_Limited_Project.CustomerRecord;
using Better_Limited_Project.Sales.OrderPlacing.Repository;
using Better_Limited_Project.ServiceUtility.Delivery.Entity;
using Better_Limited_Project.ServiceUtility.Delivery.Repository;
using Better_Limited_Project.StaffUtility.StaffEntity;

namespace Better_Limited_Project.Sales.OrderPlacing.Entity
{
    public class SalesOrder : IEntity
    {
        public SalesOrder(Staff staff, RetailStore retailStore)
        {
            Id = new SalesOrderRepository().GetNewId();
            OrderNumber = new SalesOrderRepository().GetNewOrderNumber();
            Staff = staff;
            RetailStore = retailStore;
            CreatedOn = DateTime.Now;
        }

        public SalesOrder(string id, string orderNumber, Staff staff, RetailStore retailStore, DateTime createdOn)
        {
            Id = id;
            OrderNumber = orderNumber;
            Staff = staff;
            RetailStore = retailStore;
            CreatedOn = createdOn;
        }

        public string Id { get; }
        public string OrderNumber { get; }
        public Staff Staff { get; }
        public RetailStore RetailStore { get; }
        public Customer? Customer { get; set; }
        public DateTime CreatedOn { get; }

        public void Save()
        {
            new SalesOrderRepository().InsertOrUpdate(this);
        }

        public bool HasRequestedForDelivery()
        {
            return DeliveryRequestRepository.GetAll().Any(dr => dr.SalesOrderId == Id);
        }

        public bool IsNeedInstallation()
        {
            return false;
            // return new InstallationRequestRepository().GetAll().Any(ir => ir.)
        }

        public bool IsAllDeliveryArrived()
        {
            var deliveries = GetDeliveries().ToList();
            return deliveries.Any() && deliveries.All(d => d.DeliveryStatus is DeliveryStatus.Delivered);
        }

        public IEnumerable<Delivery> GetDeliveries()
        {
            return DeliveryRepository.FindAll(d => d.GetDeliveryRequest().SalesOrderId == Id);
        }

        public DeliveryRequest? GetDeliveryRequest()
        {
            return DeliveryRequestRepository.FindAll(dr => dr.SalesOrderId == Id).FirstOrDefault();
        }

        public IEnumerable<SalesOrderProduct> GetSalesOrderProducts()
        {
            return new SalesOrderProductRepository().FindByOrderId(Id);
        }

        public bool IsCompleted()
        {
            
            return !HasUnconfirmedDeliveryRequest() 
                   || (!HasRequestedForDelivery() || IsAllDeliveryArrived()) 
                   && IsAllDuePaymentsPaid();
        }

        private bool HasUnconfirmedDeliveryRequest()
        {
            var deliveryRequest = GetDeliveryRequest();
            return deliveryRequest != null && deliveryRequest.ArrangedOn == null;
        }

        private bool IsAllDuePaymentsPaid()
        {
            return GetSalesOrderProducts().All(sop =>
                sop.GetPaymentStatus() is SalesOrderProductPaymentStatus.FullyPaid);
        }
    }
}