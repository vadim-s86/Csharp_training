using NUnit.Framework;

namespace WebAddressbookTests
{
    [TestFixture]
    public class ContactModificationTests : TestBase
    {

        [Test]
        public void ContactModificationTest()
        {
            ContactData newContactData = new ContactData("Modify Contact Name");
            newContactData.LastName = "Modify Last_Name";
            newContactData.MobilPhone = "+799118888";
            newContactData.Email = "test_mail@mail.ru";
            newContactData.BDay = "5";
            newContactData.BMonth = "November";
            newContactData.BYear = "2000";
            app.Contacts.Modify(newContactData);
        }
    }
}
