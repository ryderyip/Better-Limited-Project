using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using Better_Limited_Project.CustomerRecord;
using Better_Limited_Project.DatabaseUtility;
using Better_Limited_Project.RepositoryUtility;
using Better_Limited_Project.Sales.OrderPlacing.Entity;
using Better_Limited_Project.Sales.PaymentUtility.Repository;
using Better_Limited_Project.StaffUtility.StaffEntity;
using MySql.Data.MySqlClient;

namespace Better_Limited_Project.Sales.OrderPlacing.Repository
{
    public class SalesOrderRepository : IRepository<SalesOrder>, IRepositoryInsert<SalesOrder>
    {
        public SalesOrder? FindById(string id)
        {
            return FindAll(so => so.Id == id).FirstOrDefault();
        }

        public IEnumerable<SalesOrder> GetAll()
        {
            var command = new MySqlCommand(
                @"select id, customer_id, retail_store_id, created_by_staff_id, created_on, payment_id from sales_order;");
            var dataTable = DataTableRepository.RetrieveDataTable(command);
            return from DataRow row
                    in dataTable.Rows
                let id = row.Field<string>("id")
                let paymentId = row.Field<int?>("payment_id")
                select new SalesOrder
                {
                    Id = id,
                    Customer = new CustomerRepository().FindById(row.Field<int?>("customer_id").ToString()),
                    RetailStore = new RetailStoreRepository().FindById(row.Field<string>("retail_store_id")),
                    Staff = new StaffRepository().FindById(row.Field<string>("created_by_staff_id")),
                    CreatedOn = row.Field<DateTime>("created_on"),
                    SalesOrderProducts = new List<SalesOrderProduct>(new SalesOrderProductRepository()
                        .FindAll(sop => sop.SalesOrderId == id)),
                    Payment = paymentId == null ? null 
                        : new PaymentRepository().FindById(paymentId.Value.ToString())
                };
        }

        public IEnumerable<SalesOrder> FindAll(Predicate<SalesOrder> filter)
        {
            return GetAll().Where(filter.Invoke);
        }

        public void Insert(SalesOrder order)
        {
            var command = new MySqlCommand(
                @"insert into sales_order (id, customer_id, retail_store_id, created_by_staff_id, created_on, payment_id) 
                        value (0, @customerId, @retailStoreId, @createdByStaffId, now(), @paymentId);
                        select id from sales_order order by created_on desc limit 1;");

            command.Parameters.AddWithValue("@customerId",
                order.Customer == null ? DBNull.Value : order.Customer.Id);
            command.Parameters.AddWithValue("@retailStoreId", order.RetailStore.Id);
            command.Parameters.AddWithValue("@createdByStaffId", order.Staff.Id);
            command.Parameters.AddWithValue("@paymentId", order.Payment == null ? DBNull.Value : order.Payment.Id);
            var dataTable = DataTableRepository.RetrieveDataTable(command);

            order.Id = dataTable.Rows[0].Field<string>("id");
            order.SalesOrderProducts.ToList().ForEach(sop =>
            {
                sop.SalesOrderId = order.Id;
                sop.Save();
            });
        }
    }
}