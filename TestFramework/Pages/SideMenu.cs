using OpenQA.Selenium;

namespace TestFramework.Pages
{
    public class SideMenu
    {
        // Click on Posts button from the side menu
        public AllPostsPage ClickOnPosts()
        {
            Browser.FindElement(By.Id("menu-posts")).Click();
            return new AllPostsPage();
        }

        // Click on Pages button from the side menu
        public AllPagesPage ClickOnPages()
        {
            Browser.FindElement(By.Id("menu-pages")).Click();
            return new AllPagesPage();
        }
    }
}