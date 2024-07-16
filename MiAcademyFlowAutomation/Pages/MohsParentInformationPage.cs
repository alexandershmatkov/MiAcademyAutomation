using OpenQA.Selenium;
using System;

namespace MiAcademyFlowAutomation.Pages
{
    public class MohsParentInformationPage : BasePage
    {
        public MohsParentInformationPage(IWebDriver driver) : base(driver)
        {
        }

        private IWebElement FirstNameField => FindElement(By.XPath("//input[@elname='First']"));

        private IWebElement LastNameField => FindElement(By.XPath("//input[@elname='Last']"));

        private IWebElement EmailField => FindElement(By.XPath("//input[@name='Email']"));

        private IWebElement PhoneField => FindElement(By.XPath("//input[@id='PhoneNumber']"));

        private IWebElement SecondParentInfoDropDown =>
            FindElement(By.XPath("//span[@class='select2-selection select2-selection--single select2FormCont' and @role='combobox' and @aria-labelledby='select2-Dropdown-arialabel-container']"));

        private IWebElement SecondParentInfoOptionNo =>
            FindElement(By.XPath("//li[contains(@class, 'select2-results__option') and text()='No']"));

        private IWebElement PreferredStartDateField => FindElement(By.XPath("//input[@id='Date-date']"));

        private IWebElement NextButton =>
            FindElement(By.XPath("//button[contains(@aria-label, 'Navigates to page 3 out of 4') and @elname='next']"));


        public void FillOutParentForm(string firstName, string lastName, string email, string phone)
        {
            FirstNameField.SendKeys(firstName);
            LastNameField.SendKeys(lastName);
            EmailField.SendKeys(email);
            PhoneField.SendKeys(phone);

            SelectComboBox(SecondParentInfoDropDown);
            SelectComboBox(SecondParentInfoOptionNo);

            DateTime currentDate = DateTime.Today;
            DateTime nextTwoWeeks = currentDate.AddDays(14);
            string date = nextTwoWeeks.ToString("dd-MMM-yyyy");

            PreferredStartDateField.SendKeys(date);
        }

        public void ClickNextButton() => ClickElement(NextButton);
    }
}