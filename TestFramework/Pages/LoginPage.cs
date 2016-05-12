using System;
using OpenQA.Selenium;

namespace TestFramework.Pages
{
    public  class LoginPage: BasePage
    {
        // Verify that the page is displayed
        private string PageTitle = "cosflaviu ‹ Log In";
        public override bool IsAt()
        {
            return Browser.Title == PageTitle;
        }

        // Login Method
        public DashboardPage MakeLogin(string userName, string password)
        {
            Browser.FindElement(By.Id("user_login")).SendKeys(userName);
            Browser.FindElement(By.Id("user_pass")).SendKeys(password);
            Browser.FindElement(By.Id("wp-submit")).Click();
            return new DashboardPage();
        }
    }
}