using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace HW11_Selenium_XPath
{
    public abstract class BasePage
    {
        const int attemptsMaxNumber = 10;
        protected IWebDriver _driver;

        public BasePage(IWebDriver driver)
        {
            _driver = driver;
        }

        public IWebElement FindElementByXPath(string xPath)
        {
            IWebElement element = null;
            int attemptsNumber = 0;
            while (attemptsNumber < attemptsMaxNumber)
            {
                try
                {
                    element = _driver.FindElement(By.XPath(xPath));
                }
                catch (Exception ex)
                {
                    //_driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
                    Thread.Sleep(3000);
                    Console.WriteLine("Can't find element. I will try again.");
                    Console.WriteLine(ex.Message);
                }
                if (element != null)
                {
                    break;
                }
                attemptsNumber++;
            }
            return element;
        }

        public ReadOnlyCollection<IWebElement> FindElementSByXPath(string xPath)
        {
            ReadOnlyCollection<IWebElement> elements = null;
            int attemptsNumber = 0;
            while (attemptsNumber < attemptsMaxNumber)
            {
                try
                {
                    elements = _driver.FindElements(By.XPath(xPath));
                }

                catch (Exception ex)
                {
                    Thread.Sleep(3000);
                    Console.WriteLine("Can't find element. I will try again.");
                    Console.WriteLine(ex.Message);
                }

                if (elements.Count > 0)
                {
                    break;
                }

                attemptsNumber++;
            }
            return elements;
        }
    }
}
