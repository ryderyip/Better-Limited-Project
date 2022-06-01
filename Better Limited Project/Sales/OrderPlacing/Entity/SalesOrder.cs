using System;
using System.Collections.Generic;
using System.Linq;
using Better_Limited_Project.CustomerRecord;
using Better_Limited_Project.ProductUtility.Entity;
using Better_Limited_Project.Sales.OrderPlacing.Repository;
using Better_Limited_Project.Sales.PaymentUtility.Repository;
using Better_Limited_Project.StaffUtility.StaffEntity;

namespace Better_Limited_Project.Sales.OrderPlacing.Entity
{
    public class SalesOrder : IEntity
    {
        public SalesOrder(Staff staff, RetailStore retailStore)
        {
            Id = Guid.NewGuid().ToString();
            OrderNumber = new SalesOrderRepository().GetNewOrderNumber();
            Staff = staff;
            RetailStore = retailStore;
        }

        public SalesOrder(string id, string orderNumber, Staff staff, RetailStore retailStore)
        {
            Id = id;
            OrderNumber = orderNumber;
            Staff = staff;
            RetailStore = retailStore;
        }

        public string Id { get; }
        public string OrderNumber { get; }
        public Staff Staff { get; }
        public RetailStore RetailStore { get; }
        public ICollection<SalesOrderProduct> SalesOrderProducts { get; } = new List<SalesOrderProduct>();
        public Customer? Customer { get; set; }
        public DateTime CreatedOn { get; set; }

        public void Save()
        {
            new SalesOrderRepository().Insert(this);
        }

        public decimal GetTotalAmount()
        {
            return SalesOrderProducts.Sum(sop => sop.Price * sop.Quantity);
        }

        public decimal GetDepositPrice()
        {
            return SalesOrderProducts
                .Where(sop => sop.IsOutOfStock)
                .Sum(sop => sop.Price * sop.Quantity * Product.DepositPricePercentage);
        }

        public decimal GetInStockItemPrice()
        {
            return SalesOrderProducts
                .Where(sop => !sop.IsOutOfStock)
                .Sum(sop => sop.Price * sop.Quantity);
        }

        public decimal GetAmountPaid()
        {
            decimal amount = 0;
            foreach (var salesOrderProduct in SalesOrderProducts)
            {
                amount += salesOrderProduct.Payments.Sum(sopp => PaymentRepository.FindById(sopp.PaymentId).Amount);
            }

            return amount;
            /*return SalesOrderProducts.Sum(sop =>
                sop.Payments.Sum(sopp => PaymentRepository.FindById(sopp.PaymentId).Amount));*/
        }

        public bool IsAllPaymentCompleted()
        {
            return SalesOrderProducts.All(sop => sop.Payments.Count != 0)
                   && GetTotalAmount() >= GetAmountPaid();
        }
    }
}