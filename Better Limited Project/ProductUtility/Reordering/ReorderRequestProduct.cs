using Better_Limited_Project.ProductUtility.Entity;
using Better_Limited_Project.ProductUtility.Repository;

namespace Better_Limited_Project.ProductUtility.Reordering
{
    public class ReorderRequestProduct
    {
        public ReorderRequestProduct(string reorderRequestId, string productId, int quantity)
        {
            ReorderRequestId = reorderRequestId;
            ProductId = productId;
            Quantity = quantity;
        }

        public string ReorderRequestId { get; set; }
        public string ProductId { get; set; }
        public int Quantity { get; set; }
        public ReorderRequest Request => ReorderRequestRepository.FindById(ReorderRequestId);
        public Product Product => ProductRepository.FindById(ProductId);
    }
}