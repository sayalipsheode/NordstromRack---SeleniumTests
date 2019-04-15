using NordstromRack.UI_Elements;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace NordstromRack
{
    class UserProfileUpdate
    {
        public void UpdateUserProfile()

        {
            ProfileUpdate profile = new ProfileUpdate();
            Thread.Sleep(2000);
            Actions action = new Actions(Driver.driver);
            action.MoveToElement(profile.Account).Click().Build().Perform();
            profile.Profile.Click();
            profile.FirstName.SendKeys("S");
            profile.Lastname.SendKeys("Survys");
            profile.ZipCode.Clear();
            profile.ZipCode.SendKeys("06905");
            profile.ZipCode.Submit();
        }
    }
}
