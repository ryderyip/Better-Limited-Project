using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Better_Limited_Project.CustomerRecord;
using Better_Limited_Project.Sales.OrderPlacing.Repository;
using Better_Limited_Project.ServiceUtility.DeliveryUtility.Entity;
using Better_Limited_Project.ServiceUtility.DeliveryUtility.Repository;
using Better_Limited_Project.ServiceUtility.InstallationUtility.Entity;
using Better_Limited_Project.ServiceUtility.InstallationUtility.Repository;
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
            IsActive = true;
        }

        public SalesOrder(string id, string orderNumber, Staff staff, RetailStore retailStore, DateTime createdOn,
            bool isActive)
        {
            Id = id;
            OrderNumber = orderNumber;
            Staff = staff;
            RetailStore = retailStore;
            CreatedOn = createdOn;
            IsActive = isActive;
        }

        public string Id { get; }
        public string OrderNumber { get; }
        public Staff Staff { get; }
        public RetailStore RetailStore { get; }
        public Customer? Customer { get; set; }
        public DateTime CreatedOn { get; }
        public bool IsActive { get; private set; }

        public void Save()
        {
            if (IsCompleted())
                IsActive = false;
            new SalesOrderRepository().InsertOrUpdate(this);
        }

        public bool HasRequestedForDelivery()
        {
            return GetDeliveryRequest() != null;
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
            // TODO installion check
            return HasSalesOrderProducts()
                   && !HasUnconfirmedDeliveryRequest()
                   && (!HasRequestedForDelivery() || IsAllDeliveryArrived())
                   && HasNoDuePayment();
        }

        private bool HasSalesOrderProducts()
        {
            return GetSalesOrderProducts().Any();
        }

        private bool HasUnconfirmedDeliveryRequest()
        {
            var deliveryRequest = GetDeliveryRequest();
            return deliveryRequest != null && deliveryRequest.ArrangedOn == null;
        }

        private bool HasNoDuePayment()
        {
            return GetSalesOrderProducts().All(sop =>
                sop.GetPaymentStatus() is SalesOrderProductPaymentStatus.FullyPaid);
        }

        public bool HasDepositPayment()
        {
            return GetSalesOrderProductPayments().Any(sopp => sopp.IsDeposit);
        }

        public IEnumerable<SalesOrderProductPayment> GetSalesOrderProductPayments()
        {
            return GetSalesOrderProducts().SelectMany(sop => sop.GetProductPayments());
        }

        public bool HasCompletedPayment()
        {
            return GetSalesOrderProducts().Any(sop =>
                sop.GetPaymentStatus() is SalesOrderProductPaymentStatus.FullyPaid);
        }

        /// <summary>
        /// <para>Check if the order satisfies the following conditions:</para>
        /// Doesn't have delivery or installation arranged
        /// </summary>
        public bool IsRemovable()
        {
            // TODO installion check
            var deliveryRequest = GetDeliveryRequest();
            if (deliveryRequest == null)
                return true;
            return !deliveryRequest.IsArranged();
        }

        public void Remove()
        {
            Customer?.Remove();
            GetDeliveryRequest()?.Remove();
            // TODO delete installation req if have
            foreach (var salesOrderProductPayment in GetSalesOrderProductPayments())
                salesOrderProductPayment.Remove();
            foreach (var salesOrderProduct in GetSalesOrderProducts())
                salesOrderProduct.Remove();
            new SalesOrderRepository().Remove(this);
        }

        public IEnumerable<SalesOrderProduct> GetIncompletePaymentSalesOrderProducts()
        {
            return GetSalesOrderProducts()
                .Where(sop => sop.GetPaymentStatus() is not SalesOrderProductPaymentStatus.FullyPaid);
        }

        public bool IsAllStockReady()
        {
            return GetSalesOrderProducts().All(sop => sop.IsStockReady());
        }

        public InstallationStatus GetInstallationStatus()
        {
            var installationRequest = GetInstallationRequest();
            if (installationRequest == default)
                return InstallationStatus.NoInstallationRequested;
            
            var installations = installationRequest.GetInstallations().ToList();
            if (!installations.Any())
                return InstallationStatus.InstallationRequested;
            return installations.All(i => i.IsInstalled()) ? InstallationStatus.AllInstalled : InstallationStatus.InstallationArranged;
        }

        public InstallationRequest? GetInstallationRequest()
        {
            return InstallationRequestRepository.FindAll(ir => ir.SalesOrderId == Id).FirstOrDefault();
        }
    }
}