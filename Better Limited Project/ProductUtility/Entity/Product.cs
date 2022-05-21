using System;
using Better_Limited_Project.ProductUtility.Repository;

namespace Better_Limited_Project.ProductUtility.Entity
{
    public class Product
    {
        public string? Id { get; set; }
        public string? Name { get; set; }
        public decimal OriginalPrice { get; set; } = decimal.Zero;
        public decimal SellingPrice { get; set; } = decimal.Zero;
        public string? Description { get; set; }
        public Supplier? Supplier { get; set; }
        public Category? Category { get; set; }
        public bool IsPhasingOut { get; set; }

        public void Update()
        {
            ProductRepository.UpdateProduct(this);
        }

        /// <param name="workplaceId">Id of retail store or warehouse</param>
        /// <returns>The product object with it quantity</returns>
        /// <exception cref="InvalidOperationException">Thrown if the workplaceId does not exist</exception>
        public ProductQuantity GetStockOfRetailStoreOrWarehouse(string workplaceId)
        {
            string id = ProductRepository.GetProductByName(Name).Id!;
            
            var stock = StockRepository.GetRetailStoreProductStock(workplaceId, id);
            if (stock != null)
                return stock.Value;
            stock = StockRepository.GetWarehouseProductStock(id, workplaceId);
            if (stock != null)
                return stock.Value;

            throw new InvalidOperationException($"Workplace id \"{workplaceId}\" does not exist.");
        }
    }
}
