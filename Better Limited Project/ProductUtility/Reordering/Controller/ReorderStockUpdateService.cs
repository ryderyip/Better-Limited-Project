using System.Linq;
using Better_Limited_Project.ProductUtility.InwardGoodsUtility.Entity;
using Better_Limited_Project.ProductUtility.Repository;

namespace Better_Limited_Project.ProductUtility.Reordering.Controller
{
    public static class ReorderStockUpdateService
    {
        public static void Receive(InwardGoods inwardGoods)
        {
            var stocks = StockRepository.GetWarehouseStocks(inwardGoods.PurchaseOrder.ReorderRequest.WarehouseId)
                .ToList();
            foreach (var receivedProduct in inwardGoods.InwardProducts)
            {
                var stock = stocks.Find(s => s.ProductId == receivedProduct.ProductId);
                stock.Quantity += receivedProduct.Quantity;
                stock.Save();
            }
        }
    }
}