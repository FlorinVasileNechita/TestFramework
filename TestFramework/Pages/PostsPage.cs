using System;
using OpenQA.Selenium;

namespace TestFramework.Pages
{
    public class PostsPage : BasePage
    {

        private static string PageTitle = "Posts ‹ cosflaviu — WordPress";

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
