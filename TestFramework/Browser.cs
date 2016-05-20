using System;
using System.Collections.Generic;
using System.Linq;
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
            firefoxProfile.EnableNativeEvents = true;
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
            webDriver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(5)); 
        }

        // FindElement method
        public static IWebElement FindElement(By by)
        {
            return webDriver.FindElement(by);
        }

        // FindElements method
        public static List<IWebElement> FindElements(By locator)
        {
            return webDriver.FindElements(locator).ToList();
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

        // Drag and drop
        public static void DragAndDrop(IWebElement elementToDrag, IWebElement placeToDrop)
        {
            Actions action = new Actions(webDriver);
            action.ClickAndHold(elementToDrag).Build().Perform();
            System.Threading.Thread.Sleep(100);
            action.MoveToElement(placeToDrop).Build().Perform();
            System.Threading.Thread.Sleep(100);
            action.Release(placeToDrop).Build().Perform();
            System.Threading.Thread.Sleep(100);
        }

        // Navigate back
        public static void NavigateBack()
        {
            webDriver.Navigate().Back();
        }

        // Close Firefox driver
        public static void Close()
        {
            webDriver.Close();
        }
    }
}