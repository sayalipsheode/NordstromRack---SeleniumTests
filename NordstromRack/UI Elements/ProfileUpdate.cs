

using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace NordstromRack.UI_Elements
{
    public class ProfileUpdate
    {
        public ProfileUpdate()
        {
            PageFactory.InitElements(Driver.driver, this);
        }

        [FindsBy(How = How.LinkText, Using = "Profile")]
        public IWebElement Profile { get; set; }

        [FindsBy(How = How.CssSelector, Using = "a.secondary-nav__link")]
        public IWebElement Account { get; set; }

        [FindsBy(How = How.Name, Using = "firstName")]
        public IWebElement FirstName { get; set; }

        [FindsBy(How = How.Name, Using = "lastName")]
        public IWebElement Lastname { get; set; }

        [FindsBy(How = How.Name, Using = "zipcode")]
        public IWebElement ZipCode { get; set; }

        [FindsBy(How = How.Name, Using = "")]
        public IWebElement UpdateProfile { get; set; }

    }
}
