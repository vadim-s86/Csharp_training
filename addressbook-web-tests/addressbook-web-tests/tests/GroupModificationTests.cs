using NUnit.Framework;

namespace WebAddressbookTests
{
    [TestFixture]
    public class GroupModificationTests : TestBase
    {
        [Test]
        public void GroupModificationTest()
        {
            GroupData newData = new GroupData("Group Modify name");
            newData.Header = "New header";
            newData.Footer = "New footer";

            app.Groups.Modify(1, newData);
        }
    }
}
