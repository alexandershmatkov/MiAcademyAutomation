using OpenQA.Selenium;
using System.Configuration;

namespace MiAcademyFlowAutomation.Pages
{
    public class HomePage : BasePage
    {

        public HomePage(IWebDriver driver) : base(driver)
        {
        }

        public void NavigateToHomePage() => NavigateToUrl(ConfigurationManager.AppSettings["HomePageUrl"]);
        private IWebElement MiaPrepLink => FindElement(By.XPath("//a[text()='Online High School']"));

        public void ClickMiaPrepLink()
        {
            //Refresh the page first to avoid issues with browser tips
            Driver.Navigate().Refresh();
            ClickElement(MiaPrepLink);
        }
    }
}
