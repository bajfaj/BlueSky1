using BlueSky1.PageObjects;
using BlueSky1.Utilities;
using System;
using TechTalk.SpecFlow;

namespace BlueSky1.StepDefinations
{
    [Binding]
    public class LoginSteps : Hooks 
    {
        [Given(@"i navigate to the site")]
        public void GivenINavigateToTheSite()
        {
            Driver.Navigate().GoToUrl("http://www.giftrete.com");
        }

        LoginPage loginPage;

        public LoginSteps()
        {
            loginPage = new LoginPage();
            loginPage.ClickLogin();
        }
           

        [When(@"i click on login link")]
        public void WhenIClickOnLoginLink()
        {
            loginPage.ClickLogin();
        }
        
        [When(@"I enter a valid username")]
        public void WhenIEnterAValidUsername()
        {
            loginPage.TypeEmail();
        }
        
        [When(@"i enter a valid password")]
        public void WhenIEnterAValidPassword()
        {
            loginPage.TypePassword();
        }
        
        [When(@"I click on login button")]
        public void WhenIClickOnLoginButton()
        {
            loginPage.ClickSignin();
        }
        
        [Then(@"user should login succesfully")]
        public void ThenUserShouldLoginSuccesfully()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
