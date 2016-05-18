using OpenQA.Selenium;

namespace TestFramework.Base_Pages
{
    public abstract class AllBasePage : BasePage
    {
        // Click on Add New button
        public void ClickOnAddNew()
        {
            Browser.FindElement(By.ClassName("page-title-action")).Click();
        }

        // Hover over the first item
        public void Hover()
        {
            Browser.Hover(By.XPath("//table/tbody/tr[1]"));
        }

        // Click on the Edit link
        public void ClickOnEdit()
        {
            Browser.FindElement(By.XPath("//tbody[@id='the-list']/tr[1]/td[1]/div[3]/span[1]/a")).Click();
        }

        // Click on Trash link
        public void ClickOnTrash()
        {
            Browser.FindElement(By.XPath("//tbody[@id='the-list']/tr[1]/td[1]/div[3]/span[3]/a")).Click();
        }
    }
}

