using OpenQA.Selenium;
using System;

namespace MiAcademyFlowAutomation.Pages
{
    public class OnlineHighSchoolPage : BasePage
    {
        public OnlineHighSchoolPage(IWebDriver driver) : base(driver)
        {
        }

        // Header button
        public IWebElement ApplyButton1 =>
            FindElement(By.XPath("//a[text()='Apply Now']"));

        // Button in a middle of the page
        public IWebElement ApplyButton2 =>
            FindElement(By.XPath(
                "//a[contains(@class, 'has-theme-palette-9-background-color') and contains(., 'Apply to Our School')]"));

        // Button from the bottom of the page
        public IWebElement ApplyButton3 =>
            FindElement(By.XPath("//a[contains(@class, 'kt-button') and contains(., 'Apply to Our School')]"));

        public void ClickApplyButton(string buttonNumber)
        {
            try
            {
                switch (buttonNumber)
                {
                    case "ApplyButton1":
                        ClickElement(ApplyButton1);
                        break;
                    case "ApplyButton2":
                        ClickElement(ApplyButton2);
                        break;
                    case "ApplyButton3":
                        ClickElement(ApplyButton3);
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