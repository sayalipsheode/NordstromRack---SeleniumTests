

using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace NordstromRack.UI_Elements
{
    public class EmailSignUp
    {
        public EmailSignUp()
        {
            PageFactory.InitElements(Driver.driver, this);
        }

        [FindsBy(How = How.CssSelector, Using = "input.form-label__input.form-label__input--password")]
        public IWebElement Password { get; set; }

        [FindsBy(How = How.CssSelector, Using = "input.form-label__input.form-label__input--email")]
        public IWebElement EmailInput { get; set; }

        [FindsBy(How = How.ClassName, Using = "secondary-nav__link")]
        public IWebElement SignUpLink { get; set; }

        [FindsBy(How = How.CssSelector, Using = "button.cta-button.cta-button--nordstromrack")]
        public IWebElement CreateAccount { get; set; }

        [FindsBy(How = How.CssSelector, Using = "account-menu__link.account-menu__link--sign-out")]
        public IWebElement SignOut { get; set; }

    }
}
