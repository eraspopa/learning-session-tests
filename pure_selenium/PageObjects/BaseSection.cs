using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using pure_selenium.Framework;


namespace pure_selenium.PageObjects
{
   using static Browser;
   public abstract class BaseSection
    {
        protected BaseSection(string css)
        {
            Scope = driver.FindElement(By.CssSelector(css));
        }
        public IWebElement Scope { get; set; }
    }
}
