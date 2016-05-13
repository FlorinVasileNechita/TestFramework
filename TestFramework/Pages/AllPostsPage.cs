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

        public void HoverOverPost()
        {
           Browser.Hover(By.XPath("//table/tbody/tr[1]"));
        }

        public void ClickOnEditPost()
        {
            Browser.FindElement(By.XPath("//table/tbody/tr[1]/td[1]/div[3]/span[1]/a")).Click();
        }

        public void ClickOnTrashPost()
        {
            Browser.FindElement(By.XPath("//table/tbody/tr[1]/td[1]/div[3]/span[3]/a")).Click();
        }
    }
}
