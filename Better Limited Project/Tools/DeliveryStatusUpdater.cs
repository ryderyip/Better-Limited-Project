using System.Linq;
using Better_Limited_Project.Sales.OrderPlacing.Repository;
using Better_Limited_Project.ServiceUtility;
using Better_Limited_Project.StaffUtility.StaffEntity;

namespace Better_Limited_Project.Tools
{
    public static class DeliveryStatusUpdater
    {
        public static void OnStockUpdated(object sender, IWorkplace workplace)
        {
            var salesOrders = new SalesOrderRepository().GetAll();
            var ordersWaitingForStock = salesOrders.Where(so => !so.IsStockReady())
                .OrderBy(o => o.GetDeliveries().First().CreatedOn);

            var service = new ProductReservationService();
            foreach (var order in ordersWaitingForStock)
                order.SalesOrderProducts.Where(sop => sop.GetReservedStock().Quantity < sop.Quantity).ToList()
                    .ForEach(sop => service.Reserve(sop.SalesOrderId, sop.ProductId,
                        sop.Quantity - sop.GetReservedStock().Quantity));
        }
    }
}