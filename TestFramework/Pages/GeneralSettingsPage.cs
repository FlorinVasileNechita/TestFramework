
namespace TestFramework.Pages
{
    public class GeneralSettingsPage : BasePage
    {
        // Verify that the page is displayed
        private string PageTitle = "General Settings ‹ cosflaviu — WordPress";
        public override bool IsAt()
        {
            return Browser.Title == PageTitle;
        }
    }
}
