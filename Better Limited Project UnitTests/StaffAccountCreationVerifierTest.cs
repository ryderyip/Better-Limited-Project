using System.Collections.Generic;
using Better_Limited_Project.Login;
using Moq;
using NUnit.Framework;

namespace UnitTests
{
    [TestFixture]
    public class StaffAccountCreationVerifierTest
    {
        [Test]
        public void IsUsernameValid_Valid_True()
        {
            // Arrange
            var repo = new Mock<IStaffAccountRepository>();
            var verifier = new StaffAccountCreationVerifier(repo.Object);
            string username = "a_valid_username";
            // Act
            var result = verifier.IsUsernameValid(username);
            // Assert
            Assert.True(result);
        }

        [Test]
        public void IsUsernameUnique_Unique_True()
        {
            // Arrange
            string username = "a_unique_username";
            var repo = new Mock<IStaffAccountRepository>();
            repo.Setup(x => x.GetAll()).Returns(new List<StaffAccount> {new()});
            var verifier = new StaffAccountCreationVerifier(repo.Object);
            // Act
            var result = verifier.IsUsernameUnique(username);
            // Assert
            Assert.True(result);
        }

        [Test]
        public void IsPasswordValid_Valid_True()
        {
            // Arrange
            string password = "a_valid_password";
            var verifier = new StaffAccountCreationVerifier(new Mock<IStaffAccountRepository>().Object);
            // Act
            var result = verifier.IsPasswordValid(password);
            // Assert
            Assert.True(result);
        }
    }
}