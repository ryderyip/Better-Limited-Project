using Better_Limited_Project.ProductUtility.Entity;
using Better_Limited_Project.ProductUtility.Reordering.Entity;
using Better_Limited_Project.ProductUtility.Repository;
using Better_Limited_Project.ServiceUtility.InstallationUtility.Repository;

namespace Better_Limited_Project.ServiceUtility.InstallationUtility.Entity
{
    public class InstallationRequestProduct : IProductQuantity
    {
        public InstallationRequestProduct(string installationRequestId, string productId, int quantity)
        {
            InstallationRequestId = installationRequestId;
            ProductId = productId;
            Quantity = quantity;
        }

        public string InstallationRequestId { get; }
        public InstallationRequest InstallationRequest => InstallationRequestRepository.FindById(InstallationRequestId);
        public string ProductId { get; }
        public Product Product => ProductRepository.FindById(ProductId);
        public int Quantity { get; set; }

        public void Save()
        {
            InstallationRequestProductRepository.InsertOrUpdate(this);
        }

        public void Remove()
        {
            InstallationRequestProductRepository.Remove(this);
        }
    }
}