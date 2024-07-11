using System;
using System.Configuration;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;

namespace MiAcademyFlowAutomation
{
    public static class WebDriverSetup
    {
        public static IWebDriver InitializeWebDriver()
        {
            IWebDriver driver;
            string browser = ConfigurationManager.AppSettings["Browser"];

            switch (browser.ToLower())
            {
                case "firefox":
                    driver = new FirefoxDriver();
                    break;
                default:
                    driver = new ChromeDriver();
                    break;
            }

            driver.Manage().Timeouts().ImplicitWait =
                TimeSpan.FromSeconds(10);
            driver.Manage().Window.Maximize();
            return driver;
        }
    }
}