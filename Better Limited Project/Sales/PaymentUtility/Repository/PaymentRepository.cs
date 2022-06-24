using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Better_Limited_Project.DatabaseUtility;
using MySql.Data.MySqlClient;

namespace Better_Limited_Project.Sales.PaymentUtility.Repository
{
    public static class PaymentRepository
    {
        public static Payment FindById(string id)
        {
            return FindAll(p => p.Id == id).FirstOrDefault()
                   ?? throw new ArgumentException($"Payment id \"{id}\" does not exist.");
        }

        public static IEnumerable<Payment> GetAll()
        {
            var command = new MySqlCommand(
                @"select id, amount, paid_on, payment_method_id from payment;");
            var dataTable = DataTableRepository.RetrieveDataTable(command);
            return from DataRow row in dataTable.Rows
                let id = row.Field<int>("id").ToString()
                let amount = row.Field<decimal>("amount")
                let paymentMethod = (PaymentMethod) row.Field<int>("payment_method_id")
                let paidOn = row.Field<DateTime>("paid_on")
                select new Payment(id, amount, paymentMethod, paidOn);
        }

        public static IEnumerable<Payment> FindAll(Predicate<Payment> filter)
        {
            return GetAll().Where(filter.Invoke);
        }

        public static void InsertOrUpdate(Payment payment)
        {
            var command = new MySqlCommand(
                @"insert into payment (amount, paid_on, payment_method_id) 
                        value (@amount, @paidOn, @paymentMethodId);");

            command.Parameters.AddWithValue("@amount", payment.Amount);
            command.Parameters.AddWithValue("@paidOn", payment.PaidOn);
            command.Parameters.AddWithValue("@paymentMethodId", (int) payment.PaymentMethod);

            DataTableRepository.ExecuteNonQuery(command);
        }

        public static string GetNewId()
        {
            var dataTable = DataTableRepository.RetrieveDataTable(new MySqlCommand(
                @"select max(id) as id from payment;"));
            return (from DataRow row in dataTable.Rows select row.Field<int>("id") + 1).First().ToString();
        }

        public static async Task<IEnumerable<Payment>> GetAllAsync()
        {
            return await Task.Run(GetAll);
        }
    }
}