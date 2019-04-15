

using NordstromRack.UI_Elements;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Diagnostics;
using System.IO;
using System.Threading;


namespace NordstromRack
{
    class EntryPoint
    {
        static void Main(string[] args)
        {
            Driver.driver.Navigate().GoToUrl("https://www.nordstromrack.com/");
            Driver.driver.Manage().Window.Maximize();
            //*Sign Up*
            SignUp signup = new SignUp();
            signup.UserSignUp();

            //*Profile Update*
            UserProfileUpdate profile = new UserProfileUpdate();
            profile.UpdateUserProfile();

            //*Login*
            UserLogin login = new UserLogin();
            login.AccountLogin();

            //*Shop for stuff*
            Browse browse = new Browse();
            browse.SelectItem();
            browse.Checkout();
            browse.AssertSalesTax();
            browse.EmptyCart();

            Thread.Sleep(5000);

            Driver.driver.Quit();



        }
    }
}
