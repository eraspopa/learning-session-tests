using learning_pure.Framework;
using OpenQA.Selenium;

namespace learning_pure.PageObjects
{
    using static Browser;

    public class Footer : BaseSection
    {
        public Footer(string css = "footer.site-footer") : base(css)
        {
        }

        public string SocialLink(string icon)=>driver.FindElement(By.XPath($"./a[i[contains(@class,'fa-{icon}')]]")).GetAttribute("href");
        public string Copyright()=>driver.FindElement(By.CssSelector(".social p")).Text;
        
    }
}