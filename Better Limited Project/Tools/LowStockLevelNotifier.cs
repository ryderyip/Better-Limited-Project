using System;
using System.Linq;
using System.Windows.Forms;
using Better_Limited_Project.Login;
using Better_Limited_Project.ProductUtility.Repository;
using Better_Limited_Project.SettingsUtility;
using Better_Limited_Project.StaffUtility.StaffEntity;

namespace Better_Limited_Project.Tools
{
    public static class LowStockLevelNotifier
    {
        public static void OnOrderPlaced(object sender, EventArgs e)
        {
            var workplace = UserSettings.GetSettings().Workplace!;
            var currentStaffDepartment = LoginSession.GetSession().CurrentStaff.Department;
            if (currentStaffDepartment is not Department.Sales and not Department.Inventory)
                return;

            var noOfLowStock = currentStaffDepartment is Department.Sales
                ? StockRepository.GetRetailStoreStocks(workplace.Id)
                    .Count(stock => stock.Quantity < stock.RestockLevel || stock.Quantity == 0)
                : StockRepository.GetWarehouseStocks(workplace.Id)
                    .Count(stock => stock.Quantity < stock.RestockLevel || stock.Quantity == 0);

            if (noOfLowStock == 0)
                return;

            string text = $"There are {noOfLowStock} low stock items!";
            MessageBox.Show(text);
        }
    }
}