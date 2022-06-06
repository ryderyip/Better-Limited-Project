using System;
using System.Linq;
using System.Windows.Forms;
using Better_Limited_Project.ProductUtility.Entity;
using Better_Limited_Project.Sales.OrderPlacing.Repository;
using Better_Limited_Project.ServiceUtility;

namespace Better_Limited_Project.Tools
{
    public static class AutoProductReserveHelper
    {
        public static void OnStockUpdated(object sender, IStock updatedStock)
        {
            var salesOrdersWaitingForStock = (from order in new SalesOrderRepository().GetAll()
                let deliveryRequest = order.GetDeliveryRequest()
                where deliveryRequest == null
                      || deliveryRequest != null
                      && !deliveryRequest.IsStockReadyForDelivery()
                select order).OrderBy(so => so.CreatedOn);
            
            string reservationMessage = string.Empty;
            foreach (var order in salesOrdersWaitingForStock)
            {
                var orderProduct = order.GetSalesOrderProducts()
                    .FirstOrDefault(sop => sop.ProductId == updatedStock.Product.Id && sop.IsOutOfStock);
                
                if (orderProduct == default)
                    continue;
                
                var service = new ProductReservationService(order);
                int reservedQuantity = orderProduct.GetReservedStock()?.Quantity ?? 0;
                // TODO here quantityToReserve shouldn't be 0
                int quantityToReserve = orderProduct.Quantity - reservedQuantity;
                service.Reserve(orderProduct.ProductId, quantityToReserve);

                string productName = orderProduct.GetProduct().Name;
                reservationMessage += $"{quantityToReserve} \"{productName}\" has/have been reserved " +
                                      $"for order \"{order.OrderNumber}\".\n";
            }
            if (!string.IsNullOrWhiteSpace(reservationMessage))
                MessageBox.Show(reservationMessage);
        }
    }
}