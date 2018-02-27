using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace coypu_tests.PageObjects
{
   public class Comment:BaseSection
    {
        public Comment(string css,int n) : base(css)
        {
            Scope = Scope.FindCss($"blockquote:nth-child({n})");
        }

        public string CommentText => Scope.FindCss("p").Text;
        public string CommentAuthor => Scope.FindCss("site").Text;

    }
}
