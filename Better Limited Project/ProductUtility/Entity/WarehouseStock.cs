using Better_Limited_Project.ProductUtility.Repository;
using Better_Limited_Project.StaffUtility.StaffEntity;

namespace Better_Limited_Project.ProductUtility.Entity
{
    public class WarehouseStock : IStock
    {
        public WarehouseStock(string productId, Warehouse warehouse, int quantity, int restockLevel)
        {
            ProductId = productId;
            Workplace = warehouse;
            Quantity = quantity;
            RestockLevel = restockLevel;
        }

        public string ProductId { get; }
        public Product Product => ProductRepository.FindById(ProductId);
        public IWorkplace Workplace { get; }
        public int Quantity { get; set; }
        public int RestockLevel { get; set; }

        public void Save()
        {
            StockRepository.InsertOrUpdate(this);
        }

        public void Remove()
        {
            WarehouseStockRepository.Remove(Workplace.Id, Product.Id);
        }
    }
}