using Better_Limited_Project.ProductUtility.Repository;
using Better_Limited_Project.Sales.OrderPlacing.Repository;

namespace Better_Limited_Project.Tools
{
    public static class SystemInitialization
    {
        public static void Initialize()
        {
            StockRepository.StockUpdated += AutoProductReserveHelper.WaitListToReservedOnStockUpdated;
            // ReservedSalesOrderProductRepository.Updated += ReservedSalesOrderProductRemover.OnNonDeliveryReservedStockUpdated;
            // DeliveryRepository.DeliveryStatusUpdated += ReservedSalesOrderProductRemover.OnDeliveryStatusUpdated;
        }
    }
}