using System;
using System.Linq;
using Better_Limited_Project.Sales.OrderPlacing.Entity;
using Better_Limited_Project.Sales.OrderPlacing.Repository;
using Better_Limited_Project.ServiceUtility.Delivery;

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

        public static void OnNonDeliveryReservedStockUpdated(object sender, ReservedSalesOrderProduct reservedStock)
        {
            var salesOrder = reservedStock.GetSalesOrder();
            var salesOrderProduct = salesOrder.GetSalesOrderProducts()
                                        .FirstOrDefault(sop => sop.ProductId == reservedStock.ProductId)
                                    ?? throw new ArgumentException(
                                        "have reserved stock but dont have sales order product.");

            if (salesOrder.GetDeliveryRequest() != null 
                || reservedStock.Quantity < salesOrderProduct.Quantity) 
                return;

            salesOrderProduct.IsOutOfStock = false;
            salesOrderProduct.Save();
            reservedStock.Delete();
        }
    }
}