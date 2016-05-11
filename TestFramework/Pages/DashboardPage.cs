using System;

namespace TestFramework.Pages
{
    public class DashboardPage : BasePage
    {
        private static string PageTitle = "Dashboard ‹ cosflaviu — WordPress";

        public override bool IsAt()
        {
            return Browser.Title == PageTitle;
        }


    }
}
