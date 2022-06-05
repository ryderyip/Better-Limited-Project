using System.Drawing;
using Better_Limited_Project.ProductUtility.Repository;
using Better_Limited_Project.ProductUtility.SupplierUtility;
using Better_Limited_Project.Properties;
using Better_Limited_Project.Sales.OrderPlacing.Repository;

namespace Better_Limited_Project.ProductUtility.Entity
{
    public class Product
    {
        public const decimal MaximumPrice = 99_99_999.99m;
        public const decimal MaximumReorderLevel = 999;
        public const decimal DepositPricePercentage = 0.2m;
        public const decimal DepositThreshold = 5000;

        public string Id { get; set; }
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

        public Product(string name, decimal originalPrice, string description, SupplierEntity supplierEntity, Category category, bool isPhasingOut)
        {
            Name = name;
            OriginalPrice = originalPrice;
            Description = description;
            SupplierEntity = supplierEntity;
            Category = category;
            IsPhasingOut = isPhasingOut;
        }

        public void Update()
        {
            ProductRepository.UpdateProduct(this);
        }

        public Image GetPicture()
        {
            return ProductImageRepository.GetByProductId(Id)
                ?? Resources.no_image;
        }

        public void Save()
        {
            ProductRepository.CreateNewProduct(this);
        }

        public void AddImage(Image image)
        {
            ProductImageRepository.InsertOrUpdate(Id, image);
        }
    }
}