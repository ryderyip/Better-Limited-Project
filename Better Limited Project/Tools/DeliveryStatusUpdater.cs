using System.Linq;
using Better_Limited_Project.Sales.OrderPlacing.Repository;
using Better_Limited_Project.ServiceUtility;
using Better_Limited_Project.ServiceUtility.Delivery.Repository;
using Better_Limited_Project.StaffUtility.StaffEntity;

namespace Better_Limited_Project.Tools
{
    public static class DeliveryStatusUpdater
    {
        public static void OnStockUpdated(object sender, IWorkplace workplace)
        {
            var deliveryRequests = DeliveryRequestRepository.GetAll().ToList();
            var salesOrders = new SalesOrderRepository().GetAll();
            var ordersWaitingForStock = salesOrders
                .Where(so => so.GetDeliveryRequest() != null
                             && !deliveryRequests.Find(dr => dr.SalesOrderId == so.Id).IsStockReadyForDelivery())
                .OrderBy(so => so.GetDeliveryRequest()!.CreatedOn);

            var service = new ProductReservationService();
            foreach (var order in ordersWaitingForStock)
            {
                foreach (var salesOrderProduct in order.SalesOrderProducts)
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