using Better_Limited_Project.StaffUtility.StaffEntity;
using NUnit.Framework;

namespace Better_Limited_Test
{
    [TestFixture]
    public class StaffTitleMapperTests
    {
        private StaffTitleMapper _mapper;
        
        [SetUp]
        public void SetUp()
        {
            _mapper = new StaffTitleMapper();
        }
        
        [Test] 
        public void Map_InputSalesManagerEnum_ReturnSalesManagerString()
        {
            string result = _mapper.Map(StaffTitle.SalesManager);
            string expected = "Sales Manager";
            
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void Map_InputSalesManagerString_ReturnSalesManagerEnum()
        {
            StaffTitle result = _mapper.Map("sales manager");
            StaffTitle expected = StaffTitle.SalesManager;
            
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void Map_InputUnknownString_ReturnUnknownTitleEnum()
        {
            StaffTitle result = _mapper.Map("CEO");
            StaffTitle expected = StaffTitle.Unknown;
            
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