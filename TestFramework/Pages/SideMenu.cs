using System;
using OpenQA.Selenium;

namespace TestFramework.Pages
{
    public class SideMenu
    {
        public PostsPage ClickOnPosts()
        {
            Browser.FindElement(By.Id("menu-posts")).Click();
            return new PostsPage();
        }
    }
}