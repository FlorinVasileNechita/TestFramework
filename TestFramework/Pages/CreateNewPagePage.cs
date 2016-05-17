using TestFramework.Base_Pages;

namespace TestFramework.Pages
{
     public class CreateNewPagePage : CreateNewBasePage
    {
        // Verify that the page is displayed
        private string PageTitle = "Add New Page ‹ cosflaviu — WordPress";
        public override bool IsAt()
        {
            return Browser.Title == PageTitle;
        }
    }
}