using OpenQA.Selenium;

namespace MiAcademyFlowAutomation.Pages
{
    public class MohsApplicationFirstPage : BasePage
    {
        public MohsApplicationFirstPage(IWebDriver driver) : base(driver) { }

        public void ClickNextButton()
        {
            IWebElement nextButton = FindElement(By.XPath("//button[contains(@aria-label, 'Navigates to page 2 out of 4') and @elname='next']"));
            ClickElement(nextButton);
        }

    }
}