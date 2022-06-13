using Better_Limited_Project.ProductUtility.Entity;
using Better_Limited_Project.ProductUtility.InwardGoodsUtility.Repository;
using Better_Limited_Project.ProductUtility.Reordering.Entity;
using Better_Limited_Project.ProductUtility.Repository;

namespace Better_Limited_Project.ProductUtility.InwardGoodsUtility.Entity
{
    public class InwardGoodsProduct : IProductQuantity
    {
        public InwardGoodsProduct(string inwardGoodsId, string productId, int quantity)
        {
            InwardGoodsId = inwardGoodsId;
            ProductId = productId;
            Quantity = quantity;
        }

        public string InwardGoodsId { get; }
        public string ProductId { get; }
        public int Quantity { get; set; }
        public Product Product => ProductRepository.FindById(ProductId);

        public void Save()
        {
            InwardGoodsProductRepository.InsertOrUpdate(this);
        }
    }
}