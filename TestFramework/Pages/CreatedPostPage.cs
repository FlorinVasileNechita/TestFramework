using OpenQA.Selenium;
using TestFramework.Base_Pages;

namespace TestFramework.Pages
{
    public class CreatedPostPage : CreatedBasePage
    {
        // Verify that the page is displayed
        public override bool IsAt()
        {
            return true;
        }

        // Extract the page title
        public override string CheckPageTitle()
        {
            return Browser.Title;
        }

        // Extract the Title from the post
        public override string CheckTitle()
        {
            return Browser.FindElement(By.XPath("//header/h2/a")).Text;
        }

        // Extract the Description from the post
        public override string CheckDescription()
        {
            return Browser.FindElement(By.XPath("//article/div[2]/p")).Text;
        }
    }
}