using System;
using Better_Limited_Project.ProductUtility.Entity;

namespace Better_Limited_Project.ProductUtility.Restocking
{
    public class RestockRequestProduct
    {
        public Guid RestockRequestId { get; set; }
        public Product Product { get; set; }
        public int Quantity { get; set; }
    }
}