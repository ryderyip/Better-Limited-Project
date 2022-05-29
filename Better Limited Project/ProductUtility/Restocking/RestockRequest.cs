using System;
using System.Collections.Generic;
using Better_Limited_Project.StaffUtility.StaffEntity;

namespace Better_Limited_Project.ProductUtility.Restocking
{
    public class RestockRequest
    {
        public Guid Id { get; set; }
        public RetailStore RequestedFor { get; set; }
        public Staff RequestedBy { get; set; }
        public DateTime RequestedOn { get; set; }
        public Staff? ArrangedBy { get; set; }
        public DateTime? ArrangedOn { get; set; }
        public ICollection<RestockRequestProduct> RequestedProducts { get; set; }
    }
}