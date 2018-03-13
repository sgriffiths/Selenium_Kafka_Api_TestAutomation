using System;
using TechTalk.SpecFlow;

namespace UnitTestProject1.Features.Steps
{
    [Binding]
    public class LoginToTheWebsiteSteps
    {
        [Given(@"I access the login page")]
        public void GivenIAccessTheLoginPage()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I login to the webpage using valid credentials")]
        public void WhenILoginToTheWebpageUsingValidCredentials()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I will be successfully logged in")]
        public void ThenIWillBeSuccessfullyLoggedIn()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
