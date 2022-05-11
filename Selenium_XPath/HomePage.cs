using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions.Internal;
//import org.OpenQA.Selenium.Interactions.Actions;

namespace HW11_Selenium_XPath
{
    public class HomePage:BasePage
    {
        const string loginButtonXpath = "//section[1]/div[contains(@class,'navigation_right')]/..//span[contains(text(),'Войти')]";
        const string logoXpath = "//section[1]/div[contains(@class,'navigation_left')]/..//img";
        const string menuScheduleXpath = "//section[1]/div[contains(@class,'navigation_left')]/..//a[contains(text(),'Расписание')]";

        IWebElement _loginButton; //нужен ли = null?
        IWebElement _logo;
        IWebElement _menuSchedule;
        public IWebElement _menuPlaces;
        IWebElement _textOnPopupWithCity;
        IWebElement _yesButtonOnPopupWithCity;
        IWebElement _noButtonOnPopupWithCity;

        public HomePage(IWebDriver driver) : base(driver) 
        {
            _loginButton = FindElementByXPath(loginButtonXpath);
            _logo = FindElementByXPath(logoXpath);
            _menuSchedule = FindElementByXPath(menuScheduleXpath);
            _menuPlaces = FindElementByXPath("//section[1]/div[contains(@class,'navigation_left')]/..//a[contains(text(),'Места')]");
            _textOnPopupWithCity = FindElementByXPath("//section[1]/div[contains(@class,'navigation_right')]/..//div[contains(@class,'location tooltip')]/..//div[contains(@class,'message') and contains(.,'Ваш город')]");
            _yesButtonOnPopupWithCity = FindElementByXPath("//section[1]/div[contains(@class,'navigation_right')]/..//div[contains(@class,'location tooltip')]/..//div[contains(@class,'tooltip__on') and contains(.,'Да')]");
            _noButtonOnPopupWithCity = FindElementByXPath("//section[1]/div[contains(@class,'navigation_right')]/..//div[contains(@class,'location tooltip')]/..//div[contains(@class,'tooltip__off') and contains(.,'Нет')]");
        }

        public bool IsHomePageOpened()
        {
            return _logo != null && 
                _menuSchedule != null && 
                _loginButton != null;
        }

        public void GoToLoginPage()
        {
            _loginButton?.Click();
        }
        public void GoToShedulePage()
        {
            _menuSchedule?.Click();
        }

        public bool IsPopupWithCityDisplayed()
        {
            return _textOnPopupWithCity != null &&
                _yesButtonOnPopupWithCity != null &&
                _noButtonOnPopupWithCity != null;
        }

        public void ClosePopupWithCityViaYesButton()
        {
            _yesButtonOnPopupWithCity?.Click();
        }

        public bool IsPopupWithCityClosed() //??? нужна коллекция
        {
            return _textOnPopupWithCity == null;
            //return _textOnPopupWithCity.Displayed == false;
            //return _textOnPopupWithCity.Size == 0; 
        }

        public void MouseHoverMenuPlacesButton()
        {
            Actions action = new Actions(_driver);
            action.MouseHover(_menuPlaces);

            //Action build = action.build();
            //build.perform();
        }


    }
}
