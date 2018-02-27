using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Coypu;

namespace coypu_tests.Tools
{
    public static class Browser
    {
        public static BrowserSession Session { get; set; }
        public const string BaseUrl = "http://lizas-test-site.gear.host";
    }
}
