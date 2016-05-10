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
        
        
        [Test]
        [TestMethod]
        public void Login_to_wordpress()
        {
            Pages.LoginPage.Goto();
            //NUnit.Framework.Assert.IsTrue(Pages.xbox_site.IsAt());
            Pages.LoginPage.MakeLogin();
           
        }

        [Test]
        [TestMethod]
        public void Celalalt_site()
        {
            xbox_site.TestInit();
            xbox_site.SearchFor("Forza 6");
            xbox_site.FindGame("Forza Motorsport 6 Standard Edition");
            NUnit.Framework.Assert.AreEqual("$59.99", xbox_site.GetPrice());
   
        }
  
        
        [TestCleanup]
        [TearDown]
        public void CleanUp()
        {
            Browser.Close();
        }
        
    }
}