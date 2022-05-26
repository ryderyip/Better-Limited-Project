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
        public void Update()
        {
            Product.Update();
            StockRepository.UpdateStock(this);
        }

        public WarehouseStock(Product product, IWorkplace workplace, int quantity, int restockLevel)
        {
            Product = product;
            Workplace = workplace;
            Quantity = quantity;
            RestockLevel = restockLevel;
        }
    }
}