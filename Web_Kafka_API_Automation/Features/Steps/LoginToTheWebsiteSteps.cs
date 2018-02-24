using System;
using NUnit.Framework;
using OpenQA.Selenium;
using TechTalk.SpecFlow;
using Web_Kafka_API_Automation.Support;

namespace Web_Kafka_API_Automation.Features.Steps
{
    [Binding]
    public class LoginToTheWebsiteSteps : BaseClass
    {
        [Given(@"I access the login page")]
        public void GivenIAccessTheLoginPage()
        {
            Driver.Navigate().GoToUrl("https://williamhill.uat.williamhill.com.au/");
            Assert.AreEqual("Sports Betting Online & Horse Racing in Australia - William Hill", Driver.Title);
            //ChromeDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            Driver.FindElement(By.XPath("//button[contains(text(),'Log in')]"), 5).Click();
        }

        [When(@"I login to the webpage using valid credentials")]
        public void WhenILoginToTheWebpageUsingValidCredentials()
        {
            Driver.FindElement(By.Id("username")).SendKeys("ETEST270745");
            Driver.FindElement(By.Id("password")).SendKeys("test12345");
            Driver.FindElement(By.Id("submitLogin")).Click();
            Driver.Navigate().GoToUrl("https://williamhill.uat.williamhill.com.au/account/accountdetails");
        }

        [Then(@"I will be successfully logged in")]
        public void ThenIWillBeSuccessfullyLoggedIn()
        {
            var body = Driver.FindElement(By.TagName("body"));
            Assert.IsTrue(body.Text.Contains("Save Changes"));
        }
    }
}
