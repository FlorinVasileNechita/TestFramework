using System;
using System.Threading;
using OpenQA.Selenium;

namespace TestFramework.Pages
{
    public class ManageThemesPage : BasePage
    {
        // Verify that the page is displayed
        private string PageTitle = "Manage Themes ‹ cosflaviu — WordPress";
        public override bool IsAt()
        {
            return Browser.Title == PageTitle;
        }

        // Scroll down until 'Hemingway' theme is displayed
        public void ScrollDownToTheme()
        {
            do
            {
                Browser.ScrollDown();
            }
            while (!Browser.IsDisplayed(By.Id("pub/hemingway-action")));
        }

        // Hover over the 'Hemingway' theme
        public void Hover()
        {
            Browser.Hover(By.Id("pub/hemingway-action"));
        }

        // Click on the 'Preview'button
        public void ClickOnPreview()
        {
            Browser.FindElement(By.XPath("//div[@aria-describedby='pub/hemingway-action pub/hemingway-name']/div[3]/a[2]")).Click();
        }
    }
}
