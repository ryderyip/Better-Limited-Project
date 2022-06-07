using System;
using System.Collections.Generic;
using System.Linq;
using Better_Limited_Project.ProductUtility.Entity;
using Better_Limited_Project.ProductUtility.Repository;
using Better_Limited_Project.Sales.OrderPlacing.Entity;
using Better_Limited_Project.Sales.OrderPlacing.Repository;

namespace Better_Limited_Project.ServiceUtility
{
    public class ProductReservationService
    {
        private readonly SalesOrder _salesOrder;
        private readonly List<RetailStoreStock> _stocks;

        public ProductReservationService(SalesOrder salesOrder)
        {
            _salesOrder = salesOrder;
            _stocks = StockRepository.GetRetailStoreStocks(salesOrder.RetailStore.Id).ToList();
        }

        public void Reserve(string productId, int reserveQuantity)
        {
            var productStock = _stocks.FirstOrDefault(stock => stock.Product.Id == productId)
                               ?? throw new ArgumentException(
                                   $"Product {ProductRepository.FindById(productId)} does not have stock record in database.");

            if (productStock.Quantity == 0)
                return;

            var reservedSalesOrderProduct = ReservedSalesOrderProductRepository
                .FindByIds(_salesOrder.Id, productId);
            reservedSalesOrderProduct ??= new ReservedSalesOrderProduct(_salesOrder.Id, productId, 0);

            if (productStock.Quantity < reserveQuantity)
            {
                reservedSalesOrderProduct.Quantity += productStock.Quantity;
                productStock.Quantity = 0;
            }
            else
            {
                reservedSalesOrderProduct.Quantity += reserveQuantity;
                productStock.Quantity -= reserveQuantity;
            }

            reservedSalesOrderProduct.Save();
            productStock.Save();
        }
    }
}