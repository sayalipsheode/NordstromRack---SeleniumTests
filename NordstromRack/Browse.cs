using NordstromRack.UI_Elements;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace NordstromRack
{
    class Browse
    {
        Shop shopping = new Shop();
        public void SelectItem()
        {
            Thread.Sleep(2000);
            shopping.Women.Click();
            Thread.Sleep(2000);
            shopping.ActiveWear.Click();
            shopping.JacketsAndHoodies.Click();
            shopping.SelectJacket.Click();
            shopping.Color.Click();
            shopping.Size.Click();
            shopping.AddToCart.Submit();
        }
        public void Checkout()
        {
            foreach (String winHandle in Driver.driver.WindowHandles)
            {
                Driver.driver.SwitchTo().Window(winHandle);
            }
            shopping.Checkout.Click();
        }

        public void AssertSalesTax()
        {
            var salesTax = shopping.SalesTax.Text;
            Assert.AreEqual(salesTax, "$3.95");
            Console.WriteLine("Sales Tax is = " + salesTax);
            var dir = @"C:\Textfile" + DateTime.Now.ToShortDateString();
            if (!Directory.Exists(dir))
                Directory.CreateDirectory(dir);
            var fileName = "Assertion";
            File.AppendAllText(Path.Combine(dir, fileName), salesTax);
        }

        public void EmptyCart()
        {
            shopping.RemoveItem.Click();
        }
    }
}
