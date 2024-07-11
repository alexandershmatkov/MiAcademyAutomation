using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;

namespace MiAcademyFlowAutomation.Page_Objects
{
    public class MohsStudentInformationPage
    {
        private readonly IWebDriver _driver;

        public MohsStudentInformationPage(IWebDriver driver)
        {
            _driver = driver;
        }

        public bool IsItStudentPage()
        {
            try
            {
                WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));
                wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(
                    "//li[@id='Section3-li']//h2[contains(@class, 'advLabelName')]/div/b[text()='Student Information']")));
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }
    }
}