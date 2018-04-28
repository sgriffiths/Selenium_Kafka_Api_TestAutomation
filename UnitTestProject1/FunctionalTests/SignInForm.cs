using System;
using FunctionalTests.Support;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using Assert = NUnit.Framework.Assert;

namespace FunctionalTests.FunctionalTests
{
    [TestClass]
    public class SignInForm : BaseClass
    {
        [TestMethod]
        public void SignUpFormAndAutoFillNew()
        {
            //Driver.Navigate().GoToUrl("https://williamhill.uat.williamhill.com.au/");
            //Driver.Navigate().GoToUrl("https://master.www.sit.williamhill.com.au/");
            Driver.Navigate().GoToUrl("https://williamhill.com.au/");

            Assert.AreEqual("Sports Betting Online & Horse Racing in Australia - William Hill", Driver.Title);
            Driver.FindElement(By.XPath("//*[contains(text(),'Sign up')]"), 5).Click();

            //Populate form
            Driver.FindElement(By.Name("email")).SendKeys("ETest@" + RandomString(10) + ".bin");
            Driver.FindElement(By.Name("username")).SendKeys("ETEST-" + RandomString(10));
            Driver.FindElement(By.Name("password")).SendKeys("test12345");
            Driver.FindElement(By.Name("firstname")).SendKeys("ETest-Functional-firstname");
            Driver.FindElement(By.Name("lastname")).SendKeys("ETest-Functional-lastname");
            Driver.FindElement(By.Name("dateOfBirth"), 2).SendKeys("01011991");
            Driver.FindElement(By.Name("mobile"),2).SendKeys("0421111222");
            Driver.FindElement(By.Name("fullAddress"),2).SendKeys("3 NEW ST, CAVES BEACH NSW 2281");

            //need to make this more dynamic and have it select the first item in the 'div class' list
            Driver.FindElement(By.XPath("//*[contains(text(),'3 NEW ST, CAVES BEACH NSW 2281')]"),5).Click();
            Driver.FindElement(By.XPath("//*[contains(text(),'Accept Terms & Conditions')]"),2).Click();
            //Driver.FindElement(By.Name("create account")).Click();

        //Console.WriteLine($"SingleBet PromoId: {Promotion.Id}");
        //Driver.FindElement(By.Id("submitLogin")).Click();
        }
        [TestCategory("Functional | SignIn Form")]
        [TestMethod]
        public void RunFunctionalTest()
        {
            SignUpFormAndAutoFillNew();
        }
    }
}
