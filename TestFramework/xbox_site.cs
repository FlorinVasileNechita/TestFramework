using System;
using System.Security.Cryptography.X509Certificates;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support;


namespace TestFramework
{
    public class xbox_site
    {
        private static IWebDriver driver = new FirefoxDriver();

        public static void TestInit()
        {
            driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(5));
            driver.Navigate().GoToUrl("http://www.xbox.com");
        }

        public static void SearchFor(string searchTerm)
        {
            IWebElement searchImput = driver.FindElement(By.Id("cli_shellHeaderSearchInput"));
            searchImput.SendKeys(searchTerm);
            searchImput.SendKeys(Keys.Enter);
        }

        public static void FindGame(string gameName)
        {
            IWebElement findGame = driver.FindElement(By.PartialLinkText(gameName));
            findGame.Click();
        }

        public static string GetPrice()
        {
            return driver.FindElement(By.ClassName("price")).Text;
        }
    }
}