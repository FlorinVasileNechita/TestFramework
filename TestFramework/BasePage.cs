using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestFramework.Pages;

namespace TestFramework
{
    public abstract class BasePage
    {
        public SideMenu sideMenu = new SideMenu();
        public abstract bool IsAt();
    }
}