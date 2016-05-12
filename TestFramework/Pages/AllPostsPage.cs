using System;
using OpenQA.Selenium;

namespace TestFramework.Pages
{
    public class AllPostsPage : BasePage
    {

        // Verify that the page is displayed
        private string PageTitle = "Posts ‹ cosflaviu — WordPress";
        public override bool IsAt()
        {
            return Browser.Title == PageTitle;
        }

        public void ClickOnAddNew()
        {
           Browser.FindElement(By.ClassName("page-title-action")).Click();
        }
    }
}
