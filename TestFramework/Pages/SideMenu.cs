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

        // Click on Settings button from the side menu
        public GeneralSettingsPage ClickOnSettings()
        {
            Browser.FindElement(By.Id("menu-settings")).Click();
            return new GeneralSettingsPage();
        }

        // Click on Sharing button from the Settings submenu
        public SharingSettingsPage ClickOnSharing()
        {
            Browser.FindElement(By.XPath("//li[@id='menu-settings']/ul/li[7]/a")).Click();
            return new SharingSettingsPage();
        }
    }
}