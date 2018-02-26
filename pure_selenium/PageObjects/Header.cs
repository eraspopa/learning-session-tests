using OpenQA.Selenium;
using pure_selenium.Framework;
using pure_selenium.PageObjects;

namespace pure_selenium.PageObjects
{
   using static Browser;
   public class Header:BaseSection
    {
        public Header(string css= "header.site-header") :base(css)
        {
        }
        public void ClickHeaderLink(string link)=> driver.FindElement(By.XPath($"//nav[@class='site-navigation']//a[.='{link}']")).Click();
        public string Copyright() => driver.FindElement(By.CssSelector("p.m-0")).Text;
    }
}
