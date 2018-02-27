using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace pure_selenium.Framework
{
    using static Browser;
    
    public static class BrowserTools
    {
       public static void StartChrome()
        {
            Driver = new ChromeDriver();
            Driver.Manage().Window.Maximize();
            Driver.Navigate().GoToUrl(Host);
           
        }
        public static void Quit() => Driver.Quit();
        public static void Visit(string url) => Driver.Navigate().GoToUrl(Host + url);
        public static string CurrentUrl() => Driver.Url;
        public static string PageTitle() => Driver.Title;

        
    }
}
