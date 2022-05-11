using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


namespace HW11_Selenium_XPath
{
    public class LoginPage:BasePage
    {
        const string CLOSE_LOGIN_POPUP_XPATH = "//div[contains(@class,'popup') and contains(@class,'close')]";
        
        Dictionary<string, IWebElement> _dictionary;

        IWebElement _popupHeaderText;
        IWebElement _popupTelephoneInput;
        IWebElement _popupCheckboxInput;
        IWebElement _popupCheckboxText;
        IWebElement _popupNextButton;

        public LoginPage(IWebDriver driver): base(driver) 
        {
            _dictionary = new Dictionary<string, IWebElement>();

            var closeLoginPopupButton = FindElementByXPath(CLOSE_LOGIN_POPUP_XPATH);
            _dictionary.Add("Close Login popup button", closeLoginPopupButton);

            _popupHeaderText = FindElementByXPath("//div[contains(@class,'header') and " +
                                "contains(@class,'popup') and " +
                                "contains(text(),'Авторизация')]");
            _popupTelephoneInput = FindElementByXPath("//input[@name = 'telephone']");
            _popupCheckboxInput = FindElementByXPath("//input[@type = 'checkbox']");
            _popupCheckboxText = FindElementByXPath("//span[contains(text(),'принимаю условия')]");
            _popupNextButton = FindElementByXPath("//button[text()='Продолжить авторизацию']");
        }

        public bool IsLoginPopupDisplayedWithElements()
        {
            return _popupHeaderText != null &&
                _popupTelephoneInput != null &&
                _popupCheckboxInput != null &&
                _popupCheckboxText != null &&
                _popupNextButton != null;

            //popupElement5?.Count == 1;
        }
        public void CloseLoginPopup()
        {
            _dictionary["Close Login popup button"]?.Click();
        }
    }
}
