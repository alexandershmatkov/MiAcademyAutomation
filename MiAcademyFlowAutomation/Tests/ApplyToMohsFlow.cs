using MiAcademyFlowAutomation.Pages;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using OpenQA.Selenium;

namespace MiAcademyFlowAutomation.Tests
{
    [TestFixture]
    public class ApplyToMohsFlow
    {
        private IWebDriver _driver;
        private HomePage _homePage;
        private MohsApplicationFirstPage _mohsApplicationFirstPage;
        private OnlineHighSchoolPage _onlineHighSchoolPage;
        private MohsParentInformationPage _mohsParentInformationPage;
        private MohsStudentInformationPage _mohsStudentInformationPage;

        [SetUp]
        public void Setup()
        {
            _driver = WebDriverSetup.InitializeWebDriver();
            _homePage = new HomePage(_driver);
            _onlineHighSchoolPage = new OnlineHighSchoolPage(_driver);
            _mohsApplicationFirstPage = new MohsApplicationFirstPage(_driver);
            _mohsParentInformationPage = new MohsParentInformationPage(_driver);
            _mohsStudentInformationPage = new MohsStudentInformationPage(_driver);
        }

        [TearDown]
        public void TearDown()
        {
            _driver.Quit();
        }

        [Test]
        [TestCase("ApplyButton1")]
        [TestCase("ApplyButton2")]
        [TestCase("ApplyButton3")]
        public void UserShouldBeAbleToNavigateToStudentInformationPage(string applyButton)
        {
            _homePage.NavigateToHomePage();
            _homePage.ClickMiaPrepLink();
            _onlineHighSchoolPage.ClickApplyButton(applyButton);
            _mohsApplicationFirstPage.ClickNextButton();
            _mohsParentInformationPage.FillOutParentForm("John", "Doe", "John.Doe@example.com", "1234567890");
            _mohsParentInformationPage.ClickNextButton();
            
            ClassicAssert.IsTrue(_mohsStudentInformationPage.IsStudentPageHeaderVisible(), "Test did not reach Student Information Page");
        }
    }
}