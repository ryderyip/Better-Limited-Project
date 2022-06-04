using Better_Limited_Project.Login;
using Better_Limited_Project.ProductUtility.Repository;
using Better_Limited_Project.StaffUtility.StaffEntity;

namespace Better_Limited_Project.Tools
{
    public static class SystemInitialization
    {
        public static void Initialize()
        {
            var staff = LoginSession.GetSession().CurrentStaff;
            if (staff.Department is Department.Sales or Department.Inventory)
                StockRepository.StockUpdated += LowStockLevelNotifier.OnStockUpdated;
            StockRepository.StockUpdated += DeliveryStatusUpdater.OnStockUpdated;
        }
    }
}