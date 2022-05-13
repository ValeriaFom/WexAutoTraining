using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using HW11_Selenium_XPath;
using System.Threading;

namespace UnitTestsWithSelenium
{
    [TestClass]
    public class BycardUnitTests
    {
        WebDriver driver = null;

        [TestInitialize]
        public void Initialize()
        {
            driver = new ChromeDriver();
            driver.Url = "https://bycard.by/";

            driver.Manage().Window.Maximize();
        }

        [TestMethod]
        public void CheckLoginPopupAppearsAfterLoginButton()
        {
            HomePage homePage = new HomePage(driver);
            homePage.GoToLoginPage();

            LoginPage loginPage = new LoginPage(driver);
            Assert.IsTrue (loginPage.IsLoginPopupDisplayedWithElements());
        }

        [TestMethod]
        public void CheckLoginPopupCloses()
        {
            HomePage homePage = new HomePage(driver);
            homePage.GoToLoginPage();

            LoginPage loginPage = new LoginPage(driver);
            loginPage.CloseLoginPopup();

            Assert.IsTrue(homePage.IsHomePageOpened());
        }

        [TestMethod]
        public void CheckPopupWithCityAppears()
        {
            HomePage homePage = new HomePage(driver);

            Assert.IsTrue(homePage.IsPopupWithCityDisplayed());
        }


        [TestMethod]
        public void CheckPopupWithCityClosesAfterYesButton()
        {
            HomePage homePage = new HomePage(driver);
            homePage.ClosePopupWithCityViaYesButton();

            Thread.Sleep(4000);

            Assert.IsTrue(homePage.IsPopupWithCityClosed());
        }

        [TestMethod]
        public void CheckSchedulePageOpensAfterMenuScheduleButton()
        {
            HomePage homePage = new HomePage(driver);
            homePage.GoToShedulePage();

            SchedulePage schedulePage = new SchedulePage(driver);

            Assert.IsTrue(schedulePage.IsSchedulePageOpened());
        }

        [TestCleanup]
        public void CleanUp()
        {
            driver.Close();
        }

    }
}
