using System.Linq;
using Better_Limited_Project.Login;
using Better_Limited_Project.ProductUtility.Repository;
using Better_Limited_Project.StaffUtility.StaffEntity;

namespace Better_Limited_Project.Tools
{
    public static class LowStockLevelNotifier
    {
        public static void OnStockUpdated(object sender, IWorkplace workplace)
        {
            var currentStaffDepartment = LoginSession.GetSession().CurrentStaff.Department;
            if (currentStaffDepartment is not Department.Sales and not Department.Inventory)
                return;
            
            int noOfLowStock = currentStaffDepartment is Department.Sales 
                ? StockRepository.GetRetailStoreStocks(workplace.Id).Count(stock => stock.Quantity < stock.RestockLevel || stock.Quantity == 0)
                : StockRepository.GetWarehouseStocks(workplace.Id).Count(stock => stock.Quantity < stock.RestockLevel || stock.Quantity == 0);

            if (noOfLowStock == 0)
                return;
            
            string header = "Low Stock Warning";
            string text = $"There are {noOfLowStock} low stock items!";
            var popUp = new PopUpForm(header, text);
            popUp.Show();
        }
    }
}