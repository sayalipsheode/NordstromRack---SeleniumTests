using NordstromRack.UI_Elements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System.Threading;

namespace NordstromRack
{
    public class SignUp
    {
        public void UserSignUp()
        {
            String parentHandle = Driver.driver.CurrentWindowHandle; // get the current window handle
            EmailSignUp signup = new EmailSignUp();
            signup.SignUpLink.Click();
            foreach (String winHandle in Driver.driver.WindowHandles)
            {
                Driver.driver.SwitchTo().Window(winHandle);
            }
            signup.EmailInput.Click();
            signup.EmailInput.SendKeys(Config.Credentials.Valid.BaseEmail);
            signup.Password.Click();
            signup.Password.SendKeys(Config.Credentials.Valid.Password);
            signup.Password.Submit();
            Driver.driver.SwitchTo().Window(parentHandle);
        }
        
}
}
