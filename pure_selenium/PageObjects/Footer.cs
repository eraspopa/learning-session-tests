using OpenQA.Selenium;
using pure_selenium.Framework;

namespace pure_selenium.PageObjects
{
    using static Browser;

    public class Footer : BaseSection
    {
        public Footer(string css = "footer.site-footer") : base(css)
        {
        }
        public string SocialLink(string icon)=>Driver.FindElement(By.XPath($"//a[i[contains(@class,'fa-{icon}')]]")).GetAttribute("href");
        public string Copyright()=>Driver.FindElement(By.CssSelector("footer.site-footer p")).Text;
        
    }
}