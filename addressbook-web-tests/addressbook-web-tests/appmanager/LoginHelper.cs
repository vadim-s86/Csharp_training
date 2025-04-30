using OpenQA.Selenium;
using System;

namespace WebAddressbookTests
{
    public class LoginHelper : HelperBase
    {


        public LoginHelper(ApplicationManager manager)
            : base(manager)
        {
        }

        public void Login(AccountData account)
        {
            if (IsLoggedIn())
            {
                if (IsLoggedIn(account))
                {
                    return;
                }
                Logout();
            }
            else
            {
                Type(By.Name("user"), account.Username);
                Type(By.Name("pass"), account.Passwords);
                driver.FindElement(By.XPath("//input[@value='Login']")).Click();
            }
        }

        public void Logout()
        {
            if (IsLoggedIn())
            {
                driver.FindElement(By.LinkText("Logout")).Click();
            }
        }

        public bool IsLoggedIn()
        {
            return IsElementPresent(By.Name("logout"));
        }

        public bool IsLoggedIn(AccountData account)
        {
            return IsElementPresent(By.Name("logout"))
                && driver.FindElement(By.Name("logout")).FindElement(By.TagName("b")).Text
                    == "(" + account.Username + ")";
        }
    }
}
