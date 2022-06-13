using Better_Limited_Project.ProductUtility.Reordering.Entity;
using NUnit.Framework;

namespace UnitTests
{
    [TestFixture]
    public class ProductQuantityTest
    {
        private ProductQuantity _productQuantity;

        [SetUp]
        public void SetUp()
        {
            _productQuantity = new ProductQuantity("1", 1);
        }
        
        [TestCase("1", 2)]
        [TestCase("2", 1)]
        public void DogUnequal(string productId, int quantity)
        {
            var pq = new ProductQuantity(productId, quantity);

            Assert.AreNotEqual(_productQuantity, pq);
        }
        
        [TestCase("1", 1)]
        public void DogEqual(string productId, int quantity)
        {
            var pq = new ProductQuantity(productId, quantity);

            Assert.AreEqual(_productQuantity, pq);
        }
        
        [TestCase("1", 1)]
        public void DogEqualOperator(string productId, int quantity)
        {
            var pq = new ProductQuantity(productId, quantity);

            Assert.True(_productQuantity == pq);
        }
    }
}