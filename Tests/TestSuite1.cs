using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using TestFramework;
using TestFramework.Pages;

namespace Tests
{
    [TestFixture]
    [TestClass]
    public class TestSuite1
    {
        [TestInitialize]
        [SetUp]
        public void SetUp()
        {
            string Url = "https://cosflaviu.wordpress.com/wp-admin/";
            Browser.Goto(Url);
            Browser.Wait();
            LoginPage LoginPage = new LoginPage();
            NUnit.Framework.Assert.IsTrue(LoginPage.IsAt());

        }

        [Test]
        [TestMethod]
        public void Add_New_Post()
        {
            NewPostPage NewPostPage = new NewPostPage();

            DashboardPage dashboardPage =LoginPage.MakeLogin();
            NUnit.Framework.Assert.IsTrue(dashboardPage.IsAt());
        
            PostsPage postsPage = dashboardPage.sideMenu.ClickOnPosts();
            NUnit.Framework.Assert.IsTrue(postsPage.IsAt());
            postsPage.ClickOnAddNew();
            postsPage.sideMenu.ClickOnPosts();
            NUnit.Framework.Assert.IsTrue(NewPostPage.IsAt());
            NewPostPage.AddTitle();
            NewPostPage.AddDescription();
            NewPostPage.Publish();
        }
        
        [TestCleanup]
        [TearDown]
        public void CleanUp()
        {
            Browser.Close();
        }
    }
}