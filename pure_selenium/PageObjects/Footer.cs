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

        public IWebElement SocialLink(string icon) => driver.FindElement(By.XPath($"//a[i[contains(@class,'fa-{icon}')]]"));
        public string Copyright()=>driver.FindElement(By.CssSelector(".social p")).Text;
        
    }
}