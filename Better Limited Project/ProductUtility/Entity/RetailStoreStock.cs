using Better_Limited_Project.ProductUtility.Repository;
using Better_Limited_Project.StaffUtility.StaffEntity;

namespace Better_Limited_Project.ProductUtility.Entity
{
    public class RetailStoreStock : IStock
    {
        public Product Product { get; }
        public IWorkplace Workplace { get; }
        public int Quantity { get; }
        public decimal SellingPrice { get; set; }
        public int RestockLevel { get; set; }
        
        public void Update()
        {
            Product.Update();
            StockRepository.UpdateStock(this);
        }

        public RetailStoreStock(Product product, IWorkplace workplace, int quantity, decimal sellingPrice, int restockLevel)
        {
            Product = product;
            Workplace = workplace;
            Quantity = quantity;
            SellingPrice = sellingPrice;
            RestockLevel = restockLevel;
        }
    }
}