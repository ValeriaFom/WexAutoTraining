using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace HW11_Selenium_XPath
{
    public class SchedulePage: BasePage
    {
        IWebElement _titleText = null;

        public SchedulePage(IWebDriver driver) : base(driver)
        {
            _titleText = FindElementByXPath("//span[contains(@class,'head') and contains(.,'Афиша сегодня')]");
        }

        public bool IsSchedulePageOpened()
        {
            return _titleText != null;
        }
    }
}
