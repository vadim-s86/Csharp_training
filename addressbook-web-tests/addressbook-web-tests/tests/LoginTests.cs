using NUnit.Framework;

namespace WebAddressbookTests
{
    [TestFixture]
    public class LoginTests : TestBase
    {
        [Test]
        public void LoginWithValidCredentials()
        {
            //подготовка
            app.Auth.Logout();

            //действия
            AccountData account = new AccountData("admin", "secret");
            app.Auth.Login(account);

            //проверка
            Assert.IsTrue(app.Auth.IsLoggedIn(account));
        }

        [Test]
        public void LoginWithInvalidCredentials()
        {
            //подготовка
            app.Auth.Logout();

            //действия
            AccountData account = new AccountData("admin", "12345678");
            app.Auth.Login(account);

            //проверка
            Assert.IsFalse(app.Auth.IsLoggedIn(account));
        }
    }
}
