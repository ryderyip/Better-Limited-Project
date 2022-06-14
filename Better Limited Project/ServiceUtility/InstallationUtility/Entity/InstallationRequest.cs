using System;
using Better_Limited_Project.Sales.OrderPlacing.Entity;
using Better_Limited_Project.Sales.OrderPlacing.Repository;
using Better_Limited_Project.ServiceUtility.InstallationUtility.Repository;
using Better_Limited_Project.StaffUtility.Repository;
using Better_Limited_Project.StaffUtility.StaffEntity;

namespace Better_Limited_Project.ServiceUtility.InstallationUtility.Entity
{
    public class InstallationRequest
    {
        public InstallationRequest(string salesOrderId, string arrangedByStaffId)
        {
            Id = InstallationRequestRepository.GetNewId();
            SalesOrderId = salesOrderId;
            ArrangedOn = DateTime.Now;
            ArrangedByStaffId = arrangedByStaffId;
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
        public DateTime? ArrangedOn { get; }
        public string? ArrangedByStaffId { get; }
        public SalesOrder SalesOrder => new SalesOrderRepository().FindById(SalesOrderId);
        public Staff? ArrangedByStaff => ArrangedByStaffId != null 
            ? new StaffRepository().FindById(ArrangedByStaffId) : null;

        public void Save()
        {
            InstallationRequestRepository.InsertOrUpdate(this);
        }
    }
}