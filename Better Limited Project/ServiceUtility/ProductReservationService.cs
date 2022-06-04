using System;
using System.Collections.Generic;
using System.Linq;
using Better_Limited_Project.ProductUtility.Entity;
using Better_Limited_Project.ProductUtility.Repository;
using Better_Limited_Project.Sales.OrderPlacing.Entity;
using Better_Limited_Project.Sales.OrderPlacing.Repository;
using Better_Limited_Project.SettingsUtility;

namespace Better_Limited_Project.ServiceUtility
{
    public class ProductReservationService
    {
        private readonly List<IStock> _stocks;

        public ProductReservationService()
        {
            _stocks = StockRepository.GetStocks(UserSettings.GetSettings().Workplace!.Id).ToList();
        }

        public void Reserve(string orderId, string productId, int reserveQuantity)
        {
            var stock = _stocks.FirstOrDefault(stock => stock.Product.Id == productId)
                        ?? throw new ArgumentException(
                            $"Product {ProductRepository.FindById(productId)} does not have stock record in database.");

            ReservedSalesOrderProduct reservedProducts;
            if (stock.Quantity < reserveQuantity
            && stock.Quantity != 0) // if there is not enough stock
            {
                reservedProducts = new ReservedSalesOrderProduct(orderId,
                    productId, stock.Quantity);
                stock.Quantity = 0;
            }
            else
            {
                reservedProducts = new ReservedSalesOrderProduct(orderId,
                    productId, reserveQuantity);
                stock.Quantity -= reserveQuantity;
            }

            reservedProducts.Save();
            stock.Save();
        }
        
        private static bool IsEnoughStock(SalesOrderProduct salesOrderProduct, IStock stock)
        {
            return stock.Quantity < salesOrderProduct.Quantity;
        }
    }
}