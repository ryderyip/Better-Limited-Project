using System;
using System.Linq;
using Better_Limited_Project.Sales.OrderPlacing.Entity;
using Better_Limited_Project.Sales.OrderPlacing.Repository;
using Better_Limited_Project.ServiceUtility.DeliveryUtility.Entity;

namespace Better_Limited_Project.Tools
{
    public static class ReservedSalesOrderProductRemover
    {
        public static void OnDeliveryStatusUpdated(object sender, Delivery delivery)
        {
            if (delivery.DeliveryStatus is DeliveryStatus.AwaitingDispatch)
                return;

            var products = delivery.GetSalesOrder().GetSalesOrderProducts();

            foreach (var salesOrderProduct in products)
                ReservedSalesOrderProductRepository.Delete(salesOrderProduct.SalesOrderId, salesOrderProduct.ProductId);
        }

        /// <summary>
        ///     If enough product is reserved
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="reservedStock"></param>
        /// <exception cref="ArgumentException"></exception>
        public static void OnNonDeliveryReservedStockUpdated(object sender, ReservedSalesOrderProduct reservedStock)
        {
            var salesOrder = reservedStock.GetSalesOrder();
            var salesOrderProductOutOfSTock = salesOrder.GetSalesOrderProducts()
                                                  .FirstOrDefault(sop =>
                                                      sop.ProductId == reservedStock.ProductId && sop.IsOutOfStock)
                                              ?? throw new ArgumentException(
                                                  "have reserved stock but dont have sales order product.");

            if (salesOrder.HasRequestedForDelivery() || reservedStock.Quantity < salesOrderProductOutOfSTock.Quantity)
                return;

            var salesOrderProductInStock = salesOrder.GetSalesOrderProducts()
                .First(sop => sop.ProductId == reservedStock.ProductId && !sop.IsOutOfStock);
            salesOrderProductInStock.Quantity += salesOrderProductOutOfSTock.Quantity;
            salesOrderProductInStock.Save();

            salesOrderProductOutOfSTock.Delete();
            reservedStock.Delete();
        }
    }
}