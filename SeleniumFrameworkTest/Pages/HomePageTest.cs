using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SeleniumFramework.Pages;

namespace SeleniumFrameworkTest.Pages
{
    [TestClass]
    public class HomePageTest
    {
        [TestMethod]
        public void CanGoToAndIsAt_True()
        {
            HomePage.GoTo();

            Assert.IsTrue(HomePage.IsAt());
        }

        [TestMethod]
        public void SearchGuildWarsIsFirstResultGuildWars()
        {
            HomePage.GoTo();

            HomePage.EnterSearchText("Guild Wars").AndSearch();


            Assert.IsTrue(SearchResultPage.IsFirstResultRelatedTo("Guild Wars"));
        }
    }
}
