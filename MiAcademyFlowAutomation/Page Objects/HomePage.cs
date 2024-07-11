using System;
using System.Configuration;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace MiAcademyFlowAutomation.Page_Objects
{
    public class HomePage
    {
        private readonly IWebDriver _driver;

        public HomePage(IWebDriver driver)
        {
            _driver = driver;
        }

        public IWebElement MiaPrepLink =>
            _driver.FindElement(By.LinkText("Online High School"));

        public void NavigateToHomePage()
        {
            _driver.Navigate().GoToUrl(ConfigurationManager.AppSettings["HomePageUrl"]);
        }

        public void ClickMiaPrepLink()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)_driver;
            js.ExecuteScript("arguments[0].click();", MiaPrepLink);
        }
    }
}