using OpenQA.Selenium;
using TestFramework.Base_Pages;

namespace TestFramework.Pages
{
    public class CreatedPagePage : CreatedBasePage
    {
        // Verify that the page is displayed
        private string PageTitle = "Pages ‹ cosflaviu — WordPress";
        public override bool IsAt()
        {
            return Browser.Title == PageTitle;
        }

        // Extract the Title from the page
        public override string CheckTitle()
        {
            return Browser.FindElement(By.XPath("//main/article/header/h1")).Text;
        }

        // Extract the Description from the post
        public override string CheckDescription()
        {
            return Browser.FindElement(By.XPath("//article/div/p")).Text;
        }
    }
}