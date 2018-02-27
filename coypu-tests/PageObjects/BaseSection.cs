using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using coypu_tests.Tools;
using Coypu;

namespace coypu_tests.PageObjects
{
    using static Browser;
    public abstract class BaseSection
    {
        protected BaseSection(string css)
        {
            Scope = Session.FindCss(css);
        }
        public ElementScope Scope { get; set; }
    }
}
