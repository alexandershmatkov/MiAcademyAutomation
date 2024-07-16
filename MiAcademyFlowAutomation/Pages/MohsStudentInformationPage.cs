using OpenQA.Selenium;
using SeleniumExtras.WaitHelpers;

namespace MiAcademyFlowAutomation.Pages
{
    public class MohsStudentInformationPage : BasePage
    {
        public MohsStudentInformationPage(IWebDriver driver) : base(driver)
        {
        }

        private IWebElement GetStudentPageHeader()
        {
            return Wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(
                "//li[@id='Section3-li']//h2[contains(@class, 'advLabelName')]/div/b[text()='Student Information']")));
        }

        // Check that Student Information Header is presented on the Student info page
        public bool IsStudentPageHeaderVisible()
        {
            try
            {
                IWebElement studentPageHeader = GetStudentPageHeader();
                return studentPageHeader.Displayed;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
            catch (WebDriverTimeoutException)
            {
                return false;
            }
        }
    }
}