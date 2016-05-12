using System;
using System.Net;
using OpenQA.Selenium;

namespace TestFramework.Pages
{
    public class CreatedPostPage : BasePage
    {

        // Verify that the page is displayed
        private string PageTitle = "Posts ‹ cosflaviu — WordPress";
        public override bool IsAt()
        {
            return Browser.Title == PageTitle;
        }

        // Extract the Title from the post
        public string CheckTitle()
        {
            return Browser.FindElement(By.XPath("//header/h2/a")).Text;
           
        }
        // Extract the Description from the post
        public string CheckDescription()
        {
            return Browser.FindElement(By.XPath("//article/div[2]/p")).Text;
        }

    }
}