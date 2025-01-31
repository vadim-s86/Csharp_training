using NUnit.Framework;

namespace WebAddressbookTests
{
    [TestFixture]
    public class ContactCreationTests : TestBase
    {
        [Test]
        public void ContactCreationTest()
        {
            ContactData contactData = new ContactData("First_Name");
            contactData.LastName = "Last_Name";
            contactData.MobilPhone = "+799999999";
            contactData.Email = "mail@mail";
            contactData.BDay = "1";
            contactData.BMonth = "January";
            contactData.BYear = "1980";

            app.Contacts.Create(contactData);
        }

        [Test]
        public void EmptyContactCreationTest()
        {
            ContactData contactData = new ContactData("");
            contactData.LastName = "";
            contactData.MobilPhone = "";
            contactData.Email = "";
            contactData.BDay = "";
            contactData.BMonth = "";
            contactData.BYear = "";

            app.Contacts.Create(contactData);
        }
    }
}
