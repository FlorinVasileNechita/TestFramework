using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Interactions;

namespace TestFramework
{
    public static class Browser
    {
        // Initiate Firefox driver
        public static IWebDriver webDriver;
        public static void InitBrowser()
        {
            FirefoxBinary firefoxBinary = new FirefoxBinary("C:\\Program Files (x86)\\Mozilla Firefox\\firefox.exe");  
            FirefoxProfile firefoxProfile = new FirefoxProfile();
            webDriver = new FirefoxDriver(firefoxBinary, firefoxProfile);
        }

        // Get the Page title
        public static string Title
        {
            get { return webDriver.Title; }
        }

        // Go to URL
        public static void Goto(string url)
        {
            webDriver.Navigate().GoToUrl(url);
        }

        // Wait the page to load
        public static void Wait()
        {
            webDriver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10)); 
        }

        // FindElement method
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

        // Mouse over
        public static void Hover(By by)
        {
            Actions action = new Actions(webDriver);
            action.MoveToElement(FindElement(by)).Perform();
        }

        // Close Firefox driver
        public static void Close()
        {
            webDriver.Close();
        }
    }
}