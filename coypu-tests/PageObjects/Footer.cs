using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace coypu_tests.PageObjects
{
    public class Footer:BaseSection
    {
        public Footer(string css= "footer.site-footer") :base(css)
        {
            
        }

        public string SocialLink(string icon) => Scope.FindXPath($"//a[i[contains(@class,'fa-{icon}')]]")["href"];
        public string CopyrightText => Scope.FindCss(".site-footer p").Text;
    }
}
