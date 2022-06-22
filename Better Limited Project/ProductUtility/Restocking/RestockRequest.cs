using System;
using System.Collections.Generic;
using Better_Limited_Project.StaffUtility.Repository;
using Better_Limited_Project.StaffUtility.StaffEntity;

namespace Better_Limited_Project.ProductUtility.Restocking
{
    public class RestockRequest
    {
        public RestockRequest(string requestedForRetailStoreId, string requestedByStaffId)
        {
            Id = RestockRequestRepository.GetNewId();
            RequestNumber = RestockRequestNumberGenerator.Generate(requestedForRetailStoreId);
            RequestedForRetailStoreId = requestedForRetailStoreId;
            RequestedByStaffId = requestedByStaffId;
            RequestedOn = DateTime.Now;
        }

        public RestockRequest(string id, string requestNumber, string requestedForRetailStoreId, 
            string requestedByStaffId, DateTime requestedOn, string? arrangedByStaffId, 
            DateTime? arrangedOn, DateTime? receivedOn)
        {
            Id = id;
            RequestNumber = requestNumber;
            RequestedForRetailStoreId = requestedForRetailStoreId;
            RequestedByStaffId = requestedByStaffId;
            RequestedOn = requestedOn;
            ArrangedByStaffId = arrangedByStaffId;
            ArrangedOn = arrangedOn;
            ReceivedOn = receivedOn;
        }

        public string Id { get; }
        public string RequestNumber { get; }
        public string RequestedForRetailStoreId { get; }
        public RetailStore RequestedForRetailStore => new RetailStoreRepository().GetById(RequestedForRetailStoreId);
        public string RequestedByStaffId { get; }
        public Staff RequestedByStaff => new StaffRepository().FindById(RequestedByStaffId);
        public DateTime RequestedOn { get; }
        public string? ArrangedByStaffId { get; set; }

        public Staff? ArrangedByStaff =>
            ArrangedByStaffId != null ? new StaffRepository().FindById(ArrangedByStaffId) : null;

        public DateTime? ArrangedOn { get; set; }
        public DateTime? ReceivedOn { get; set; }

        public IEnumerable<RestockRequestProduct> RequestedProducts =>
            RestockRequestProductRepository.GetByRequestId(this);

        public void Save()
        {
            RestockRequestRepository.InsertOrUpdate(this);
        }

        public bool IsArranged()
        {
            return ArrangedOn != null;
        }

        public void Remove()
        {
            foreach (var restockRequestProduct in RequestedProducts)
                restockRequestProduct.Remove();
            RestockRequestRepository.Remove(this);
        }
    }
}