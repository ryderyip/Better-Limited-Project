using System;
using System.Linq;
using Better_Limited_Project.Login;
using Moq;
using NUnit.Framework;

namespace UnitTests
{
    [TestFixture]
    public class LoginVerifierTests
    {
        [Test]
        public void VerifyLogin_EmptyUsername_ReturnEmptyUsernameStatus()
        {
            var credentials = new LoginCredentials(
                string.Empty, "some_password");

            var repo = new Mock<IStaffAccountRepository>();
            repo.Setup(x => x.FindAll(It.Is<Predicate<StaffAccount>>(ac => false)))
                .Returns(Enumerable.Empty<StaffAccount>());
            var verifier = new LoginVerifier(repo.Object);
            var result = verifier.VerifyLogin(credentials);

            Assert.AreEqual(LoginStatus.EmptyUsername, result);
        }

        [Test]
        public void VerifyLogin_EmptyPassword_ReturnEmptyPasswordStatus()
        {
            var credentials = new LoginCredentials(
                "some_username", string.Empty);

            var repo = new Mock<IStaffAccountRepository>();
            repo.Setup(x => x.FindAll(It.Is<Predicate<StaffAccount>>(ac => false)))
                .Returns(Enumerable.Empty<StaffAccount>());
            var verifier = new LoginVerifier(repo.Object);
            var result = verifier.VerifyLogin(credentials);

            Assert.AreEqual(LoginStatus.EmptyPassword, result);
        }

        [Test]
        public void VerifyLogin_UsernameDoesntExist_ReturnWrongUsernameStatus()
        {
            var credentials = new LoginCredentials(
                "some_wrong_username", "some_wrong_password");

            var repo = new Mock<IStaffAccountRepository>();
            repo.Setup(x => x.FindAll(It.Is<Predicate<StaffAccount>>(ac => false)))
                .Returns(Enumerable.Empty<StaffAccount>());
            var verifier = new LoginVerifier(repo.Object);
            var result = verifier.VerifyLogin(credentials);

            Assert.AreEqual(LoginStatus.WrongUsernameOrPassword, result);
        }

        [Test]
        public void VerifyLogin_CorrectUsernameAndPassword_ReturnLoginSuccessStatus()
        {
            var credentials = new LoginCredentials(
                "correct_username", "correct_password");

            var repo = new Mock<IStaffAccountRepository>();
            repo.Setup(x => x.FindByKey(credentials.Username))
                .Returns(new StaffAccount("", credentials.Username, credentials.Password));
            var verifier = new LoginVerifier(repo.Object);
            var result = verifier.VerifyLogin(credentials);

            Assert.AreEqual(LoginStatus.Successful, result);
        }
    }
}