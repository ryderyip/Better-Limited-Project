using System.Linq;
using Better_Limited_Project.ProductUtility.Entity;
using Better_Limited_Project.StaffUtility.Repository;

namespace Better_Limited_Project.ProductUtility
{
    public static class NewProductStockCreator
    {
        public static void CreateEmptyStockForNewProduct(Product product)
        {
            foreach (var retailStore in new RetailStoreRepository().GetAll()
                .Where(rs => rs.GetProductStocks().All(s => s.Product.Id != product.Id)))
                new RetailStoreStock(product.Id, retailStore, 0, product.OriginalPrice, 0).Save();

            foreach (var warehouse in WarehouseRepository.GetAll())
                new WarehouseStock(product.Id, warehouse, 0, 0).Save();
        }
    }
}