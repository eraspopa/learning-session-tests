using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coypu_tests.PageObjects
{
    public class Page
    {
        public Page()
        {
            Header = new Header();
            Footer = new Footer();
            Main = new Main();
        }
        public Header Header { get; set; }
        public Footer Footer { get; set; }
        public Main Main { get; set; }
    }
}
