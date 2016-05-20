using OpenQA.Selenium;

namespace TestFramework.Base_Pages
{
    public abstract class CreatedBasePage : BasePage
    {
        public abstract string CheckDescription();
        public abstract string CheckTitle();
        public abstract string CheckPageTitle();


        // Count the Share options from the 'Share this:' list
        public int ShareElementsCount()
        {
            return Browser.FindElements(By.XPath("//div[@id='jp-post-flair']/div[1]/div/div/ul/li")).Count;
        }
    }
}
