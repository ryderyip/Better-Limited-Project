using System.Collections.Generic;
using System.Linq;
using Better_Limited_Project.ProductUtility.Entity;
using Better_Limited_Project.Sales.OrderPlacing.Entity;
using Better_Limited_Project.Sales.PaymentUtility.Repository;

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

        public decimal GetInStockItemPrice()
        {
            return _salesOrderProducts
                .Where(sop => !sop.IsOutOfStock)
                .Sum(sop => sop.Price * sop.Quantity);
        }

        public decimal GetAmountPaid()
        {
            return (from sop in _salesOrderProducts select sop.GetProductPayments()).SelectMany(payments => payments)
                .GroupBy(p => p.PaymentId)
                .Sum(paymentIdPayment => PaymentRepository.FindById(paymentIdPayment.Key).Amount);
        }

        public bool IsAllPaymentCompleted()
        {
            return _salesOrderProducts.All(sop => sop.GetProductPayments().Count() != 0)
                   && GetTotalAmount() >= GetAmountPaid();
        }

        public decimal GetAmountDue()
        {
            return GetTotalAmount() - GetAmountPaid();
        }
    }
}