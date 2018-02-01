using learning_pure.Framework;
using OpenQA.Selenium;

namespace learning_pure.PageObjects
{
   using static Browser;
   public class Header:BaseSection
    {
        public Header(string css= "header.site-header") :base(css)
        {
        }
        public void ClickHeaderLink(string link)=> driver.FindElement(By.XPath($"//nav[@class='site-navigation']//a[.='{link}']")).Click();

    }
}
