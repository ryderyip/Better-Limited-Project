using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Better_Limited_Project.ProductUtility.Repository;
using Better_Limited_Project.ProductUtility.SupplierUtility;
using Better_Limited_Project.Properties;
using Better_Limited_Project.Sales.OrderPlacing.Repository;
using Better_Limited_Project.StaffUtility.Repository;

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
        public Supplier Supplier { get; set; }
        public Category Category { get; set; }
        public bool IsPhasingOut { get; set; }

        public Product(string id, string name, decimal originalPrice, string description, Supplier supplier,
            Category category, bool isPhasingOut)
        {
            Id = id;
            Name = name;
            OriginalPrice = originalPrice;
            Description = description;
            Supplier = supplier;
            Category = category;
            IsPhasingOut = isPhasingOut;
        }

        public Product(string name, decimal originalPrice, string description, Supplier supplier, Category category,
            bool isPhasingOut)
        {
            Id = ProductRepository.GetNewId();
            Name = name;
            OriginalPrice = originalPrice;
            Description = description;
            Supplier = supplier;
            Category = category;
            IsPhasingOut = isPhasingOut;
        }

        public Image GetImage()
        {
            return ProductImageRepository.GetByProductId(Id)
                   ?? Resources.no_image;
        }

        public void Save()
        {// TODO test this
            foreach (var retailStore in new RetailStoreRepository().GetAll()
                .Where(rs => rs.GetProductStocks().All(s => s.Product.Id != Id)))
                new RetailStoreStock(this, retailStore, 0, OriginalPrice, 0).Save();

            foreach (var warehouse in WarehouseRepository.GetAll())
                new WarehouseStock(this, warehouse, 0, 0).Save();

            ProductRepository.InsertOrUpdate(this);
        }

        public void SetImage(Image image)
        {
            ProductImageRepository.InsertOrUpdate(Id, image);
        }

        public void Remove()
        {
            if (new SalesOrderProductRepository().GetAll().Any(sop => sop.ProductId == Id))
            {
                MessageBox.Show("This product is used by some sales order. Product removal failed.");
                return;
            }

            foreach (var workplace in WorkplaceRepository.GetWorkplaces())
            {
                workplace.GetProductStock(Id).Remove();
            }

            ProductImageRepository.Delete(Id);
        }
    }
}