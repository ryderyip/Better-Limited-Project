using System.Collections.Generic;
using Better_Limited_Project.ProductUtility.Entity;
using Better_Limited_Project.Sales.OrderPlacing.Controller;
using Better_Limited_Project.Sales.OrderPlacing.Entity;
using NUnit.Framework;

namespace UnitTests
{
    [TestFixture]
    public class SalesOrderCalculatorTest
    {
        [Test]
        public void GetTotalAmount_2SalesOrderProducts_ReturnTotalAmount()
        {
            var sops = new List<SalesOrderProduct>
            {
                new()
                {
                    Price = 100,
                    Quantity = 10
                },
                new()
                {
                    Price = 200,
                    Quantity = 10
                }
            };
            var calculator = new SalesOrderCalculator(sops);

            decimal expected = 100 * 10 + 200 * 10;
            var result = calculator.GetTotalAmount();

            Assert.AreEqual(expected, result);
        }

        [Test]
        public void GetNonDepositAmount_1DepositItem_ReturnOnlyNonDepositAmount()
        {
            var sops = new List<SalesOrderProduct>
            {
                new()
                {
                    Price = 100, Quantity = 10, IsOutOfStock = true
                },
                new()
                {
                    Price = 200, Quantity = 10, IsOutOfStock = false
                }
            };
            var calculator = new SalesOrderCalculator(sops);

            decimal expected = 200 * 10;
            var result = calculator.GetNonDepositAmount();

            Assert.AreEqual(expected, result);
        }

        [Test]
        public void GetDepositAmount_1DepositItem_ReturnDepositValue()
        {
            var sops = new List<SalesOrderProduct>
            {
                new()
                {
                    Price = 100, Quantity = 10, IsOutOfStock = true
                },
                new()
                {
                    Price = 200, Quantity = 10, IsOutOfStock = false
                }
            };
            var calculator = new SalesOrderCalculator(sops);

            var expected = 100 * 10 * Product.DepositPricePercentage;
            var result = calculator.GetDepositAmount();

            Assert.AreEqual(expected, result);
        }
    }
}