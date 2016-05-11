using System;
using System.CodeDom;
using System.Reflection;
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
            webDriver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(5)); 
        }

        //FindElement method
        public static IWebElement FindElement(By by)
        {
            return webDriver.FindElement(by);
        }
        
        //Close Firefox driver
        public static void Close()
        {
            webDriver.Close();
        }
    }
}