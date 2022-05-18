namespace Better_Limited_Project.ProductUtility.Entity
{
    public class Product
    {
        public string? Id { get; set; }
        public string? Name { get; set; }
        public decimal OriginalPrice { get; set; }
        public decimal SellingPrice { get; set; }
        public string? Description { get; set; }
        public Supplier? Supplier { get; set; }
        public string? Category { get; set; }
        public bool IsPhasingOut { get; set; }
    }
}
