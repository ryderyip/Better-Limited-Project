using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Better_Limited_Project.DatabaseUtility;
using Better_Limited_Project.Login;
using Better_Limited_Project.ProductUtility.Entity;
using Better_Limited_Project.SettingsUtility;
using MySql.Data.MySqlClient;

namespace Better_Limited_Project.Sales.Payment
{
    public static class SalesOrderCreator
    {
        public static void Create(string customerId, IEnumerable<RetailStoreStock> selectedProducts)
        {
            var order = CreateSalesOrder(customerId, selectedProducts);
            
            using var conn = Database.GetConnection();
            conn.Open();
            string sql = @"insert into sales_order (customer_id, retail_store_id, created_by_staff_id) 
                            values (@customerId, @retailStoreId, @staffId)";
            var command = new MySqlCommand(sql, conn);
            command.Parameters.AddWithValue("@customerId", order.CustomerId);
            command.Parameters.AddWithValue("@retailStoreId", order.RetailStoreId);
            command.Parameters.AddWithValue("@staffId", order.StaffId);
            int columnsAffected = command.ExecuteNonQuery();
            MessageBox.Show("Columns affected: " + columnsAffected);
        }

        private static SalesOrder CreateSalesOrder(string customerId, IEnumerable<RetailStoreStock> selectedProducts)
        {
            var workplace = UserSettings.GetSettings().Workplace;
            if (workplace == null)
                throw new InvalidOperationException("Workplace is null");
            
            string retailStoreId = workplace.Id;
            string staffId = LoginSession.GetSession().StaffId;

            return new SalesOrder(customerId, staffId, retailStoreId, selectedProducts);
        }
    }
}