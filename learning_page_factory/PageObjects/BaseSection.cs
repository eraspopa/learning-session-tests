using learning_pure.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace learning_pure.PageObjects
{
   using static Browser;
   public abstract class BaseSection
    {
        protected BaseSection(string css)
        {
            Scope = driver.FindElement(By.CssSelector(css));
            PageFactory.InitElements(driver, this);
        }
        public IWebElement Scope { get; set; }
    }
}
