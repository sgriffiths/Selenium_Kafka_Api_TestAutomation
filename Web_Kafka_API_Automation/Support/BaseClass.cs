using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using TechTalk.SpecFlow;

namespace Web_Kafka_API_Automation.Support
{
    public class BaseClass : TechTalk.SpecFlow.Steps
    {
        protected readonly IWebDriver Driver = new ChromeDriver();
        private const string Sit = "sit";
        private const string Uat = "uat";
        //private static readonly string Env = ConfigurationManager.AppSettings["environment"].ToLower();
        protected static readonly Random Random = new Random();


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
