using System;
using System.Collections.Generic;
using System.Linq;
using Better_Limited_Project.Sales.OrderPlacing.Entity;
using Better_Limited_Project.Sales.OrderPlacing.Repository;
using Better_Limited_Project.ServiceUtility.InstallationUtility.Repository;
using Better_Limited_Project.StaffUtility.Repository;
using Better_Limited_Project.StaffUtility.StaffEntity;

namespace Better_Limited_Project.ServiceUtility.InstallationUtility.Entity
{
    public class InstallationRequest
    {
        public InstallationRequest(string salesOrderId)
        {
            Id = InstallationRequestRepository.GetNewId();
            SalesOrderId = salesOrderId;
        }

        public InstallationRequest(string id, string salesOrderId, DateTime? arrangedOn, string? arrangedByStaffId)
        {
            Id = id;
            SalesOrderId = salesOrderId;
            ArrangedOn = arrangedOn;
            ArrangedByStaffId = arrangedByStaffId;
        }

        public string Id { get; }
        public string SalesOrderId { get; }
        public DateTime? ArrangedOn { get; set; }
        public string? ArrangedByStaffId { get; set; }
        public SalesOrder SalesOrder => new SalesOrderRepository().FindById(SalesOrderId);
        public Staff? ArrangedByStaff => ArrangedByStaffId != null 
            ? new StaffRepository().FindById(ArrangedByStaffId) : null;

        public IEnumerable<InstallationRequestProduct> ProductsToInstall => InstallationRequestProductRepository.FindByRequestId(Id);

        public void Save()
        {
            InstallationRequestRepository.InsertOrUpdate(this);
        }

        public IEnumerable<Installation> GetInstallations()
        {
            return InstallationRepository.FindBy(i => i.InstallationRequestId == Id);
        }

        public bool IsArranged()
        {
            return ArrangedOn != null;
        }

        public bool HasRequestedForDelieryButNotArranged()
        {
            var deliveryRequest = SalesOrder.GetDeliveryRequest();
            return deliveryRequest != null && !deliveryRequest.IsArranged();
        }

        public void Remove()
        {
            foreach (var installationRequestProduct in ProductsToInstall)
                installationRequestProduct.Remove();
            InstallationRepository.Remove(this);
        }

        public bool IsArrangedAndAllInstalled()
        {
            return IsArranged() && GetInstallations().All(i => i.IsInstalled());
        }
    }
}