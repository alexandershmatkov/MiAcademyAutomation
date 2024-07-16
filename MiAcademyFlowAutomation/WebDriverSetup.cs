using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Configuration;

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
                    FirefoxOptions firefoxOptions = new FirefoxOptions();
                    firefoxOptions.AddArgument("--width=1280");
                    firefoxOptions.AddArgument("--height=800");
                    driver = new FirefoxDriver(firefoxOptions);
                    break;
                default:
                    ChromeOptions chromeOptions = new ChromeOptions();
                    chromeOptions.AddArgument("window-size=1280,800");
                    driver = new ChromeDriver(chromeOptions);
                    break;
            }

            driver.Manage().Timeouts().ImplicitWait =
                TimeSpan.FromSeconds(10);
            return driver;
        }
    }
}