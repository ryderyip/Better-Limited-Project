using System.Collections.Generic;
using System.Data;
using System.Linq;
using Better_Limited_Project.DatabaseUtility;
using Better_Limited_Project.ProductUtility.Entity;
using Better_Limited_Project.Sales.OrderPlacing.Entity;
using Better_Limited_Project.Sales.PaymentUtility.Repository;
using MySql.Data.MySqlClient;

namespace Better_Limited_Project.Sales.OrderPlacing.Controller
{
    public class SalesOrderCalculator
    {
        private readonly List<SalesOrderProduct> _salesOrderProducts;

        public SalesOrderCalculator(IEnumerable<SalesOrderProduct> salesOrderProducts)
        {
            _salesOrderProducts = salesOrderProducts.ToList();
        }

        public decimal GetTotalAmount()
        {
            return _salesOrderProducts.Sum(sop => sop.Price * sop.Quantity);
        }

        public decimal GetDepositAmount()
        {
            return _salesOrderProducts
                .Where(sop => sop.IsOutOfStock)
                .Sum(sop => sop.Price * sop.Quantity * Product.DepositPricePercentage);
        }

        public decimal GetNonDepositAmount()
        {
            return _salesOrderProducts
                .Where(sop => !sop.IsOutOfStock)
                .Sum(sop => sop.Price * sop.Quantity);
        }

        public decimal GetAmountPaid()
        {
            if (_salesOrderProducts.Count == 0)
                return 0;
            var command = new MySqlCommand(
                @"select payment_id from sales_order_product_payment where sales_order_id = @orderId;");
            command.Parameters.AddWithValue("@orderId", _salesOrderProducts.First().SalesOrderId);
            var dataTable = DataTableRepository.RetrieveDataTable(command);
            return dataTable.Rows.Cast<DataRow>()
                .Sum(row => PaymentRepository.FindById(row.Field<int>("payment_id").ToString()).Amount);
        }

        public bool IsAllPaymentCompleted()
        {
            return GetAmountPaid() >= GetTotalAmount();
        }

        public decimal GetAmountDue()
        {
            return GetTotalAmount() - GetAmountPaid();
        }
    }
}