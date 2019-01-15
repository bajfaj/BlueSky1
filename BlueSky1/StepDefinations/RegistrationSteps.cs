using System;
using TechTalk.SpecFlow;

namespace BlueSky1.StepDefinations
{
    [Binding]
    public class RegistrationSteps
    {

        [Given(@"I navigate to the site")]
        public void GivenINavigateToTheSite()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"I click on the register link")]
        public void WhenIClickOnTheRegisterLink()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"the registration page is displayed")]
        public void ThenTheRegistrationPageIsDisplayed()
        {
            ScenarioContext.Current.Pending();

        [Given(@"I input user login details on the site")]
        public void GivenIInputUserLoginDetailsOnTheSite()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I click on the login button")]
        public void WhenIClickOnTheLoginButton()
        {
            ScenarioContext.Current.Pending();    
        }
        
        [Then(@"the user homescreen is displayed")]
        public void ThenTheUserHomescreenIsDisplayed()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
