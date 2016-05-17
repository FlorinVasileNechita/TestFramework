using TestFramework.Base_Pages;

namespace TestFramework.Pages
{
    public class AllPostsPage : AllBasePage
    {
        // Verify that the page is displayed
        private string PageTitle = "Posts ‹ cosflaviu — WordPress";
        public override bool IsAt()
        {
            return Browser.Title == PageTitle;
        }
    }
}
