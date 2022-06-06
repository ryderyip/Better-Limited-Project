using Better_Limited_Project.Login;
using Better_Limited_Project.ProductUtility.Repository;
using Better_Limited_Project.Sales.OrderPlacing.Repository;
using Better_Limited_Project.ServiceUtility.Delivery.Repository;
using Better_Limited_Project.StaffUtility.StaffEntity;

namespace Better_Limited_Project.Tools
{
    public static class SystemInitialization
    {
        public static void Initialize()
        {
            StockRepository.StockUpdated += AutoProductReserveHelper.OnStockUpdated;
            ReservedSalesOrderProductRepository.Updated += ReservedSalesOrderProductRemover.OnNonDeliveryReservedStockUpdated;
            DeliveryRepository.DeliveryStatusUpdated += ReservedSalesOrderProductRemover.OnDeliveryStatusUpdated;
        }
    }
}