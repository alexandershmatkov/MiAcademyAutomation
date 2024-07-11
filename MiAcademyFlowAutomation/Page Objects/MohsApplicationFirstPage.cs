using OpenQA.Selenium;

namespace MiAcademyFlowAutomation.Page_Objects
{
    public class MohsApplicationFirstPage
    {
        private readonly IWebDriver _driver;

        public MohsApplicationFirstPage(IWebDriver driver)
        {
            _driver = driver;
        }

        public IWebElement NextButton =>
            _driver.FindElement(
                By.XPath("//button[contains(@aria-label, 'Navigates to page 2 out of 4') and @elname='next']"));

        public void ClickNextButton()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)_driver;
            js.ExecuteScript("arguments[0].click();", NextButton);
        }
    }
}