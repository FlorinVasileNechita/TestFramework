using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;

namespace TestFramework
{
   public static class Pages
    {
        public static class LoginPage
        {

            static string Url = "https://cosflaviu.wordpress.com/wp-admin/";
            private static string PageTitle = "cosflaviu ‹ Log In";
           
            public static void Goto()
            {
                Browser.Goto(Url);
                Browser.webDriver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(5));
            }

            public static bool IsAt()
            {
               return Browser.Title == PageTitle;
            }

            public static void MakeLogin()
            {
                // user: cosflaviu
                // pass: test@1234
                string userName = "cosflaviu";
                string password = "test@1234";
                Browser.webDriver.FindElement(By.Id("user_login")).SendKeys(userName);
                Browser.webDriver.FindElement(By.Id("user_pass")).SendKeys(password);
                Browser.webDriver.FindElement(By.Id("wp-submit")).Click();
            }
        }

       public static class SideMenu
       {
           
       }
    }
}