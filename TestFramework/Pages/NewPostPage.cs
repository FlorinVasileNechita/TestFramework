using System;

namespace TestFramework.Pages
{
    public class NewPostPage :BasePage
    {
        private static string PageTitle = "Add New Post ‹ cosflaviu — WordPress";

        public override bool IsAt()
        {
            return Browser.Title == PageTitle;
        }

        public static void AddTitle()
        {
            throw new NotImplementedException();
        }

        public static void AddDescription()
        {
            throw new NotImplementedException();
        }

        public static void Publish()
        {
            throw new NotImplementedException();
        }
    }
}