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
            DashboardPage dashboardPage = loginPage.MakeLogin(userName, password);
            NUnit.Framework.Assert.IsTrue(dashboardPage.IsAt());

            //2.Click on Posts button from the side menu;
            AllPostsPage allPostsPage = dashboardPage.sideMenu.ClickOnPosts();
            NUnit.Framework.Assert.IsTrue(allPostsPage.IsAt());

            //3.Click on 'Add New' button;
            allPostsPage.ClickOnAddNew();
            NUnit.Framework.Assert.IsTrue(createNewPostPage.IsAt());

            //4.Give the post a title and a description and click on 'ClickOnPublish' button;
            createNewPostPage.AddTitle(postTitle);
            createNewPostPage.AddDescription(postDescription);
            createNewPostPage.ClickOnPublish();
            NUnit.Framework.Assert.IsTrue(createNewPostPage.IsPublishedSuccessfully());

            //5.Click on the 'View post' link;
            createNewPostPage.ClickOnView();

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
            allPostsPage.Hover();
            allPostsPage.ClickOnEdit();

            //4.Edit the description;
            createNewPostPage.AddDescription(updateDescription);

            //5.Click on the 'Update' button;
            createNewPostPage.ClickOnPublish();

            //6.Click on the 'View post' link;
            createNewPostPage.ClickOnView();

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

            //1. Login with admin account;  
            CreateNewPostPage createNewPostPage = new CreateNewPostPage();
            LoginPage loginPage = new LoginPage();
            DashboardPage dashboardPage = loginPage.MakeLogin(userName, password);
            NUnit.Framework.Assert.IsTrue(dashboardPage.IsAt());

            //2. Click on Posts button from the side menu;
            AllPostsPage allPostsPage = dashboardPage.sideMenu.ClickOnPosts();
            NUnit.Framework.Assert.IsTrue(allPostsPage.IsAt());

            //3. Hover over Post title and click on 'Trash' option;
            allPostsPage.Hover();
            allPostsPage.ClickOnTrash();

            //4. Verify that '1 post moved to Trash.' message is displayed.
            NUnit.Framework.Assert.IsTrue(createNewPostPage.IsTrashedSuccessfully());
        }

        [TestMethod]
        [Test]
        public void Add_New_Page()
        {
            //variables used in the test
            string userName = "cosflaviu";
            string password = "test@1234";
            string postTitle = "Post1";
            string postDescription = "Description";

            //1. Login with admin account;  
            CreateNewPagePage createNewPagePage = new CreateNewPagePage();
            LoginPage loginPage = new LoginPage();
            DashboardPage dashboardPage = loginPage.MakeLogin(userName, password);
            NUnit.Framework.Assert.IsTrue(dashboardPage.IsAt());

            //2. Click on Pages button from the side menu;
            AllPagesPage allPagesPage = dashboardPage.sideMenu.ClickOnPages();
            NUnit.Framework.Assert.IsTrue(allPagesPage.IsAt());

            //3. Click on 'Add New' button;
            allPagesPage.ClickOnAddNew();
            NUnit.Framework.Assert.IsTrue(createNewPagePage.IsAt());

            //4. Give the page a title and a description and click on 'ClickOnPublish' button;
            createNewPagePage.AddTitle(postTitle);
            createNewPagePage.AddDescription(postDescription);
            createNewPagePage.ClickOnPublish();
            NUnit.Framework.Assert.IsTrue(createNewPagePage.IsPublishedSuccessfully());

            //5. Click on the 'View page' link;
            createNewPagePage.ClickOnView();

            //6. Verify that the title and the description are correct.
            CreatedPagePage createdpagePage = new CreatedPagePage();
            NUnit.Framework.Assert.AreEqual(createdpagePage.CheckTitle(), (postTitle));
            NUnit.Framework.Assert.AreEqual(createdpagePage.CheckDescription(), (postDescription));
        }

        [TestMethod]
        [Test]
        public void Edit_Existing_Page()
        {
            //variables used in the test
            string userName = "cosflaviu";
            string password = "test@1234";
            string postTitle = "Post1";
            string postDescription = "Description";
            string updateDescription = " Updated";

            //1. Login with admin account;  
            CreateNewPagePage createNewPagePage = new CreateNewPagePage();
            LoginPage loginPage = new LoginPage();
            DashboardPage dashboardPage = loginPage.MakeLogin(userName, password);
            NUnit.Framework.Assert.IsTrue(dashboardPage.IsAt());

            //2. Click on Pages button from the side menu;
            AllPagesPage allPagesPage = dashboardPage.sideMenu.ClickOnPages();
            NUnit.Framework.Assert.IsTrue(allPagesPage.IsAt());

            //3. Hover over the title of the first page item and click on 'Edit' option;
            allPagesPage.Hover();
            allPagesPage.ClickOnEdit();

            //4. Edit the page content;
            createNewPagePage.AddDescription(updateDescription);

            //5. Click on the 'Update' button;
            createNewPagePage.ClickOnPublish();

            //6. Click on the 'View page' link;
            createNewPagePage.ClickOnView();

            //7. Verify that the updated content is displayed.
            CreatedPagePage createdPagePage = new CreatedPagePage();
            NUnit.Framework.Assert.AreEqual(createdPagePage.CheckTitle(), (postTitle));
            NUnit.Framework.Assert.AreEqual(createdPagePage.CheckDescription(), postDescription + updateDescription);
        }

        [TestMethod]
        [Test]
        public void Delete_Existing_Page()
        {
            //variables used in the test
            string userName = "cosflaviu";
            string password = "test@1234";

            //1. Login with admin account;  
            CreateNewPagePage createNewPagePage = new CreateNewPagePage();
            LoginPage loginPage = new LoginPage();
            DashboardPage dashboardPage = loginPage.MakeLogin(userName, password);
            NUnit.Framework.Assert.IsTrue(dashboardPage.IsAt());

            //2. Click on Pages button from the side menu;
            AllPagesPage allPagesPage = dashboardPage.sideMenu.ClickOnPages();
            NUnit.Framework.Assert.IsTrue(allPagesPage.IsAt());

            //3. Hover over the title of the first page item and click on 'Trash' option;
            allPagesPage.Hover();
            allPagesPage.ClickOnTrash();

            //4. Verify that '1 page moved to Trash.' message is displayed.
            NUnit.Framework.Assert.IsTrue(createNewPagePage.IsTrashedSuccessfully());
        }


        [TestMethod]
        [Test]
        public void Edit_sharing_buttons_order_in_settings()
        {
            //1. Login with admin account;
            //2. Click on 'Settings' button from the sidemenu;
            //3. Click on 'Sharing' button from settings undemenu;
            //4. Add two new services from the Available Services to Enabled Services using drang and drop;
            //5. Go to All posts page;
            //6. Hover over any post and clik on 'View' link;
            //7. Verify that the two new services added at step(4) are present in the 'Share this:' section.
        }


        [TestCleanup]
        [TearDown]
        public void CleanUp()
        {
            Browser.Close();
        }
    }
}