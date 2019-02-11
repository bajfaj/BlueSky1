using BlueSky1.Utilities;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlueSky1.PageObjects
{
    public class LoginPage : Hooks
    {
        [FindsBy(How = How.XPath, Using = "/html/body/div[3]/nav[1]/div/div/div[3]/ul/li[4]/a")]
        private IWebElement login;

        [FindsBy(How = How.Id, Using = "email")]
        private IWebElement emailElement; 

        [FindsBy(How = How.ClassName, Using = "le-input")]
        private IWebElement passwordElement;

        [FindsBy(How = How.CssSelector, Using = "# login-form > div.buttons-holder.text-center > button")]
        private IWebElement signin;
        private IWebDriver driver;

        public LoginPage()
        {
            PageFactory.InitElements(Hooks.Driver, this);
        }

        public void ClickSignin()
        {
            signin.Click();
        }

        public void TypePassword()
        {
            passwordElement.SendKeys("myPasswordisSecure");
        }

        public void TypeEmail()
        {
            emailElement.SendKeys("test@test.com");
        }

        public void ClickLogin()
        {
            login.Click();

        }

    }
}
