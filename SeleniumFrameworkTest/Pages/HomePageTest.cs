using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SeleniumFramework.Pages;

namespace SeleniumFrameworkTest.Pages
{
    [TestClass]
    [TestCategory("Home Page")]
    public class HomePageTest
    {
        [TestMethod]
        public void GoToAndIsAt_True()
        {
            HomePage.GoTo();

            Assert.IsTrue(HomePage.IsAt());
        }

        [TestMethod]
        public void EnterGuildWarsAndSearch_IsFirstResultGuildWars()
        {
            HomePage.GoTo();

            HomePage.EnterSearchText("Guild Wars").AndSearch();


            Assert.IsTrue(SearchResultPage.IsFirstResultRelatedTo("Guild Wars"));
        }
    }
}
