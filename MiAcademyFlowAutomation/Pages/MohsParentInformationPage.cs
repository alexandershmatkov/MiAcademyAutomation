using OpenQA.Selenium;
using System;

namespace MiAcademyFlowAutomation.Pages
{
    public class MohsParentInformationPage : BasePage
    {
        public MohsParentInformationPage(IWebDriver driver) : base(driver)
        {
        }

        public IWebElement FirstNameField => FindElement(By.XPath("//input[@elname='First']"));

        public IWebElement LastNameField => FindElement(By.XPath("//input[@elname='Last']"));

        public IWebElement EmailField => FindElement(By.XPath("//input[@name='Email']"));

        public IWebElement PhoneField => FindElement(By.XPath("//input[@id='PhoneNumber']"));

        public IWebElement SecondParentInfoDropDown =>
            FindElement(By.XPath("//span[@class='select2-selection select2-selection--single select2FormCont' and @role='combobox' and @aria-labelledby='select2-Dropdown-arialabel-container']"));

        public IWebElement SecondParentInfoOptionNo =>
            FindElement(By.XPath("//li[contains(@class, 'select2-results__option') and text()='No']"));

        public IWebElement PreferredStartDateField => FindElement(By.XPath("//input[@id='Date-date']"));


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

        public void ClickNextButton()
        {
            IWebElement nextButton =
                FindElement(
                    By.XPath("//button[contains(@aria-label, 'Navigates to page 3 out of 4') and @elname='next']"));
            ClickElement(nextButton);
        }

    }
}