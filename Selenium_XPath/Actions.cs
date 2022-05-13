using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions.Internal;
//using OpenQA.Selenium.Interactions.Actions;
//import org.OpenQA.Selenium.Interactions.Actions;

namespace HW11_Selenium_XPath
{
    public class Actions : BasePage
    {
        public Actions(IWebDriver driver) : base(driver) { }

        public void MouseHover(IWebElement element)  //как сделать MouseHover? -> во 2ой части тренинга
        {
            //Actions action = new Actions(_driver);
        }
    }
}
