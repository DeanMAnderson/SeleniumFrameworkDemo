using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace SeleniumFramework
{
    public class Driver
    {
        internal static IWebDriver Instance { get; private set; } = new FirefoxDriver();
    }
}
