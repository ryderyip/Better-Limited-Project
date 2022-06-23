using System.Collections.Generic;
using System.Linq;
using Better_Limited_Project.ProductUtility.Entity;
using Better_Limited_Project.Sales.OrderPlacing.Entity;

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
            return _salesOrderProducts.Sum(sop => sop.GetProductPayments().Sum(sopp => sopp.GetPayment().Amount));
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