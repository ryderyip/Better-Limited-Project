using Better_Limited_Project.ProductUtility.Entity;

namespace Better_Limited_Project.ProductUtility.Reordering
{
    public class ReorderRequestProduct
    {
        public string ReorderRequestId { get; set; }
        public Product Product { get; set; }
        public int Quantity { get; set; }
    }
}