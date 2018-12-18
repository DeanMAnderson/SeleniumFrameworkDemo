using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumFramework.Pages
{
    public static class HomePage
    {
        private static string Url => "http://www.google.co.uk";

        public static void GoTo()
        {
            Driver.Instance.Navigate().GoToUrl(Url);
        }

        public static bool IsAt()
        {
            return Driver.Instance.Title == "Google";
        }
    }
}
