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

        // Drag element from 'Available Services' and drop it to 'Enabled Services'
        public void DragAndDropFromAvailableToEnabled()
        {
            IWebElement sourceElement = Browser.FindElement(By.XPath("//table[@id='available-services']/tbody/tr/td[2]/ul/li[1]"));
            IWebElement targetElement = Browser.FindElement(By.XPath("//table[@id='enabled-services']/tbody/tr/td[2]/ul"));
            Browser.DragAndDrop(sourceElement, targetElement);
        }

        // Drag element from 'Enabled Services' and drop it to 'Available Services'
        public void DragAndDropFromEnabledToAvailable()
        {
            IWebElement sourceElement = Browser.FindElement(By.XPath("//table[@id='enabled-services']/tbody/tr/td[2]/ul/li[1]"));
            IWebElement targetElement = Browser.FindElement(By.XPath("//table[@id='available-services']/tbody/tr/td[2]/ul"));
            Browser.DragAndDrop(sourceElement, targetElement);
        }

        // Count the sharing options form the Enabled Services section
        public int EnabledServicesCount()
        {
           return Browser.FindElements(By.XPath("//table[@id='enabled-services']/tbody/tr/td[2]/ul/li")).Count;
        }
    }
}