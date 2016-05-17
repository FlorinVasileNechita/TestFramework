using System;

namespace TestFramework.Pages
{
    public class DashboardPage : BasePage
    {
        // Verify that the page is displayed
        private string PageTitle = "Dashboard ‹ cosflaviu — WordPress";
        public override bool IsAt()
        {
            return Browser.Title == PageTitle;
        }
    }
}