using OpenQA.Selenium;
using pure_selenium.Framework;


namespace pure_selenium.PageObjects
{
   using static Browser;
   public abstract class BaseSection
    {
        protected BaseSection(string css)
        {
            Scope = Driver.FindElement(By.CssSelector(css));
        }

        protected BaseSection()
        {
            
        }
        public IWebElement Scope { get; set; }
    }
}
