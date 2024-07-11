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

        public void ClickMiaPrepLink()
        {
            Driver.Navigate().Refresh();
            IWebElement miaPrepLink = FindElement(By.LinkText("Online High School"));
            ClickElement(miaPrepLink);
        }
    }
}