using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace BlueSky1.Utilities
{
    [Binding]
    public class Hooks
    {

        public static IWebDriver Driver;

        [BeforeScenario]
        public void BeforeScenario()
        {
            Driver = new chromedriver();
        }

        [AfterScenario]
        public void AfterScenario()
        {
            Driver.Quit();
        }
    }
}
