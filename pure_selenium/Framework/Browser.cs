using System;
using System.Collections.ObjectModel;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace pure_selenium.Framework
{
    public static class Browser
    {
        public static IWebDriver driver = new ChromeDriver();
        private const string Host = "http://lizas-test-site.gear.host";
        public static void Start()
        {
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl(Host);
        }
        public static WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
        public static void Quit()=> driver.Quit();
        public static void Visit(string url)=> driver.Navigate().GoToUrl(Host+url);
        public static ReadOnlyCollection<IWebElement> FindAllCss(string selector) => driver.FindElements(By.CssSelector(selector));
        public static string CurrentUrl() => driver.Url;
        public static string PageTitle() => driver.Title;
        
    }
}
