using Better_Limited_Project.ProductUtility.Entity;

namespace Better_Limited_Project.Sales.OrderPlacing
{
    public class CartItem
    {
        public Product Product { get; }
        public int Quantity { get; }
        public decimal Price { get; }
        public bool IsDeposit { get; }

        public CartItem(Product product, int quantity, decimal price, bool isDeposit)
        {
            Product = product;
            Quantity = quantity;
            Price = price;
            IsDeposit = isDeposit;
        }
    }
}