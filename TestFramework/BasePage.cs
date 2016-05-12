using TestFramework.Pages;

namespace TestFramework
{
    public abstract class BasePage
    {
        public SideMenu sideMenu = new SideMenu();
        public abstract bool IsAt();
    }
}