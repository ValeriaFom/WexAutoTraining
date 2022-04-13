using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


namespace HW11_Selenium_XPath
{
    class Program
    {
        static void Main(string[] args)
        {
            WebDriver driver = new ChromeDriver();
            driver.Url = "https://onliner.by";
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

            IWebElement loginButton = driver.FindElement(By.XPath("//div[contains (text(), 'Вход')]"));
            loginButton.Click();

            IWebElement nick = driver.FindElement(By.XPath("//input[@type = 'text'][@placeholder = 'Ник или e-mail']"));
            nick.Click();
            nick.SendKeys("12345");

            IWebElement password = driver.FindElement(By.XPath("//input[@type = 'password'][@placeholder = 'Пароль']"));
            password.Click();
            password.SendKeys("qwerty");
            
            IWebElement submit = driver.FindElement(By.XPath("//button[@type = 'submit'][not(text() = 'Найти')]"));
            submit.Click();

            IWebElement validation = driver.FindElement(By.XPath("//div[contains (text(), 'Неверный логин или пароль')]"));
            
            driver.Close();

            //IWebElement nick = driver.FindElement(By.XPath("//input[@type = 'text'] | //input[@placeholder = 'Ник или e-mail']")); // ИЛИ
            //IWebElement nick = driver.FindElement(By.XPath("//input[@type = 'text'][@placeholder = 'Ник или e-mail']")); // И
        }
    }
}
