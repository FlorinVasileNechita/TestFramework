using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace TestFramework
{
    public static class Browser
    {
        // Initiate Firefox driver
        public static IWebDriver webDriver = new FirefoxDriver();

        //Get the Page title
        public static string Title
        {
            get { return webDriver.Title; }
        }

        // Go to URL
        public static void Goto(string url)
        {
            webDriver.Url = url;
        }

        //Wait the page to load
        public static void Wait()
        {
            webDriver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10)); 
        }

        //FindElement method
        public static IWebElement FindElement(By by)
        {

            return webDriver.FindElement(by);
        }

        // Switch to iframe
        public static void SwitchToFrame(By by)
        {
           webDriver.SwitchTo().Frame(webDriver.FindElement(by));
        }

        // Exit iframe 
        public static void SwitchBack()
        {
            webDriver.SwitchTo().DefaultContent();
        }

        //Close Firefox driver
        public static void Close()
        {
            webDriver.Close();
        }
    }
}