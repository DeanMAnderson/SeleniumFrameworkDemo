using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumFramework.Pages
{
    public class SearchResultPage
    {
        public static bool IsAt()
        {
            return Driver.Instance.Title.Contains("Google Search");
        }

        public static string GetFirstResultTitle()
        {
            WebDriverWait wait = new WebDriverWait(Driver.Instance, new TimeSpan(0,0,2));
            wait.Until(x => x.FindElement(By.TagName("h3"))); ;

            return Driver.Instance.FindElement(By.TagName("h3")).Text;
        }

        public static bool IsFirstResultRelatedTo(string searchTerm)
        {
            return GetFirstResultTitle().Contains(searchTerm);
        }
    }
}
