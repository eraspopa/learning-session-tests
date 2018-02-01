using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learning_pure.PageObjects
{
    public class Page
    {
        public Page()
        {
            Header=new Header();
            Main= new Main();
        }
        public Header Header { get; }
        public Main Main { get; }
        public Footer Footer { get; }

    }
}
