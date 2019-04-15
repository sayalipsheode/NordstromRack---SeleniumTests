using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NordstromRack.UI_Elements
{
    class LoginElements
    {
        public LoginElements()
        {
            PageFactory.InitElements(Driver.driver, this);
        }

        [FindsBy(How = How.LinkText, Using = "Log In / Sign Up")]
        public IWebElement Signup { get; set; }

        [FindsBy(How = How.CssSelector, Using = "button.authentication-modal__alternate-action")]
        public IWebElement LoginLink { get; set; }

        [FindsBy(How = How.CssSelector, Using = "input.form-label__input.form-label__input--email")]
        public IWebElement Email { get; set; }

        [FindsBy(How = How.CssSelector, Using = "input.form-label__input.form-label__input--password")]
        public IWebElement Password { get; set; }

        [FindsBy(How = How.CssSelector, Using = "a.secondary-nav__link")]
        public IWebElement Account { get; set; }
    }
}
