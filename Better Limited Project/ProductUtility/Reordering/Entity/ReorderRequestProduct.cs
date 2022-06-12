using Better_Limited_Project.ProductUtility.Entity;
using Better_Limited_Project.ProductUtility.Repository;

namespace Better_Limited_Project.ProductUtility.Reordering
{
    public class ReorderRequestProduct : IProductQuantity
    {
        public ReorderRequestProduct(string requestId, string productId, int quantity)
        {
            RequestId = requestId;
            ProductId = productId;
            Quantity = quantity;
        }

        public string RequestId { get; }
        public string ProductId { get; }
        public int Quantity { get; set; }
        public ReorderRequest Request => ReorderRequestRepository.FindById(RequestId);
        public Product Product => ProductRepository.FindById(ProductId);

        public void Save()
        {
            ReorderRequestProductRepository.InsertOrUpdate(this);
        }
    }
}