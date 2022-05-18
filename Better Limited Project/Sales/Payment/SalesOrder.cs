using System.Collections.Generic;
using Better_Limited_Project.ProductUtility.Entity;

namespace Better_Limited_Project.Sales.Payment
{
    public class SalesOrder
    {
        public string? Id { get; }
        public string CustomerId { get; }
        public string StaffId { get; }
        public string RetailStoreId { get; }
        public IEnumerable<ProductQuantity> ProductQuantities { get; }

        public SalesOrder(string customerId, string staffId, string retailStoreId, IEnumerable<ProductQuantity> productQuantities)
        {
            CustomerId = customerId;
            StaffId = staffId;
            RetailStoreId = retailStoreId;
            ProductQuantities = productQuantities;
        }
    }
}