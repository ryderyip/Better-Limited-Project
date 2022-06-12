using System;
using System.Collections.Generic;
using Better_Limited_Project.ProductUtility.Reordering.Controller;
using Better_Limited_Project.ProductUtility.Reordering.Repository;
using Better_Limited_Project.StaffUtility.Repository;
using Better_Limited_Project.StaffUtility.StaffEntity;

namespace Better_Limited_Project.ProductUtility.Reordering.Entity
{
    public class ReorderRequest
    {
        public ReorderRequest(string warehouseId, string requestedByStaffId)
        {
            Id = ReorderRequestRepository.GetNewId();
            RequestNumber = ReorderRequestNumberGenerator.Generate(warehouseId);
            WarehouseId = warehouseId;
            RequestedByStaffId = requestedByStaffId;
            RequestedOn = DateTime.Now;
        }

        public ReorderRequest(string id, string requestNumber, string warehouseId, string requestedByStaffId, string? approvedByStaffId, DateTime requestedOn, DateTime? approvedOn)
        {
            Id = id;
            RequestNumber = requestNumber;
            WarehouseId = warehouseId;
            RequestedByStaffId = requestedByStaffId;
            ApprovedByStaffId = approvedByStaffId;
            RequestedOn = requestedOn;
            ApprovedOn = approvedOn;
        }

        public string Id { get; }
        public string RequestNumber { get; }
        public string WarehouseId { get; }
        public string RequestedByStaffId { get; }
        public string? ApprovedByStaffId { get; set; }
        public Warehouse Warehouse => WarehouseRepository.GetById(WarehouseId);
        public Staff RequestedByStaff => new StaffRepository().FindById(RequestedByStaffId);
        public DateTime RequestedOn { get; }

        public Staff? ApprovedByStaff => ApprovedByStaffId != null
            ? new StaffRepository().FindById(ApprovedByStaffId)
            : null;

        public DateTime? ApprovedOn { get; set; }

        public IEnumerable<ReorderRequestProduct> RequestedProducts
            => ReorderRequestProductRepository.GetBy(this);

        public bool IsApproved()
        {
            return ApprovedByStaff != null || ApprovedOn != null;
        }

        public void Save()
        {
            ReorderRequestRepository.InsertOrUpdate(this);
        }

        public void Remove()
        {
            foreach (var requestedProduct in RequestedProducts)
                ReorderRequestProductRepository.Delete(requestedProduct);
            ReorderRequestRepository.Delete(this);
        }
    }
}