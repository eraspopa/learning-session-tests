using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace page_factory2.PageObjects
{
    public class Footer:BaseSection
    {
        public Footer(IWebDriver driver) : base(driver)
        {

        }

        [FindsBy(How = How.CssSelector, Using = "div.social a i")]
        public IList<IWebElement> SocialIcons;
        public void ClickSocialIcon(string icon) => SocialIcons.Single(link => link.GetAttribute("class").Contains(icon)).Click();


        [FindsBy(How = How.CssSelector, Using = ".site-footer p")]
        private IWebElement CopyrightMessage;
        public string CopyrightMessageText => CopyrightMessage.Text;
    }
}
