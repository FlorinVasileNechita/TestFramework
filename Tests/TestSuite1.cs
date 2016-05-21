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
        [Test, Order(1)]
        public void Add_New_Post()
        {
            //variables used in the test
            string userName = "cosflaviu";
            string password = "test@1234";
            string Title = "Post1";
            string Description = "Description";

            //1.Login with admin account;  
            LoginPage loginPage = new LoginPage();
            DashboardPage dashboardPage = loginPage.MakeLogin(userName, password);
            NUnit.Framework.Assert.IsTrue(dashboardPage.IsAt());

            //2.Click on Posts button from the side menu;
            AllPostsPage allPostsPage = dashboardPage.sideMenu.ClickOnPosts();
            NUnit.Framework.Assert.IsTrue(allPostsPage.IsAt());

            //3.Click on 'Add New' button;
            CreateNewPostPage createNewPostPage = new CreateNewPostPage();
            allPostsPage.ClickOnAddNew();
            NUnit.Framework.Assert.IsTrue(createNewPostPage.IsAt());

            //4.Give the post a title and a description and click on 'Publish' button;
            createNewPostPage.AddTitle(Title);
            createNewPostPage.AddDescription(Description);
            createNewPostPage.ClickOnPublish();
            NUnit.Framework.Assert.IsTrue(createNewPostPage.IsPublishedSuccessfully());

            //5.Click on the 'View post' link;
            createNewPostPage.ClickOnView();

            //6.Verify if the title and the description are correct.
            CreatedPostPage createdPostPage = new CreatedPostPage();
            NUnit.Framework.Assert.AreEqual(createdPostPage.CheckPageTitle() , string.Format( "{0} – {1}", Title , userName));
            NUnit.Framework.Assert.AreEqual(createdPostPage.CheckTitle(), (Title));
            NUnit.Framework.Assert.AreEqual(createdPostPage.CheckDescription(), (Description));
        }

        [TestMethod]
        [Test, Order(2)]
        public void Edit_Existing_Post()
        {
            //variables used in the test
            string userName = "cosflaviu";
            string password = "test@1234";
            string Title = "Post1";
            string Description = "Description";
            string updateDescription = " Updated";

            //1.Login with admin account;  
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
            CreateNewPostPage createNewPostPage = new CreateNewPostPage();
            createNewPostPage.AddDescription(updateDescription);

            //5.Click on the 'Update' button;
            createNewPostPage.ClickOnPublish();

            //6.Click on the 'View post' link;
            createNewPostPage.ClickOnView();

            //7.Verify if the updated description is displayed.
            CreatedPostPage createdPostPage = new CreatedPostPage();
            NUnit.Framework.Assert.AreEqual(createdPostPage.CheckTitle(), (Title));
            NUnit.Framework.Assert.AreEqual(createdPostPage.CheckDescription(), Description + updateDescription);
        }

        [TestMethod]
        [Test, Order(3)]
        public void Delete_Existing_Post()
        {
            //variables used in the test
            string userName = "cosflaviu";
            string password = "test@1234";

            //1. Login with admin account;  
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
            NUnit.Framework.Assert.IsTrue(allPostsPage.IsTrashedSuccessfully());
        }

        [TestMethod]
        [Test, Order(4)]
        public void Add_New_Page()
        {
            //variables used in the test
            string userName = "cosflaviu";
            string password = "test@1234";
            string Title = "Page1";
            string Description = "Description";

            //1. Login with admin account;  
            LoginPage loginPage = new LoginPage();
            DashboardPage dashboardPage = loginPage.MakeLogin(userName, password);
            NUnit.Framework.Assert.IsTrue(dashboardPage.IsAt());

            //2. Click on Pages button from the side menu;
            AllPagesPage allPagesPage = dashboardPage.sideMenu.ClickOnPages();
            NUnit.Framework.Assert.IsTrue(allPagesPage.IsAt());

            //3. Click on 'Add New' button;
            allPagesPage.ClickOnAddNew();
            CreateNewPagePage createNewPagePage = new CreateNewPagePage();
            NUnit.Framework.Assert.IsTrue(createNewPagePage.IsAt());

            //4. Give the page a title and a description and click on 'Publish' button;
            createNewPagePage.AddTitle(Title);
            createNewPagePage.AddDescription(Description);
            createNewPagePage.ClickOnPublish();
            NUnit.Framework.Assert.IsTrue(createNewPagePage.IsPublishedSuccessfully());

            //5. Click on the 'View page' link;
            createNewPagePage.ClickOnView();

            //6. Verify that the title and the description are correct.
            CreatedPagePage createdpagePage = new CreatedPagePage();
            NUnit.Framework.Assert.AreEqual(createdpagePage.CheckTitle(), (Title));
            NUnit.Framework.Assert.AreEqual(createdpagePage.CheckDescription(), (Description));
        }

        [TestMethod]
        [Test, Order(5)]
        public void Edit_Existing_Page()
        {
            //variables used in the test
            string userName = "cosflaviu";
            string password = "test@1234";
            string Title = "Page1";
            string Description = "Description";
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
            NUnit.Framework.Assert.AreEqual(createdPagePage.CheckTitle(), (Title));
            NUnit.Framework.Assert.AreEqual(createdPagePage.CheckDescription(), Description + updateDescription);
        }

        [TestMethod]
        [Test, Order(6)]
        public void Delete_Existing_Page()
        {
            //variables used in the test
            string userName = "cosflaviu";
            string password = "test@1234";

            //1. Login with admin account;  
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
            NUnit.Framework.Assert.IsTrue(allPagesPage.IsTrashedSuccessfully());
        }

        [TestMethod]
        [Test, Order(7)]
        public void Enable_sharing_buttons_in_Settings()
        {
            //variables used in the test
            string userName = "cosflaviu";
            string password = "test@1234";

            //1. Login with admin account;  
            LoginPage loginPage = new LoginPage();
            DashboardPage dashboardPage = loginPage.MakeLogin(userName, password);
            NUnit.Framework.Assert.IsTrue(dashboardPage.IsAt());

            //2. Click on 'Settings' button from the sidemenu;
            GeneralSettingsPage generalSettingsPage = dashboardPage.sideMenu.ClickOnSettings();
            NUnit.Framework.Assert.IsTrue(generalSettingsPage.IsAt());

            //3. Click on 'Sharing' button from settings undemenu;
            SharingSettingsPage sharingSettingsPage = generalSettingsPage.sideMenu.ClickOnSharing();
            NUnit.Framework.Assert.IsTrue(sharingSettingsPage.IsAt());

            //4. Add two new services from the Available Services to Enabled Services using drang and drop;
            int oldNumberOfEnabledServices = sharingSettingsPage.EnabledServicesCount();
            sharingSettingsPage.DragAndDropFromAvailableToEnabled();
            sharingSettingsPage.DragAndDropFromAvailableToEnabled();

            //5. Verify that the services added at step (4) are present in the Enabled Services section;
            int newNumberOfEnabledServices = sharingSettingsPage.EnabledServicesCount();
            NUnit.Framework.Assert.AreEqual(newNumberOfEnabledServices , oldNumberOfEnabledServices + 2);

            //6. Go to All posts page;
            sharingSettingsPage.sideMenu.ClickOnPosts();

            //7. Hover over any post and clik on 'View' link;
            AllPostsPage allPostsPage = new AllPostsPage();
            allPostsPage.Hover();
            allPostsPage.ClickOnView();

            //8. Verify that the two new services added at step(4) are present in the 'Share this:' section;
            CreatedPostPage createdPostPage = new CreatedPostPage();
            int shareThisElementsOnPost = createdPostPage.ShareElementsCount();
            NUnit.Framework.Assert.AreEqual(newNumberOfEnabledServices , shareThisElementsOnPost);

            //9. (Cleanup Step) Go back to the 'Sharing' settings;
            Browser.NavigateBack();
            allPostsPage.sideMenu.ClickOnSettings();
            generalSettingsPage.sideMenu.ClickOnSharing();

            //10. (Cleanup Step) Remove the Services added at step (4);
            sharingSettingsPage.DragAndDropFromEnabledToAvailable();
            sharingSettingsPage.DragAndDropFromEnabledToAvailable();

            //11. (Cleanup Step) Verify that the two services added at step (4) are removed from the Enabled Services section.
            NUnit.Framework.Assert.AreEqual(oldNumberOfEnabledServices, newNumberOfEnabledServices - 2);
        }

        [TestMethod]
        [Test, Order(8)]
        public void Scroll_through_Themes_and_preview_Hemingway_Theme()
        {
            //variables used in the test
            string userName = "cosflaviu";
            string password = "test@1234";

            //1. Login with admin account;  
            LoginPage loginPage = new LoginPage();
            DashboardPage dashboardPage = loginPage.MakeLogin(userName, password);
            NUnit.Framework.Assert.IsTrue(dashboardPage.IsAt());

            //2. Click on 'Appearance' button from the sidemenu;
            ManageThemesPage manageThemesPage = dashboardPage.sideMenu.ClickOnAppearance();
            NUnit.Framework.Assert.IsTrue(manageThemesPage.IsAt());

            //3. Scroll down the themes list until 'Trvl' theme is visible;
            manageThemesPage.ScrollDownToTheme();

            //4. Hover over the Theme and click on the 'Preview' button;
            manageThemesPage.Hover();
            manageThemesPage.ClickOnPreview();

            //5. Close the the theme privew by clicking on the 'X' button.
        }

        [TestCleanup]
        [TearDown]
        public void CleanUp()
        {
            Browser.Close();
        }
    }
}