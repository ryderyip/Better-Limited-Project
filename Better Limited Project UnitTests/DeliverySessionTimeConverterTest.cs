using System;
using Better_Limited_Project.Sales.OrderPlacing.Controller;
using Better_Limited_Project.Sales.OrderPlacing.Entity;
using NUnit.Framework;

namespace UnitTests
{
    [TestFixture]
    public class DeliverySessionTimeConverterTest
    {
        [Test]
        public void GetTimeOfDay_Morning_Return9AM()
        {
            var result = DeliverySessionTimeConverter.GetTimeOfDay(DeliverySession.Morning);
            var expected = TimeSpan.FromHours(9);
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void GetTimeOfDay_Afternoon_Return1PM()
        {
            var result = DeliverySessionTimeConverter.GetTimeOfDay(DeliverySession.Afternoon);
            var expected = TimeSpan.FromHours(13);
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void GetTimeOfDay_Evening_Return6PM()
        {
            var result = DeliverySessionTimeConverter.GetTimeOfDay(DeliverySession.Evening);
            var expected = TimeSpan.FromHours(18);
            Assert.AreEqual(expected, result);
        }
    }
}