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
        public void GetTotalAmount_2SalesOrderProducts_ReturnCalculatedValue()
        {
            var sops = new List<SalesOrderProduct>
            {
                new("", "", 100, 10, false),
                new("", "", 200, 10, false)
            };
            var calculator = new SalesOrderCalculator(sops);

            decimal expected = 100 * 10 + 200 * 10;
            var result = calculator.GetTotalAmount();

            Assert.AreEqual(expected, result);
        }

        [Test]
        public void GetNonDepositAmount_NoDepositItem_ReturnSameAsTotal()
        {
            var sops = new List<SalesOrderProduct>
            {
                new("", "", 100, 10, false),
                new("", "", 200, 10, false)
            };
            var calculator = new SalesOrderCalculator(sops);

            decimal expected = 100 * 10 + 200 * 10;
            var result = calculator.GetNonDepositAmount();

            Assert.AreEqual(expected, result);
        }

        [Test]
        public void GetDepositAmount_NoDepositItem_ReturnDepositValue()
        {
            var sops = new List<SalesOrderProduct>
            {
                new("", "", 100, 10, false),
                new("", "", 200, 10, true)
            };
            var calculator = new SalesOrderCalculator(sops);

            var expected = 200 * 10 * Product.DepositPricePercentage;
            var result = calculator.GetDepositAmount();

            Assert.AreEqual(expected, result);
        }
    }
}