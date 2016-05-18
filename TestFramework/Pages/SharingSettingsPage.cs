using OpenQA.Selenium;

namespace TestFramework.Pages
{
    public class SharingSettingsPage : BasePage
    {
        // Verify that the page is displayed
        private string PageTitle = "Sharing Settings ‹ cosflaviu — WordPress";
        public override bool IsAt()
        {
            return Browser.Title == PageTitle;
        }

        public void DragAndDrop()
        {
            IWebElement sourceElement = Browser.FindElement(By.XPath("/html/body/div[2]/div[2]/div[3]/div[1]/div[3]/div[2]/div[1]/table[1]/tbody/tr/td[2]/ul/li[1]"));
            IWebElement targetElement = Browser.FindElement(By.XPath("/html/body/div[2]/div[2]/div[3]/div[1]/div[3]/div[2]/div[1]/table[2]/tbody/tr/td[2]/ul"));
            Browser.DragAndDrop(sourceElement, targetElement);
        }

        public void DragAndDropNative()
        {
            //IWebElement sourceElement = Browser.FindElement(By.XPath("/html/body/div[2]/div[2]/div[3]/div[1]/div[3]/div[2]/div[1]/table[1]/tbody/tr/td[2]/ul/li[1]"));
            //IWebElement targetElement = Browser.FindElement(By.XPath("/html/body/div[2]/div[2]/div[3]/div[1]/div[3]/div[2]/div[1]/table[2]/tbody/tr/td[2]/ul"));
            IWebElement sourceElement = Browser.FindElement(By.Id("tumblr"));
            IWebElement targetElement = Browser.FindElement(By.Id("share-drop-target"));
            Browser.DragAndDropNative(sourceElement, targetElement);
        }

    }
}
