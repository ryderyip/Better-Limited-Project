using System;
using System.Collections.Generic;
using Better_Limited_Project.StaffUtility.StaffEntity;

namespace Better_Limited_Project.ProductUtility.Reordering
{
    public class ReorderRequest
    {
        public Guid Id { get; set; }
        public Warehouse RequestedFor { get; set; }
        public Staff RequestedBy { get; set; }
        public DateTime RequestedOn { get; set; }
        public Staff? HandledBy { get; set; }
        public DateTime? HandledOn { get; set; }
        public bool IsApproved { get; set; }
        public ICollection<ReorderRequestProduct> RequestedProducts { get; set; }
    }
}