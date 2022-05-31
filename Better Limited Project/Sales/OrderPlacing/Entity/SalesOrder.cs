using System;
using System.Collections.Generic;
using System.Linq;
using Better_Limited_Project.CustomerRecord;
using Better_Limited_Project.ProductUtility.Entity;
using Better_Limited_Project.Sales.OrderPlacing.Repository;
using Better_Limited_Project.Sales.PaymentUtility;
using Better_Limited_Project.StaffUtility.StaffEntity;

namespace Better_Limited_Project.Sales.OrderPlacing.Entity
{
    public class SalesOrder : IEntity
    {
        public string Id { get; set; }
        public string OrderNumber { get; set; }
        public Staff Staff { get; set; }
        public RetailStore RetailStore { get; set; }
        public ICollection<SalesOrderProduct> SalesOrderProducts { get; set; }
        public Customer? Customer { get; set; }
        public DateTime CreatedOn { get; set; }
        public Payment? Payment { get; set; }

        public void Save()
        {
            new SalesOrderRepository().Insert(this);
        }

        public decimal GetTotalPrice()
        {
            return SalesOrderProducts.Sum(sop => sop.Price * sop.Quantity);
        }

        public decimal GetDepositPrice()
        {
            decimal deposit = SalesOrderProducts
                .Where(sop => sop.IsDeposit)
                .Sum(sop => sop.Price * sop.Quantity * Product.DepositPricePercentage);
            decimal ordinary = SalesOrderProducts
                .Where(sop => !sop.IsDeposit)
                .Sum(sop => sop.Price * sop.Quantity);
            return deposit + ordinary;
        }
    }
}