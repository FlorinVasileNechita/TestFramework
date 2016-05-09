using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using TestFramework;

namespace Tests
{

    [TestFixture]
    [TestClass]
    public class UnitTest1
    {

        [TestInitialize]
        [SetUp]



        [TestCleanup]
        [TearDown]
        public void CleanUp()
        {
            Browser.Close();
        }


        [Test]
        [TestMethod]
        public void Login_to_wordpress()
        {
            Pages.LoginPage.Goto();
            NUnit.Framework.Assert.IsTrue(Pages.LoginPage.IsAt());

        }

        [Test]
        [TestMethod]
        public void Add_a_new_post()
        {
            Pages.LoginPage.Goto();
            NUnit.Framework.Assert.IsTrue(Pages.LoginPage.IsAt());

        }
    }
}