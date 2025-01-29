using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;

namespace WebAddressbookTests
{
    [TestFixture]
    public class ContactRemovalTests : TestBase
    {
        [Test]
        public void ContactRemovalTest()
        {
            GoToHomePage();
            Login(new AccountData("admin", "secret"));
            SelectElement(1);
            RemoveContact();
            GoToHomePage();
        }
    }
}
