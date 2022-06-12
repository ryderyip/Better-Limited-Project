using Better_Limited_Project.ProductUtility.Entity;

namespace Better_Limited_Project.ProductUtility.Reordering.Entity
{
    public interface IProductQuantity
    {
        public string ProductId { get; }
        public Product Product { get; }
        public int Quantity { get; set; }
    }
}