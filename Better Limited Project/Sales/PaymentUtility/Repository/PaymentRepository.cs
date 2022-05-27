using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using Better_Limited_Project.DatabaseUtility;
using Better_Limited_Project.RepositoryUtility;
using MySql.Data.MySqlClient;

namespace Better_Limited_Project.Sales.PaymentUtility.Repository
{
    public class PaymentRepository : IRepository<Payment>, IRepositoryInsert<Payment>
    {
        public Payment? FindById(string id)
        {
            return FindAll(entity => entity.Id == id).FirstOrDefault();
        }

        public IEnumerable<Payment> GetAll()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Payment> FindAll(Predicate<Payment> filter)
        {
            var command = new MySqlCommand(
                @"select id, amount, paid_on, payment_method_id from payment;");
            var dataTable = DataTableRepository.RetrieveDataTable(command);
            var payments = from DataRow row in dataTable.Rows
                select new Payment
                {
                    Id = row.Field<int>("id").ToString(),
                    Amount = row.Field<decimal>("amount"),
                    PaidOn = row.Field<DateTime>("paid_on"),
                    PaymentMethod = (PaymentMethod) row.Field<int>("payment_method_id")
                };
            return payments.Where(filter.Invoke);
        }

        public void Insert(Payment payment)
        {
            var command = new MySqlCommand(
                @"insert into payment (amount, paid_on, payment_method_id) 
                        value (@amount, @paidOn, @paymentMethodId);
                        select last_insert_id() as id");

            command.Parameters.AddWithValue("@amount", payment.Amount);
            command.Parameters.AddWithValue("@paidOn", payment.PaidOn);
            command.Parameters.AddWithValue("@paymentMethodId", (int) payment.PaymentMethod);

            var dataTable = DataTableRepository.RetrieveDataTable(command);
            payment.Id = dataTable.Rows[0].Field<ulong>("id").ToString();
        }
    }
}