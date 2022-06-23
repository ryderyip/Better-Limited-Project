using Better_Limited_Project.ProductUtility.Entity;
using Better_Limited_Project.ProductUtility.GoodsPurchasing.Repository;
using Better_Limited_Project.ProductUtility.Reordering.Entity;
using Better_Limited_Project.ProductUtility.Repository;

namespace Better_Limited_Project.ProductUtility.GoodsPurchasing.Entity
{
    public class PurchaseOrderProduct : IProductQuantity
    {
        public PurchaseOrderProduct(string purchaseOrderId, string productId, int quantity)
        {
            PurchaseOrderId = purchaseOrderId;
            ProductId = productId;
            Quantity = quantity;
        }

        public string PurchaseOrderId { get; set; }
        public PurchaseOrder PurchaseOrder => PurchaseOrderRepository.GetById(PurchaseOrderId);
        public string ProductId { get; }
        public int Quantity { get; set; }
        public Product Product => ProductRepository.FindById(ProductId);

        public void Save()
        {
            PurchaseOrderProductRepository.InsertOrUpdate(this);
        }
    }
}