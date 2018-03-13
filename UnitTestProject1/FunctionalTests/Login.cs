using FunctionalTests.Support;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using Assert = NUnit.Framework.Assert;

namespace FunctionalTests.FunctionalTests
{
    [TestClass]
    public class Login : BaseClass
    {
        [TestMethod]
        public void AccessSignInFormAndAutoFill()
        {
            Driver.Navigate().GoToUrl("https://carp-517.www.sit.williamhill.com.au/");
            Assert.AreEqual("Sports Betting Online & Horse Racing in Australia - William Hill", Driver.Title);
            //ChromeDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            Driver.FindElement(By.XPath("//button[contains(text(),'Log in')]"), 5).Click();

            //Populate form
            Driver.FindElement(By.Id("username")).SendKeys("ETESTPromoTest992791");
            Driver.FindElement(By.Id("password")).SendKeys("test12345");
            Driver.FindElement(By.Id("submitLogin")).Click();
            Driver.Navigate().GoToUrl("https://carp-517.www.sit.williamhill.com.au/account/accountdetails");
        }

        [TestCategory("Functional | SignIn Form")]
        [TestMethod]
        public void RunFunctionalLoginTestSit()
        {
            AccessSignInFormAndAutoFill();
        }
    }
}
