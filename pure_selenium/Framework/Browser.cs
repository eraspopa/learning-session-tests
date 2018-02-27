using System;
using System.Collections.ObjectModel;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace pure_selenium.Framework
{
    public static class Browser
    {
        public static IWebDriver Driver { get; set; }
        public const string Host = "http://lizas-test-site.gear.host";
    }
}
