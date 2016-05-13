using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using TestFramework;
using TestFramework.Pages;

namespace Tests
{
    [TestClass]
    [TestFixture]
    public class TestSuite1
    {
        [TestInitialize]
        [SetUp]
        public void SetUp()
        {
            string Url = "https://cosflaviu.wordpress.com/wp-admin/";
            Browser.InitBrowser();
            Browser.Goto(Url);
            Browser.Wait();  
            LoginPage loginPage = new LoginPage();
            NUnit.Framework.Assert.IsTrue(loginPage.IsAt());
        }


        [TestMethod]
        [Test]
        public void Add_New_Post()
        {
            //variables used in the test
            string userName = "cosflaviu";
            string password = "test@1234";
            string postTitle = "Post1";
            string postDescription = "Description";

            //1.Login with admin account;  
            CreateNewPostPage createNewPostPage = new CreateNewPostPage();
            LoginPage loginPage = new LoginPage();
            DashboardPage dashboardPage = loginPage.MakeLogin(userName , password);
            NUnit.Framework.Assert.IsTrue(dashboardPage.IsAt());

            //2.Click on Posts button from the side menu;
            AllPostsPage allPostsPage = dashboardPage.sideMenu.ClickOnPosts();
            NUnit.Framework.Assert.IsTrue(allPostsPage.IsAt());

            //3.Click on 'Add New' button;
            allPostsPage.ClickOnAddNew();
            NUnit.Framework.Assert.IsTrue(createNewPostPage.IsAt());

            //4.Give the post a title and a description and click on 'Publish' button;
            createNewPostPage.AddTitle(postTitle);
            createNewPostPage.AddDescription(postDescription);
            createNewPostPage.Publish(); 
            NUnit.Framework.Assert.IsTrue(createNewPostPage.IsPublishedSuccessfully());

            //5.Click on the 'View post' link;
            createNewPostPage.ViewPost();

            //6.Verify if the title and the description are correct.
            CreatedPostPage createdPostPage = new CreatedPostPage();       
            NUnit.Framework.Assert.AreEqual(createdPostPage.CheckTitle(), (postTitle));
            NUnit.Framework.Assert.AreEqual(createdPostPage.CheckDescription(), (postDescription));
        }

        [TestMethod]
        [Test]
        public void Edit_Existing_Post()
        {
            //variables used in the test
            string userName = "cosflaviu";
            string password = "test@1234";
            string postTitle = "Post1";
            string postDescription = "Description";
            string updateDescription = " Updated";

            //1.Login with admin account;  
            CreateNewPostPage createNewPostPage = new CreateNewPostPage();
            LoginPage loginPage = new LoginPage();
            DashboardPage dashboardPage = loginPage.MakeLogin(userName, password);
            NUnit.Framework.Assert.IsTrue(dashboardPage.IsAt());

            //2.Click on Posts button from the side menu;
            AllPostsPage allPostsPage = dashboardPage.sideMenu.ClickOnPosts();
            NUnit.Framework.Assert.IsTrue(allPostsPage.IsAt());

            //3.Hover over Post title and click on 'Edit' option;
            allPostsPage.HoverOverPost();
            allPostsPage.ClickOnEditPost();

            //4.Edit the description;
            createNewPostPage.AddDescription(updateDescription);

            //5.Click on the 'Update' button;
            createNewPostPage.Publish();
            
            //6.Click on the 'View post' link;
            createNewPostPage.ViewPost();

            //7.Verify if the updated description is displayed.
            CreatedPostPage createdPostPage = new CreatedPostPage();
            NUnit.Framework.Assert.AreEqual(createdPostPage.CheckTitle(), (postTitle));
            NUnit.Framework.Assert.AreEqual(createdPostPage.CheckDescription(), postDescription + updateDescription);

        }

        [TestMethod]
        [Test]
        public void Delete_Existing_Post()
        {
            //variables used in the test
            string userName = "cosflaviu";
            string password = "test@1234";
            string postTitle = "Post1";
            string postDescription = "Description";
            string updateDescription = " Updated";

            //1. Login with admin account;  
            CreateNewPostPage createNewPostPage = new CreateNewPostPage();
            LoginPage loginPage = new LoginPage();
            DashboardPage dashboardPage = loginPage.MakeLogin(userName, password);
            NUnit.Framework.Assert.IsTrue(dashboardPage.IsAt());

            //2. Click on Posts button from the side menu;
            AllPostsPage allPostsPage = dashboardPage.sideMenu.ClickOnPosts();
            NUnit.Framework.Assert.IsTrue(allPostsPage.IsAt());

            //3. Hover over Post title and click on 'Trash' option;
            allPostsPage.HoverOverPost();
            allPostsPage.ClickOnTrashPost();

            //4. Verify that '1 post moved to Trash.' message is displayed.
            NUnit.Framework.Assert.IsTrue(createNewPostPage.IsTrashedSuccessfully());

        }


        [TestCleanup]
        [TearDown]
        public void CleanUp()
        {
            Browser.Close();
        }
    }
}