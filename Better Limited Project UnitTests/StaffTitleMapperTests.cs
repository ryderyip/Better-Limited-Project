using Better_Limited_Project.StaffUtility.StaffEntity;
using NUnit.Framework;

namespace UnitTests
{
    [TestFixture]
    public class StaffTitleMapperTests
    {
        [SetUp]
        public void SetUp()
        {
            _mapper = new StaffTitleMapper();
        }

        private StaffTitleMapper _mapper;

        [Test]
        public void Map_InputSalesManagerEnum_ReturnSalesManagerString()
        {
            string result = _mapper.Map(StaffTitle.TechnicalSupportManager);
            string expected = "Technical Support Manager";

            Assert.AreEqual(expected, result);
        }

        [Test]
        public void Map_InputSalesManagerString_ReturnSalesManagerEnum()
        {
            var result = _mapper.Map("sales manager");
            var expected = StaffTitle.SalesManager;

            Assert.AreEqual(expected, result);
        }

        [Test]
        public void Map_InputUnknownString_ReturnUnknownTitleEnum()
        {
            var result = _mapper.Map("CEO");
            var expected = StaffTitle.Unknown;

            Assert.AreEqual(expected, result);
        }

        [Test]
        public void Map_InputUnknownTitleEnum_ReturnUnknownTitleString()
        {
            string result = _mapper.Map(StaffTitle.Unknown);
            string expected = "Unknown Title";

            Assert.AreEqual(expected, result);
        }
    }
}