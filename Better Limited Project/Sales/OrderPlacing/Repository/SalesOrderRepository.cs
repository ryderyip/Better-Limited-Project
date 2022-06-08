using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using Better_Limited_Project.CustomerRecord;
using Better_Limited_Project.DatabaseUtility;
using Better_Limited_Project.Login;
using Better_Limited_Project.Sales.OrderPlacing.Entity;
using Better_Limited_Project.StaffUtility.Repository;
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

        public IEnumerable<SalesOrder> GetAll()
        {
            var command = new MySqlCommand(
                @"select id, sales_order_number, customer_id, retail_store_id, created_by_staff_id, created_on from sales_order;");
            var dataTable = DataTableRepository.RetrieveDataTable(command);
            return from DataRow row
                    in dataTable.Rows
                let id = row.Field<int>("id").ToString()
                let orderNumber = row.Field<string>("sales_order_number")
                let customerId = row.Field<int?>("customer_id")
                let staff = new StaffRepository().FindById(row.Field<int>("created_by_staff_id").ToString())
                let retailStore = new RetailStoreRepository().GetById(row.Field<string>("retail_store_id"))
                let createOn = row.Field<DateTime>("created_on")
                select new SalesOrder(id, orderNumber, staff, retailStore, createOn)
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
                @"insert into sales_order (id, sales_order_number, customer_id, retail_store_id, created_by_staff_id, created_on) 
                        value (@id, @orderNumber, @customerId, @retailStoreId, @createdByStaffId, @createdOn)
                    on duplicate key update customer_id = @customerId, retail_store_id = @retailStoreId, created_by_staff_id = @createdByStaffId;");

            command.Parameters.AddWithValue("@id", order.Id);
            command.Parameters.AddWithValue("@orderNumber", order.OrderNumber);
            command.Parameters.AddWithValue("@customerId",
                order.Customer == null ? DBNull.Value : order.Customer.Id);
            command.Parameters.AddWithValue("@retailStoreId", order.RetailStore.Id);
            command.Parameters.AddWithValue("@createdByStaffId", order.Staff.Id);
            command.Parameters.AddWithValue("@createdOn", order.CreatedOn);
            DataTableRepository.ExecuteNonQuery(command);
        }

        public string GetNewOrderNumber()
        {
            string staffId = LoginSession.GetSession().CurrentStaff.Id;
            string retailStoreId = new RetailStoreRepository().GetAll().First().Id;
            var command = new MySqlCommand(
                @"insert into sales_order (id, sales_order_number, customer_id, retail_store_id, created_by_staff_id)
                value (0, 0, null, @retailStoreId, @staffId);
                select sales_order_number as orderNumber from sales_order order by created_on desc limit 1;
                delete from sales_order where sales_order_number = (
                    select sales_order_number from sales_order order by created_on desc limit 1
                );
                delete from sales_order_seq where id = (
                    select max(id) from sales_order_seq
                );");
            command.Parameters.AddWithValue("@retailStoreId", retailStoreId);
            command.Parameters.AddWithValue("@staffId", staffId);
            var datatable = DataTableRepository.RetrieveDataTable(command);
            return datatable.Rows[0].Field<string>("orderNumber");
        }

        public string GetNewId()
        {
            var dataTable = DataTableRepository.RetrieveDataTable(new MySqlCommand(
                @"select max(id) + 1 as id from sales_order;"));
            return dataTable.Rows[0]["id"] == DBNull.Value
                ? "1" : dataTable.Rows[0].Field<long>("id").ToString();
        }
    }
}