using System;
using OpenQA.Selenium;

namespace TestFramework.Pages
{
    public class SideMenu
    {

        public AllPostsPage ClickOnPosts()
        {
            Browser.FindElement(By.Id("menu-posts")).Click();
            return new AllPostsPage();
        }
    }
}