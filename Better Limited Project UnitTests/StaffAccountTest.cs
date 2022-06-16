using Better_Limited_Project.Login;
using Moq;
using NUnit.Framework;

namespace UnitTests
{
    [TestFixture]
    public class StaffAccountTest
    {
        [Test]
        public void Save_NoCondition_InsertRecord()
        {
            // Arrange
            var staffAccount = new StaffAccount();
            var repo = new Mock<IStaffAccountRepository>();
            bool inserted = false;
            repo.Setup(x => x.InsertOrUpdate(staffAccount)).Callback(() => inserted = true);
            // Act
            staffAccount.Save(repo.Object);
            // Assert
            Assert.True(inserted);
        }
        
        [Test]
        public void Remove_NoCondition_DeleteRecord()
        {
            // Arrange
            var staffAccount = new StaffAccount();
            var repo = new Mock<IStaffAccountRepository>();
            bool deleted = false;
            repo.Setup(x => x.Delete(staffAccount)).Callback(() => deleted = true);
            // Act
            staffAccount.Remove(repo.Object);
            // Assert
            Assert.True(deleted);
        }
    }
}