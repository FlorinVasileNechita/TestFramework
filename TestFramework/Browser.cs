using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace TestFramework
{
    public static class Browser
    {
       public static IWebDriver webDriver = new FirefoxDriver();

        public static string Title
        {
            get { return webDriver.Title; }
        }

        internal static void Goto(string url)
        {
            webDriver.Url = url;
           
        }

        public static void Close()
        {
            webDriver.Close();
        }

    }
}