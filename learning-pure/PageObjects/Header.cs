using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace learning-page-factory.PageObjects
{
    public class Header
    {
        private IWebDriver driver;

        public Header(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }


    }
}
