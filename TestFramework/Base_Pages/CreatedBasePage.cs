using OpenQA.Selenium;

namespace TestFramework.Base_Pages
{
    public abstract class CreatedBasePage : BasePage
    {
        public abstract string CheckDescription();
        public abstract string CheckTitle();
    }
}
