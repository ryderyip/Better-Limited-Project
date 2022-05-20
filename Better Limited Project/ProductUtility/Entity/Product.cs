namespace Better_Limited_Project.ProductUtility.Entity
{
    public class Product
    {
        public string? Id { get; set; }
        public string? Name { get; set; }
        public decimal OriginalPrice { get; set; } = decimal.Zero;
        public decimal SellingPrice { get; set; } = decimal.Zero;
        public string? Description { get; set; }
        public Supplier? Supplier { get; set; }
        public Category? Category { get; set; }
        public bool IsPhasingOut { get; set; }

        public void Update()
        {
            ProductRepository.UpdateProduct(this);
        }
    }
}
