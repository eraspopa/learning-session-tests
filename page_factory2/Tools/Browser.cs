using OpenQA.Selenium;
using page_factory2.PageObjects;

namespace page_factory2.Tools
{
   public static class Browser
    {
        public static IWebDriver Driver { get; set; }
        public const string Host = "http://lizas-test-site.gear.host";
       
    }
}
