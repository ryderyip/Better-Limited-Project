using System.Collections.Generic;
using System.Linq;
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
        public void IsUsernameValid_NameTooShort_False()
        {
            // Arrange
            var repo = new Mock<IStaffAccountRepository>();
            var verifier = new StaffAccountCreationVerifier(repo.Object);
            string username = "abc";
            // Act
            var result = verifier.IsUsernameValid(username);
            // Assert
            Assert.False(result);
        }
        
        [Test]
        public void IsUsernameValid_NameHasSpace_False()
        {
            // Arrange
            var repo = new Mock<IStaffAccountRepository>();
            var verifier = new StaffAccountCreationVerifier(repo.Object);
            string username = "username with space";
            // Act
            var result = verifier.IsUsernameValid(username);
            // Assert
            Assert.False(result);
        }

        [Test]
        public void IsUsernameUnique_Unique_True()
        {
            // Arrange
            string username = "a_unique_username";
            var repo = new Mock<IStaffAccountRepository>();
            repo.Setup(x => x.GetAll())
                .Returns(Enumerable.Empty<StaffAccount>());
            var verifier = new StaffAccountCreationVerifier(repo.Object);
            // Act
            var result = verifier.IsUsernameUnique(username);
            // Assert
            Assert.True(result);
        }
        
        [Test]
        public void IsUsernameUnique_NotUnique_False()
        {
            // Arrange
            string username = "a_used_username";
            var anotherAccount = new StaffAccount {Username = username};
            var repo = new Mock<IStaffAccountRepository>();
            repo.Setup(x => x.GetAll())
                .Returns(new List<StaffAccount> {anotherAccount});
            var verifier = new StaffAccountCreationVerifier(repo.Object);
            // Act
            var result = verifier.IsUsernameUnique(username);
            // Assert
            Assert.False(result);
        }

        [Test]
        public void IsPasswordValid_Valid_True()
        {
            // Arrange
            string password = "a_valid_password";
            var repo = new Mock<IStaffAccountRepository>();
            var verifier = new StaffAccountCreationVerifier(repo.Object);
            // Act
            var result = verifier.IsPasswordValid(password);
            // Assert
            Assert.True(result);
        }
        
        [Test]
        public void IsPasswordValid_PasswordHasSpace_False()
        {
            // Arrange
            string password = "password with space";
            var repo = new Mock<IStaffAccountRepository>();
            var verifier = new StaffAccountCreationVerifier(repo.Object);
            // Act
            var result = verifier.IsPasswordValid(password);
            // Assert
            Assert.False(result);
        }
        
        [Test]
        public void IsPasswordValid_PasswordTooShort_False()
        {
            // Arrange
            string password = "abc1234";
            var repo = new Mock<IStaffAccountRepository>();
            var verifier = new StaffAccountCreationVerifier(repo.Object);
            // Act
            var result = verifier.IsPasswordValid(password);
            // Assert
            Assert.False(result);
        }
    }
}