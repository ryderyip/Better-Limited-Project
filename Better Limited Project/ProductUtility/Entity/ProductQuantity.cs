namespace Better_Limited_Project.ProductUtility.Entity
{
    public readonly struct ProductQuantity
    {
        public Product Product { get; }
        public int Quantity { get; }

        public ProductQuantity(Product product, int quantity)
        {
            Product = product;
            Quantity = quantity;
        }
    }
}