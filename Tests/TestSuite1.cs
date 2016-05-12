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
            LoginPage loginPage = new LoginPage();
            NUnit.Framework.Assert.IsTrue(loginPage.IsAt());
        }

        [Test]
        [TestMethod]
        public void Add_New_Post()
        {
            //variables used in the test
            string userName = "cosflaviu";
            string password = "test@1234";
            string postTitle = "Post1";
            string postDescription = "Description";

            // Initialize page objects
            CreateNewPostPage createNewPostPage = new CreateNewPostPage();
            LoginPage loginPage = new LoginPage();
            DashboardPage dashboardPage = loginPage.MakeLogin(userName , password);

            // Verify that the current page is the Dashboard page
            NUnit.Framework.Assert.IsTrue(dashboardPage.IsAt());

            AllPostsPage allPostsPage = dashboardPage.sideMenu.ClickOnPosts();

            // Verify that the current page is the All Posts Page page
            NUnit.Framework.Assert.IsTrue(allPostsPage.IsAt());

            allPostsPage.ClickOnAddNew();
            allPostsPage.sideMenu.ClickOnPosts();

            // Verify that the current page is the Create New Page page
            NUnit.Framework.Assert.IsTrue(createNewPostPage.IsAt());

            createNewPostPage.AddTitle(postTitle);
            createNewPostPage.AddDescription(postDescription);
            createNewPostPage.Publish();

            // Verify that 
            NUnit.Framework.Assert.IsTrue(createNewPostPage.IsPublishedSuccessfully());

            createNewPostPage.ViewPost();

            CreatedPostPage createdPostPage = new CreatedPostPage();

            // Verify that the post Title is correct
            NUnit.Framework.Assert.AreEqual(createdPostPage.CheckTitle(), (postTitle));

            // Verify that the post Description is correct
            NUnit.Framework.Assert.AreEqual(createdPostPage.CheckDescription(), (postDescription));
        }
        

        [TestCleanup]
        [TearDown]
        public void CleanUp()
        {
            Browser.Close();
        }
    }
}