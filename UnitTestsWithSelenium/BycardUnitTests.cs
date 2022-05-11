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
        [TestMethod]
        public void CheckLoginPopupAppearsAfterLoginButton()
        {
            WebDriver driver = new ChromeDriver();
            driver.Url = "https://bycard.by/";

            driver.Manage().Window.Maximize();

            HomePage homePage = new HomePage(driver);
            homePage.GoToLoginPage();

            LoginPage loginPage = new LoginPage(driver);
            Assert.IsTrue (loginPage.IsLoginPopupDisplayedWithElements());

            driver.Close();
        }

        [TestMethod]
        public void CheckLoginPopupCloses()
        {
            WebDriver driver = new ChromeDriver();
            driver.Url = "https://bycard.by/";

            driver.Manage().Window.Maximize();

            HomePage homePage = new HomePage(driver);
            homePage.GoToLoginPage();

            LoginPage loginPage = new LoginPage(driver);
            loginPage.CloseLoginPopup();

            Assert.IsTrue(homePage.IsHomePageOpened());

            driver.Close();
        }

        [TestMethod]
        public void CheckPopupWithCityAppears()
        {
            WebDriver driver = new ChromeDriver();
            driver.Url = "https://bycard.by/";

            driver.Manage().Window.Maximize();

            Thread.Sleep(4000); //4 sec

            HomePage homePage = new HomePage(driver);

            Assert.IsTrue(homePage.IsPopupWithCityDisplayed());

            driver.Close();
        }


        [TestMethod]
        public void CheckPopupWithCityClosesAfterYesButton()
        {
            WebDriver driver = new ChromeDriver();
            driver.Url = "https://bycard.by/";

            driver.Manage().Window.Maximize();

            Thread.Sleep(4000); //4 sec

            HomePage homePage = new HomePage(driver);
            homePage.ClosePopupWithCityViaYesButton();

            Thread.Sleep(10000);

            Assert.IsTrue(homePage.IsPopupWithCityClosed()); //почему Fail??

            driver.Close();
        }

        //[TestMethod]
        public void CheckPlacesDDLAppearsWithElementsAfterMouseover()
        {
            WebDriver driver = new ChromeDriver();
            driver.Url = "https://bycard.by/";

            driver.Manage().Window.Maximize();

            HomePage homePage = new HomePage(driver);
            Actions action = new Actions(driver);

            //action.MouseHover(homePage._menuPlaces); // как сделать доступными кнопки из других классов?

            driver.Close();
        }

        [TestMethod]
        public void CheckSchedulePageOpensAfterMenuScheduleButton()
        {
            WebDriver driver = new ChromeDriver();
            driver.Url = "https://bycard.by/";

            driver.Manage().Window.Maximize();

            HomePage homePage = new HomePage(driver);
            homePage.GoToShedulePage();

            SchedulePage schedulePage = new SchedulePage(driver);

            Assert.IsTrue(schedulePage.IsSchedulePageOpened());

            driver.Close();
        }
    }
}
