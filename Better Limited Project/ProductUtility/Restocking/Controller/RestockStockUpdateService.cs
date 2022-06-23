using System;
using System.Collections.Generic;
using System.Linq;
using Better_Limited_Project.ProductUtility.Repository;
using Better_Limited_Project.ProductUtility.Restocking.Entity;
using Better_Limited_Project.StaffUtility.StaffEntity;

namespace Better_Limited_Project.ProductUtility.Restocking.Controller
{
    public static class RestockStockUpdateService
    {
        public static void Receive(RetailStore retailStore, RestockRequest restockRequest)
        {
            restockRequest.ReceivedOn = DateTime.Now;
            restockRequest.Save();

            var stocks = StockRepository.GetRetailStoreStocks(retailStore.Id).ToList();
            foreach (var receivedProduct in restockRequest.RequestedProducts)
            {
                var stock = stocks.Find(s => s.ProductId == receivedProduct.ProductId);
                stock.Quantity += receivedProduct.Quantity;
                stock.Save();
            }
        }

        public static void Arrange(Warehouse warehouse, IEnumerable<RestockRequest> restockDeliveryRestockRequests)
        {
            var stocks = StockRepository.GetWarehouseStocks(warehouse.Id).ToList();
            foreach (var restockRequest in restockDeliveryRestockRequests)
            foreach (var requestedProduct in restockRequest.RequestedProducts)
            {
                var stock = stocks.Find(s => s.ProductId == requestedProduct.ProductId);
                stock.Quantity -= requestedProduct.Quantity;
                stock.Save();
            }
        }
    }
}