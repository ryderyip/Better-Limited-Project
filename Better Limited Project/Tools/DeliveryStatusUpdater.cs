using System.Linq;
using Better_Limited_Project.Sales.OrderPlacing.Repository;
using Better_Limited_Project.ServiceUtility;
using Better_Limited_Project.StaffUtility.StaffEntity;

namespace Better_Limited_Project.Tools
{
    public static class DeliveryStatusUpdater
    {
        public static void OnStockUpdated(object sender, IWorkplace workplace)
        { // TODO need performance upgrade
            var ordersWaitingForStock =
                (from order in new SalesOrderRepository().GetAll()
                    let deliveryRequest = order.GetDeliveryRequest()
                    where deliveryRequest != null
                          && !deliveryRequest.IsStockReadyForDelivery()
                    select order).OrderBy(so => so.GetDeliveryRequest()!.CreatedOn);

            var service = new ProductReservationService();
            foreach (var order in ordersWaitingForStock)
            {
                foreach (var salesOrderProduct in order.GetSalesOrderProducts())
                {
                    var reservedStock = salesOrderProduct.GetReservedStock();
                    int reservedQuantity = reservedStock?.Quantity ?? 0;
                    if (reservedQuantity < salesOrderProduct.Quantity)
                        service.Reserve(salesOrderProduct.SalesOrderId, salesOrderProduct.ProductId,
                            salesOrderProduct.Quantity - reservedQuantity);
                }
            }
        }
    }
}