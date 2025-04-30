using System;
using OpenQA.Selenium;

namespace WebAddressbookTests
{
    public class NavigationHelper : HelperBase
    {

        private String baseURL;

        public NavigationHelper(ApplicationManager manager, string baseURL) 
            : base(manager)
        {
            this.baseURL = baseURL;
        }

        public void GoToHomePage()
        {
            if (driver.Url == baseURL + "/addressbook/")
            {
                return;
            }
            else
            {
                driver.Navigate().GoToUrl(baseURL + "/addressbook/");
            }
        }

        public void GoToGroupsPage()
        {
            if (driver.Url == baseURL + "/addressbook/group.php"
                && IsElementPresent(By.Name("new")))
            {
                return;
            }
            else
            {
                driver.FindElement(By.LinkText("groups")).Click();
            }
        }

    }
}
