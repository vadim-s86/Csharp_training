using OpenQA.Selenium;
using System.Text.RegularExpressions;

namespace WebAddressbookTests
{
    public class ContactHelper : HelperBase
    {

        public ContactHelper(ApplicationManager manager) 
            : base(manager)
        {
        }

        public ContactHelper Create(ContactData contactData)
        {
            InitContactCreation();
            FillContactForm(contactData);
            SubmitContactCreation();
            ReturnToHomePage();

            return this;
        }

        public ContactHelper Modify(ContactData newData)
        {
            manager.Navigator.GoToHomePage();
            InitContactModification();
            FillContactForm(newData);
            SubmitContactModification();
            ReturnToHomePage();

            return this;
        }

        public ContactHelper Remove(int v)
        {
            manager.Navigator.GoToHomePage();
            if (! IsElementPresent(By.Name("selected[]")))
            {
                Create(new ContactData("First_Name"));
            }
            SelectElement(v);
            RemoveContact();
            AcceptContactAlert();
            manager.Navigator.GoToHomePage();

            return this;
        }

        public ContactHelper InitContactCreation()
        {
            driver.FindElement(By.LinkText("add new")).Click();

            return this;
        }

        public ContactHelper InitContactModification()
        {
            if (!IsElementPresent(By.Name("selected[]")))
            {
                Create(new ContactData("First_Name"));
            }
            driver.FindElement(By.XPath("//img[@alt='Edit']")).Click();

            return this;
        }

        public ContactHelper FillContactForm(ContactData contact)
        {
            Type(By.Name("firstname"), contact.FirstName);
            Type(By.Name("middlename"), contact.MiddleName);
            Type(By.Name("lastname"), contact.LastName);
            Type(By.Name("nickname"), contact.NickName);
            Type(By.Name("title"), contact.Title);
            Type(By.Name("company"), contact.Company);
            Type(By.Name("address"), contact.Address);
            Type(By.Name("home"), contact.HomePhone);
            Type(By.Name("mobile"), contact.MobilPhone);
            Type(By.Name("work"), contact.WorkPhone);
            Type(By.Name("fax"), contact.Fax);
            Type(By.Name("email"), contact.Email);
            Type(By.Name("email2"), contact.Email2);
            Type(By.Name("email3"), contact.Email3);
            Type(By.Name("homepage"), contact.HomePage);
            Type(By.Name("bday"), contact.BDay);
            Type(By.Name("bmonth"), contact.BMonth);
            Type(By.Name("byear"), contact.BYear);
            Type(By.Name("aday"), contact.ADay);
            Type(By.Name("amonth"), contact.AMonth);
            Type(By.Name("ayear"), contact.AYear);
            if (IsElementPresent(By.Name("new_group")))
            {
                Type(By.Name("new_group"), contact.Group);
            }

            return this;
        }

        public ContactHelper SubmitContactCreation()
        {
            driver.FindElement(By.Name("submit")).Click();

            return this;
        }

        public ContactHelper SubmitContactModification()
        {
            driver.FindElement(By.Name("update")).Click();

            return this;
        }

        public ContactHelper RemoveContact()
        {
            driver.FindElement(By.XPath("//input[@value='Delete']")).Click();

            return this;
        }

        private ContactHelper AcceptContactAlert()
        { 
            if(Regex.IsMatch(driver.SwitchTo().Alert().Text, "^Delete 1 addresses[\\s\\S]$"))
                driver.SwitchTo().Alert().Accept();

            return this;
        }

        public ContactHelper ReturnToHomePage()
        {
            driver.FindElement(By.LinkText("home page")).Click();

            return this;
        }
    }
}
