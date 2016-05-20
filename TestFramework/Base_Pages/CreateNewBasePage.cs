using OpenQA.Selenium;

namespace TestFramework.Base_Pages
{
    public abstract class CreateNewBasePage : BasePage
    {
        // Verify if the post/page is successfully created
        public bool IsPublishedSuccessfully()
        {
            if (Browser.FindElement(By.XPath("//div[@id='message']/p")) == null)
            {
                return false;
            }
            return true;
        }

        // Add a Title
        public void AddTitle(string titleName)
        {
            Browser.FindElement(By.Id("title")).SendKeys(titleName);
        }

        // Add a description
        public void AddDescription(string pageDescription)
        {
            Browser.SwitchToFrame(By.Id("content_ifr"));
            Browser.FindElement(By.Id("tinymce")).SendKeys(pageDescription);
            Browser.SwitchBack();
        }

        // Click on 'Publish' button
        public void ClickOnPublish()
        {
            Browser.FindElement(By.Id("publish")).Click();
        }

        // Click on View link
        public void ClickOnView()
        {
            Browser.FindElement(By.XPath("//div[@id='message']/p/a")).Click();
        }
    }
}