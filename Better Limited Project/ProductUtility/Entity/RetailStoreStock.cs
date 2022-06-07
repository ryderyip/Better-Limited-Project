using Better_Limited_Project.ProductUtility.Repository;
using Better_Limited_Project.StaffUtility.StaffEntity;

namespace Better_Limited_Project.ProductUtility.Entity
{
    public class RetailStoreStock : IStock
    {
        public Product Product { get; }
        public IWorkplace Workplace { get; }
        public int Quantity { get; set; }
        public decimal SellingPrice { get; set; }
        public int RestockLevel { get; set; }
        
        public void Save()
        {
            StockRepository.InsertOrUpdate(this);
        }

        public Product GetProduct()
        {
            return ProductRepository.FindById(Product.Id);
        }

        public void Remove()
        {
            RetailStoreStockRepository.Remove(Workplace.Id, Product.Id);
        }

        public RetailStoreStock(Product product, RetailStore retailStore, int quantity, decimal sellingPrice, int restockLevel)
        {
            Product = product;
            Workplace = retailStore;
            Quantity = quantity;
            SellingPrice = sellingPrice;
            RestockLevel = restockLevel;
        }
    }
}