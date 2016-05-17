using TestFramework.Base_Pages;

namespace TestFramework.Pages
{
    public class AllPagesPage : AllBasePage
    {
        // Verify that the page is displayed
        private string PageTitle = "Pages ‹ cosflaviu — WordPress";
        public override bool IsAt()
        {
            return Browser.Title == PageTitle;
        }
    }
}