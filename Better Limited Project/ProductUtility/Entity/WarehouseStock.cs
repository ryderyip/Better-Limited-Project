using Better_Limited_Project.ProductUtility.Repository;
using Better_Limited_Project.StaffUtility.StaffEntity;

namespace Better_Limited_Project.ProductUtility.Entity
{
    public class WarehouseStock : IStock
    {
        public Product Product { get; }
        public IWorkplace Workplace { get; }
        public int Quantity { get; set; }
        public int RestockLevel { get; set; }
        
        public void Save()
        {
            StockRepository.InsertOrUpdate(this);
        }

        public void Remove()
        {
            throw new System.NotImplementedException();
        }

        public Product GetProduct()
        {
            return ProductRepository.FindById(Product.Id);
        }

        public WarehouseStock(Product product, Warehouse warehouse, int quantity, int restockLevel)
        {
            Product = product;
            Workplace = warehouse;
            Quantity = quantity;
            RestockLevel = restockLevel;
        }
    }
}