using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
//using OpenQA.Selenium.Interactions.Internal;
//using OpenQA.Selenium.Interactions.Internal;

namespace HW11_Selenium_XPath
{
    public class Actions : BasePage
    {
        public Actions(IWebDriver driver) : base(driver) { }

        public void MouseHover(IWebElement element)  //можно ли делать MouseHover?
        {
            //Actions action = new Actions(_driver);
        }

    }

}
