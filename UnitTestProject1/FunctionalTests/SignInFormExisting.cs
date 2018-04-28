using System;
using FunctionalTests.Support;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using Assert = NUnit.Framework.Assert;

namespace FunctionalTests.FunctionalTests
{
    [TestClass]
    public class SignInFormExisting : BaseClass
    {
        [TestMethod]
        public void SignUpFormAndAutoFill()
        {
            //Driver.Navigate().GoToUrl("https://carp-517.www.sit.williamhill.com.au/");
            //Driver.Navigate().GoToUrl("https://master.www.sit.williamhill.com.au/");
            Driver.Navigate().GoToUrl("https://williamhill.uat.williamhill.com.au/");
            
            Assert.AreEqual("Sports Betting Online & Horse Racing in Australia - William Hill", Driver.Title);
            Driver.FindElement(By.XPath("//*[contains(text(),'Sign up')]"), 5).Click();

            //Populate form
            Driver.FindElement(By.Id("emailAddress")).SendKeys("ETest@" + RandomString(10) + ".bin");
            Driver.FindElement(By.Id("username")).SendKeys("ETEST-" + RandomString(10));
            Driver.FindElement(By.Id("password")).SendKeys("test12345");
            Driver.FindElement(By.Id("firstName")).SendKeys("ETest-Functional-firstId");
            Driver.FindElement(By.Id("lastName")).SendKeys("ETest-Functional-lastId");
            Driver.FindElement(By.Name("dateOfBirth"), 2).SendKeys("01011991");
            Driver.FindElement(By.Name("mobile"), 2).SendKeys("0421111222");
            Driver.FindElement(By.Id("fullAddress")).SendKeys("3 NEW ST, CAVES BEACH NSW 2281");

            //Console.WriteLine($"SingleBet PromoId: {Promotion.Id}");
            //Driver.FindElement(By.Id("submitLogin")).Click();
        }
        [TestCategory("Functional | SignIn Form")]
        [TestMethod]
        public void RunFunctionalTestExisting()
        {
            SignUpFormAndAutoFill();
        }
    }
}
