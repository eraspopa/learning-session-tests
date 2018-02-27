using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Coypu;

namespace coypu_tests.PageObjects
{
    public class Header:BaseSection
    {
        public Header(string css= "header.site-header") : base(css)
        {
            
        }

        public void ClickHeaderLink(string link) => Scope
            .FindXPath($"//nav[@class='site-navigation']//a[.='{link}']").Click();

    }
}
