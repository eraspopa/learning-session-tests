using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Coypu;
using OpenQA.Selenium.Chrome;

namespace coypu_tests.Tools
{
    using static Browser;
    using static String;
   public static class BrowserTools
    {
        public static void LaunchChrome()
        {
            Session = new BrowserSession(
                new SessionConfiguration
                {
                    AppHost = BaseUrl,
                    Browser = Coypu.Drivers.Browser.Chrome,
                    Timeout = TimeSpan.FromSeconds(5),
                    RetryInterval = TimeSpan.FromMilliseconds(500)
                });
            Session.Visit("/");
        }

        public static void Dispose() => Session.Dispose();
        public static string PageTitle => Session.Title;
        public static string CurrentUrl => Session.Location.AbsoluteUri;
        public static void Visit(string url) => Session.Visit(Concat(BaseUrl,url));

    }
}
