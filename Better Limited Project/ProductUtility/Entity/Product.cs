using Better_Limited_Project.ProductUtility.Repository;
using Better_Limited_Project.ProductUtility.SupplierUtility;

namespace Better_Limited_Project.ProductUtility.Entity
{
    public class Product
    {
        public const decimal MaximumPrice = 99_99_999.99m;
        public const decimal MaximumReorderLevel = 999;

        public string Id { get; }
        public string Name { get; set; }
        public decimal OriginalPrice { get; set; }
        public string Description { get; set; }
        public SupplierEntity SupplierEntity { get; set; }
        public Category Category { get; set; }
        public bool IsPhasingOut { get; set; }

        public Product(string id, string name, decimal originalPrice, string description, SupplierEntity supplier,
            Category category, bool isPhasingOut)
        {
            Id = id;
            Name = name;
            OriginalPrice = originalPrice;
            Description = description;
            SupplierEntity = supplier;
            Category = category;
            IsPhasingOut = isPhasingOut;
        }

        public void Update()
        {
            ProductRepository.UpdateProduct(this);
        }
    }
}