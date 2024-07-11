using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;

namespace MiAcademyFlowAutomation.Page_Objects
{
    public class MohsParentInformationPage
    {
        private readonly IWebDriver _driver;

        public MohsParentInformationPage(IWebDriver driver)
        {
            _driver = driver;
        }

        public IWebElement FirstNameField => _driver.FindElement(By.XPath("//input[@elname='First']"));
        public IWebElement LastNameField => _driver.FindElement(By.XPath("//input[@elname='Last']"));
        public IWebElement EmailField => _driver.FindElement(By.XPath("//input[@name='Email']"));
        public IWebElement PhoneField => _driver.FindElement(By.XPath("//input[@id='PhoneNumber']"));
        public IWebElement SecondParentInfoDropDown => _driver.FindElement(By.XPath("//span[@class='select2-selection select2-selection--single select2FormCont']"));
        public IWebElement SecondParentInfoOptionNo => _driver.FindElement(By.XPath("//li[contains(@class, 'select2-results__option') and text()='No']"));
        public IWebElement PreferredStartDateField => _driver.FindElement(By.XPath("//input[@id='Date-date']"));
        public IWebElement NextButton => _driver.FindElement(By.XPath("//button[contains(@aria-label, 'Navigates to page 3 out of 4') and @elname='next']"));

        public void FillOutParentForm(string firstName, string lastName, string email, string phone)
        {
            FirstNameField.SendKeys(firstName);
            LastNameField.SendKeys(lastName);
            EmailField.SendKeys(email);
            PhoneField.SendKeys(phone);

            Actions actions = new Actions(_driver);
            actions.MoveToElement(SecondParentInfoDropDown).Click().Perform();
            actions.MoveToElement(SecondParentInfoOptionNo).Click().Perform();

            DateTime currentDate = DateTime.Today;
            DateTime nextTwoWeeks = currentDate.AddDays(14);
            string date = nextTwoWeeks.ToString("dd-MMM-yyyy");

            PreferredStartDateField.SendKeys(date);
        }

        public void ClickNextButton()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)_driver;
            js.ExecuteScript("arguments[0].click();", NextButton);
        }
    }
}