using OpenQA.Selenium;
using System;
using OpenQA.Selenium.Interactions;

namespace MiAcademyFlowAutomation.Page_Objects
{
    public class OnlineHighSchoolPage
    {
        private readonly IWebDriver _driver;

        public OnlineHighSchoolPage(IWebDriver driver)
        {
            _driver = driver;
        }

        // Header button
        public IWebElement ApplyButton1 =>
            _driver.FindElement(By.XPath("//a[contains(@class, 'has-theme-palette-2-background-color') and contains(., 'Apply to Our School')]"));

        // Button in a middle of the page
        public IWebElement ApplyButton2 =>
            _driver.FindElement(By.XPath(
                "//a[contains(@class, 'has-theme-palette-9-background-color') and contains(., 'Apply to Our School')]"));

        // Button from the bottom of the page
        public IWebElement ApplyButton3 =>
            _driver.FindElement(By.XPath("//a[contains(@class, 'kt-button') and contains(., 'Apply to Our School')]"));

        public void ClickApplyButton(string buttonNumber)
        {
            try
            {
                switch (buttonNumber)
                {
                    case "ApplyButton1":
                        ApplyButton1.Click();
                        break;
                    case "ApplyButton2":
                        ApplyButton2.Click();
                        break;
                    case "ApplyButton3":
                        Actions actions = new Actions(_driver);
                        ApplyButton3.Click();
                        break;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(buttonNumber));
                }
            }
            catch (NoSuchElementException)
            {
                throw new NoSuchElementException(
                    $"Apply to MOHS button {buttonNumber} not found");
            }
        }
    }
}