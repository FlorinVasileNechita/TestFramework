using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
