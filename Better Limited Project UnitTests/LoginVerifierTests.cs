using Better_Limited_Project.Login;
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
                string.Empty, "123");

            LoginStatus result = LoginVerifier.VerifyLogin(credentials);
            
            Assert.AreEqual(LoginStatus.EmptyUsername, result);
        }

        [Test]
        public void VerifyLogin_EmptyPassword_ReturnEmptyPasswordStatus()
        {
            var credentials = new LoginCredentials("user123", string.Empty);

            LoginStatus result = LoginVerifier.VerifyLogin(credentials);
            
            Assert.AreEqual(LoginStatus.EmptyPassword, result);
        }
    }
}