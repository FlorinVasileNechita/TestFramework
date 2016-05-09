using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestFramework
{
   public static class Pages
    {
        public static class LoginPage
        {

            static string Url = "https://cosflaviu.wordpress.com/wp-admin/";
            private static string PageTitle = "cosflaviu < Log In";

            public static void Goto()
            {
                Browser.Goto(Url);
            }


            public static bool IsAt()
            {
               return Browser.Title == PageTitle;
            }
        }
    }
}
