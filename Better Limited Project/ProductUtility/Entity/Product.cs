using Better_Limited_Project.ProductUtility.Repository;

namespace Better_Limited_Project.ProductUtility.Entity
{
    public class Product
    {
        public string Id { get; }
        public string Name { get; set; }
        public decimal OriginalPrice { get; set; }
        public string Description { get; set; }
        public Supplier Supplier { get; set; }
        public Category Category { get; set; }
        public bool IsPhasingOut { get; set; }

        public Product(string id, string name, decimal originalPrice, string description, Supplier supplier, Category category, bool isPhasingOut)
        {
            Id = id;
            Name = name;
            OriginalPrice = originalPrice;
            Description = description;
            Supplier = supplier;
            Category = category;
            IsPhasingOut = isPhasingOut;
        }

        public void Update()
        {
            ProductRepository.UpdateProduct(this);
        }
    }
}
