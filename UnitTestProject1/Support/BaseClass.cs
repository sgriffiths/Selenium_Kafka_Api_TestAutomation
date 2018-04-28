using System;
using System.Linq;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using TechTalk.SpecFlow;

namespace FunctionalTests.Support
{
    public class BaseClass : TechTalk.SpecFlow.Steps
    {
        protected readonly IWebDriver Driver = new ChromeDriver();
        private const string Sit = "sit";
        private const string Uat = "uat";
        //private static readonly string Env = ConfigurationManager.AppSettings["environment"].ToLower();
        protected static readonly Random Random = new Random();

        protected static string Name { get; set; }

        //protected static readonly string Username = $"ApiSmokeTestUser: {RandomString(10)}";
        //protected static readonly string Rolename = $"ApiSmokeTestRole: {RandomString(10)}";

        [BeforeScenario]
        public void UserLogin()
        {
        }

        [AfterScenario]
        public void AfterScenario()
        {
            Driver.Quit();
        }

        protected static string RandomString(int length)
        {
            const string Chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";

            return new string(Enumerable.Repeat(Chars, length).Select(s => s[Random.Next(s.Length)]).ToArray());
        }

    }
    public static class WebDriverExtensions
    {
        public static IWebElement FindElement(this IWebDriver driver, By by, int timeoutInSeconds)
        {
            if (timeoutInSeconds <= 0) return driver.FindElement(@by);
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeoutInSeconds));
            return wait.Until(drv => drv.FindElement(@by));
        }
    }
}
