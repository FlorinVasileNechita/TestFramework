using System;

using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support;


namespace TestFramework
{
    public class LoginPage
    {
        private IWebDriver driver;
        
        public void TestInit()
        {
            driver = new FirefoxDriver();
            driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(5));
            driver.Navigate().GoToUrl("https://cosflaviu.wordpress.com/wp-admin/");

            // user: cosflaviu
            // pass: test@1234
        }

        public void TestCleanup()
        {
            driver.Quit();
        }

        public void SearchFor(string searchTerm)
        {
            IWebElement searchImput = driver.FindElement(By.Id("cli_shellHeaderSearchInput"));
            searchImput.SendKeys(searchTerm);
            searchImput.SendKeys(Keys.Enter);
        }

        public void FindGame(string gameName)
        {
            IWebElement findGame = driver.FindElement(By.PartialLinkText(gameName));
            findGame.Click();
        }

        public string GetPrice()
        {
            return driver.FindElement(By.ClassName("price")).Text;
        }
    }
}