using System.Collections.Generic;
using System.Linq;
using Better_Limited_Project.ProductUtility.Entity;
using Better_Limited_Project.ProductUtility.Reordering.Entity;
using Better_Limited_Project.ProductUtility.Repository;
using Better_Limited_Project.StaffUtility.StaffEntity;

namespace Better_Limited_Project.DevTools
{
    public class RestockTool
    {
        private readonly List<IProductQuantity> _productQuantities = new();
        private readonly RetailStore _retailStore;

        public RestockTool(RetailStore retailStore)
        {
            _retailStore = retailStore;
        }

        public void AddItem(Product product, int quantityToRestock)
        {
            _productQuantities.Add(new ProductQuantity(product.Id, quantityToRestock));
        }

        public void Restock()
        {
            var stocks = StockRepository.GetRetailStoreStocks(_retailStore.Id).ToList();
            foreach (var productQuantity in _productQuantities)
            {
                var stock = stocks.Find(s => s.Product.Id == productQuantity.ProductId);
                stock.Quantity += productQuantity.Quantity;
                stock.Save();
            }

            _productQuantities.Clear();
        }
    }
}