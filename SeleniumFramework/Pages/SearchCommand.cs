using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumFramework.Pages
{
    public class SearchCommand
    {
        private string SearchText;

        public SearchCommand(string searchText)
        {
            SearchText = searchText;
        }

        public void AndSearch()
        {
            IWebElement searchInput = Driver.Instance.FindElement(By.Name("q"));
            searchInput.SendKeys(SearchText);
            searchInput.SendKeys(Keys.Return);
        }
    }
}
