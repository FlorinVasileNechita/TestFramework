using System;
using OpenQA.Selenium;

namespace TestFramework.Pages
{
    public class CreateNewPostPage :BasePage
    {

        // Verify that the page is displayed
        private string PageTitle = "Add New Post ‹ cosflaviu — WordPress";
        public override bool IsAt()
        {
            return Browser.Title == PageTitle;
        }

        // Verify if the post is successfully created
        public bool IsPublishedSuccessfully()
        {
                if (Browser.FindElement(By.XPath("//div[@id='message']/p"))== null)
                {
                    return false;
                }
                return true;
        }

        // Verify if the post is successfully created
        public bool IsTrashedSuccessfully()
        {
            if (Browser.FindElement(By.XPath("//div[@id='message']/p")) == null)
            {
                return false;
            }
            return true;
        }

        // Add a Title to the post
        public void AddTitle(string titleName)
        {
   
            Browser.FindElement(By.Id("title")).SendKeys(titleName);
        }

        // Add a description to the post
        public void AddDescription(string pageDescription)
        {
          
            Browser.SwitchToFrame(By.Id("content_ifr"));
            Browser.FindElement(By.Id("tinymce")).SendKeys(pageDescription);
            Browser.SwitchBack();

        }

        // Click on 'Publish' button
        public void Publish()
        {
            Browser.FindElement(By.Id("publish")).Click();
        }

        // Click on View Post' link
        public void ViewPost()
        {
            Browser.FindElement(By.XPath("//div[@id='message']/p/a")).Click();
        }
    }
}