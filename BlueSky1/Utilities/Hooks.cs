using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace BlueSky1.Utilities
{
    [Binding]
    public sealed class Hooks
    {
        
        [BeforeScenario]
        public void BeforeScenario()
        {
            ChromeDriver driver = new chromedriver();
        }

        [AfterScenario]
        public void AfterScenario()
        {
            
        }
    }
}
