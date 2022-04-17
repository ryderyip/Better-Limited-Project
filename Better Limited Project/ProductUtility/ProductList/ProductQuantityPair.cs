namespace Better_Limited_Project.ProductUtility.ProductList
{
    public readonly struct ProductQuantityPair
    {
        public Product Product { get; }
        public int Quantity { get; }

        public ProductQuantityPair(Product product, int quantity)
        {
            Product = product;
            Quantity = quantity;
        }
    }
}