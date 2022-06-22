using Better_Limited_Project.ProductUtility.Entity;
using Better_Limited_Project.ProductUtility.Repository;

namespace Better_Limited_Project.ProductUtility.Restocking
{
    public class RestockRequestProduct
    {
        public RestockRequestProduct(string restockRequestId, string productId, int quantity)
        {
            RestockRequestId = restockRequestId;
            ProductId = productId;
            Quantity = quantity;
        }

        public string RestockRequestId { get; }
        public RestockRequest RestockRequest => RestockRequestRepository.FindById(RestockRequestId);
        public string ProductId { get; }
        public Product Product => ProductRepository.FindById(ProductId);
        public int Quantity { get; }

        public void Save()
        {
            RestockRequestProductRepository.Insert(this);
        }

        public void Remove()
        {
            RestockRequestProductRepository.Remove(this);
        }
    }
}