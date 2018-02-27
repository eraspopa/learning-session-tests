using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace page_factory2.PageObjects
{
    public class Header:BaseSection
    {
        public Header(IWebDriver driver):base(driver)
        {
          
        }

        [FindsBy(How = How.CssSelector, Using = "nav.site-navigation a")]
        private IList<IWebElement> NavLinks;

        public void ClickNavLink(string linkText) => NavLinks.Single(link => string.Equals(link.Text, linkText)).Click();
    }
}
