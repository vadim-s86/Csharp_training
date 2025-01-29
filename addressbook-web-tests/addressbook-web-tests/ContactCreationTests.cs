using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;

namespace WebAddressbookTests
{
    [TestFixture]
    public class ContactCreationTests : TestBase
    {
        [Test]
        public void ContactCreationTest()
        {
            GoToHomePage();
            Login(new AccountData("admin", "secret"));
            InitContactCreation();
            ContactData contactData = new ContactData("First_Name");
            contactData.LastName = "Last_Name";
            contactData.MobilPhone = "+799999999";
            contactData.Email = "mail@mail";
            contactData.BDay = "1";
            contactData.BMonth = "January";
            contactData.BYear = "1980";
            FillContactForm(contactData);
            SubmitContactCreation();
            ReturnToHomePage();
        }
    }
}
