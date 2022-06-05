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
    }
}