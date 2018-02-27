using OpenQA.Selenium.Chrome;
using page_factory2.Tools;

namespace page_factory2.Tools
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
