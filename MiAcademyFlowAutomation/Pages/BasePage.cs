using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;

namespace MiAcademyFlowAutomation.Pages
{
    public class BasePage
    {
        public readonly IWebDriver Driver;
        public WebDriverWait Wait;

        public BasePage(IWebDriver driver)
        {
            Driver = driver;
            Wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));
        }

        public void NavigateToUrl(string url)
        {
            Driver.Navigate().GoToUrl(url);
        }

        public IWebElement WaitForElementToBeClickable(IWebElement element)
        {
            return Wait.Until(ExpectedConditions.ElementToBeClickable(element));
        }

        public void ClickElement(IWebElement element)
        {
            WaitForElementToBeClickable(element);
            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;
            js.ExecuteScript("arguments[0].click();", element);
        }

        public IWebElement FindElement(By locator)
        {
            return Driver.FindElement(locator);
        }

        public void SelectComboBox(IWebElement element)
        {
            WaitForElementToBeClickable(element);
            Actions actions = new Actions(Driver);
            actions.MoveToElement(element).Click(element).Perform();
        }
    }
}
