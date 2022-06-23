using Better_Limited_Project.ProductUtility.Repository;
using Better_Limited_Project.StaffUtility.StaffEntity;

namespace Better_Limited_Project.ProductUtility.Entity
{
    public class RetailStoreStock : IStock
    {
        public string ProductId { get; set; }
        public Product Product => ProductRepository.FindById(ProductId);
        public IWorkplace Workplace { get; }
        public int Quantity { get; set; }
        public decimal SellingPrice { get; set; }
        public int RestockLevel { get; set; }

        public void Save()
        {
            StockRepository.InsertOrUpdate(this);
        }

        public void Remove()
        {
            RetailStoreStockRepository.Remove(Workplace.Id, Product.Id);
        }

        public RetailStoreStock(string productId, RetailStore retailStore, int quantity, decimal sellingPrice, int restockLevel)
        {
            ProductId = productId;
            Workplace = retailStore;
            Quantity = quantity;
            SellingPrice = sellingPrice;
            RestockLevel = restockLevel;
        }
    }
}