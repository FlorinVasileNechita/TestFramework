﻿using TestFramework.Base_Pages;

namespace TestFramework.Pages
{
    public class CreateNewPostPage : CreateNewBasePage
    {
        // Verify that the page is displayed
        private string PageTitle = "Add New Post ‹ cosflaviu — WordPress";
        public override bool IsAt()
        {
            return Browser.Title == PageTitle;
        }
    }
}