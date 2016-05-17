﻿using OpenQA.Selenium;
using TestFramework.Base_Pages;

namespace TestFramework.Pages
{
    public class CreatedPostPage : CreatedBasePage
    {
        // Verify that the page is displayed
        private string PageTitle = "Posts ‹ cosflaviu — WordPress";
        public override bool IsAt()
        {
            return Browser.Title == PageTitle;
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