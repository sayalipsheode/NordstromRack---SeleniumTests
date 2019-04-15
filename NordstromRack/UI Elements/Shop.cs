

using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace NordstromRack.UI_Elements
{
    public class Shop
    {
        public Shop()
        {
            PageFactory.InitElements(Driver.driver, this);
        }
        [FindsBy(How = How.XPath, Using = "//*[contains(text(), 'Women')]")]
        public IWebElement Women { get; set; }

        [FindsBy(How = How.LinkText, Using = "Activewear")]
        public IWebElement ActiveWear{ get; set; }

        [FindsBy(How = How.LinkText, Using = "Jackets & Hoodies")]
        public IWebElement JacketsAndHoodies { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@href='/shop/product/2299794/nike-vintage-drawstring-hoodie?color=BLACK%2FSAIL']")]
        public IWebElement SelectJacket { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@href='?color=TRUBER%2FSAIL']")]
        public IWebElement Color { get; set; }

        [FindsBy(How = How.CssSelector, Using = "div.product-details__add-to-cart")]
        public IWebElement AddToCart { get; set; }

        [FindsBy(How = How.CssSelector, Using = "span.cart-button__label")]
        public IWebElement Cart { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@href='?color=TRUBER%2FSAIL&size=L']")]
        public IWebElement Size { get; set; }

        [FindsBy(How = How.CssSelector, Using = "div.cart-with-items__checkout-button")]
        public IWebElement Checkout { get; set; }

        [FindsBy(How = How.XPath, Using = "//*/dl/dd[3]")]
        public IWebElement SalesTax { get; set; }

        [FindsBy(How = How.ClassName, Using = "checkout-cart-item__remove")]
        public IWebElement RemoveItem { get; set; }

        

    }
}
