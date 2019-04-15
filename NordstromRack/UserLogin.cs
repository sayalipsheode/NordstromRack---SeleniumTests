using NordstromRack.UI_Elements;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace NordstromRack
{
    class UserLogin
    {
        public void AccountLogin()
        {
            LoginElements login = new LoginElements();
            login.Signup.Click();
            login.LoginLink.Click();
            login.Email.SendKeys(Config.Credentials.Valid.BaseEmail);
            login.Password.SendKeys(Config.Credentials.Valid.Password);
            login.Password.Submit();
            //Driver.driver.SwitchTo().Window(parentHandle);
            Actions action2 = new Actions(Driver.driver);
            action2.MoveToElement(login.Account).Click().Build().Perform();
        }
    }
}
