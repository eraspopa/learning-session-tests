using System.Collections.ObjectModel;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace learning_pure.Framework
{
    public static class Browser
    {
        public static IWebDriver driver = new ChromeDriver();
        private const string host = "http://lizas-test-site.gear.host";
        public static void Start()
        {
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl(host);
        }

        public static void Quit()=> driver.Quit();
        public static void Visit(string url)=> driver.Navigate().GoToUrl(host+url);
        public static IWebElement FindXPath(string selector) => driver.FindElement(By.XPath(selector));
        public static IWebElement FindCss(string selector) => driver.FindElement(By.CssSelector(selector));
        public static ReadOnlyCollection<IWebElement> FindAllCss(string selector) => driver.FindElements(By.CssSelector(selector));
        public static string CurrentUrl() => driver.Url;
        public static string PageTitle() => driver.Title;

    }
}
