using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Better_Limited_Project.CustomerRecord;
using Better_Limited_Project.DatabaseUtility;
using Better_Limited_Project.Sales.OrderPlacing.Entity;
using Better_Limited_Project.StaffUtility.Repository;
using Better_Limited_Project.StaffUtility.StaffEntity;
using MySql.Data.MySqlClient;

namespace Better_Limited_Project.Sales.OrderPlacing.Repository
{
    public class SalesOrderRepository
    {
        public SalesOrder FindById(string id)
        {
            return FindAll(so => so.Id == id).FirstOrDefault()
                   ?? throw new ArgumentException($"Sales order ID \"{id}\" does not exist.");
        }

        public async Task<IEnumerable<SalesOrder>> GetAllAsync()
        {
            return await Task.Run(GetAll);
        }

        public IEnumerable<SalesOrder> GetAll()
        {
            var command = new MySqlCommand(
                @"select id, sales_order_number, customer_id, retail_store_id, created_by_staff_id, created_on, is_active from sales_order;");
            var dataTable = DataTableRepository.RetrieveDataTable(command);
            return from DataRow row in dataTable.Rows select ConvertToSalesOrder(row);
        }

        private static SalesOrder ConvertToSalesOrder(DataRow row)
        {
            string id = row.Field<int>("id").ToString();
            string orderNumber = row.Field<string>("sales_order_number");
            var customerId = row.Field<int?>("customer_id");
            Staff staff = new StaffRepository().FindById(row.Field<int>("created_by_staff_id").ToString());
            RetailStore retailStore = new RetailStoreRepository().GetById(row.Field<string>("retail_store_id"));
            var createOn = row.Field<DateTime>("created_on");
            var isActive = row.Field<bool>("is_active");
            return new SalesOrder(id, orderNumber, staff, retailStore, createOn, isActive)
            {
                Customer = customerId.HasValue
                    ? new CustomerRepository().FindById(customerId.Value.ToString())
                    : null
            };
        }

        public IEnumerable<SalesOrder> FindAll(Predicate<SalesOrder> filter)
        {
            return GetAll().Where(filter.Invoke);
        }

        public void InsertOrUpdate(SalesOrder order)
        {
            var command = new MySqlCommand(
                @"insert into sales_order (id, sales_order_number, customer_id, retail_store_id, created_by_staff_id, created_on, is_active) 
                        value (@id, @orderNumber, @customerId, @retailStoreId, @createdByStaffId, @createdOn, @isActive)
                    on duplicate key update customer_id = @customerId, retail_store_id = @retailStoreId, created_by_staff_id = @createdByStaffId, is_active = @isActive;");

            command.Parameters.AddWithValue("@id", order.Id);
            command.Parameters.AddWithValue("@orderNumber", order.OrderNumber);
            command.Parameters.AddWithValue("@customerId",
                order.Customer == null ? DBNull.Value : order.Customer.Id);
            command.Parameters.AddWithValue("@retailStoreId", order.RetailStore.Id);
            command.Parameters.AddWithValue("@createdByStaffId", order.Staff.Id);
            command.Parameters.AddWithValue("@createdOn", order.CreatedOn);
            command.Parameters.AddWithValue("@isActive", order.IsActive);
            DataTableRepository.ExecuteNonQuery(command);
        }

        public string GetNewId()
        {
            var dataTable = DataTableRepository.RetrieveDataTable(new MySqlCommand(
                @"select max(id) + 1 as id from sales_order;"));
            return dataTable.Rows[0]["id"] == DBNull.Value
                ? "1"
                : dataTable.Rows[0].Field<long>("id").ToString();
        }

        public void Remove(SalesOrder salesOrder)
        {
            var command = new MySqlCommand(
                @"delete from sales_order where id = @id;");
            command.Parameters.AddWithValue("@id", salesOrder.Id);
            DataTableRepository.ExecuteNonQuery(command);
        }

        public IEnumerable<SalesOrder> GetCompletedOrders()
        {
            var command = new MySqlCommand(
                @"select id, sales_order_number, customer_id, retail_store_id, 
                        created_by_staff_id, created_on, is_active 
                    from sales_order
                    where is_active = 0;");
            var dataTable = DataTableRepository.RetrieveDataTable(command);
            return from DataRow row in dataTable.Rows select ConvertToSalesOrder(row);
        }
    }
}