using Better_Limited_Project.Tools;
using NUnit.Framework;

namespace UnitTests
{
    [TestFixture]
    public class StringHelperTest
    {
        [Test]
        [TestCase("Dog123_")]
        [TestCase("")]
        public void IsAlphaNumericPlusUnderscore(string text)
        {
            var result = StringHelper.IsAlphaNumericPlusUnderscore(text);
            
            Assert.True(result);
        }
        
        [Test]
        [TestCase("%^&*)")]
        [TestCase(" ")]
        public void IsAlphaNumericPlusUnderscore_NotAlphanumeric(string text)
        {
            var result = StringHelper.IsAlphaNumericPlusUnderscore(text);
            
            Assert.False(result);
        }
    }
}