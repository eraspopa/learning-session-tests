using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace page_factory2.Tools
{
   public static class Browser
    {
        public static IWebDriver Driver { get; set; }
        public const string Host = "http://lizas-test-site.gear.host";

    }
}
