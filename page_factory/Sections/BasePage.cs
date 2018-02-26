using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace page_factory.Sections
{
    public class Page
    {
        private IWebDriver _driver;

        public Page(IWebDriver driver)
        {
           _driver = driver;
            PageFactory.InitElements(driver,this);
        }

        [FindsBy(How = How.CssSelector, Using = "nav.site-navigation a")]
        private IList<IWebElement> HeaderLinks { get; set; }
        public void ClickHeaderLink(string linkText) => HeaderLinks.Single(link => string.Equals(link.Text, linkText)).Click();

        [FindsBy(How = How.CssSelector, Using = ".site-content q")]
        private IWebElement ArtistsQuote { get; set; }

        public string ArtistsQuoteText => ArtistsQuote.Text;

        [FindsBy(How=How.CssSelector,Using = "div.social a")]
        private IList<IWebElement> SocialIconsLinks { get; set; }
       public IList<string> SocialLinks() => SocialIconsLinks.Select(a => a.GetAttribute("href")).ToList();
        
        [FindsBy(How=How.CssSelector, Using = ".site-footer p")]
        private IWebElement Copyright { get; set; }

        public string CopyrightText => Copyright.Text;

        [FindsBy(How = How.CssSelector, Using = "p.thank")]
        private IList<IWebElement> FeedbackLinks { get; set; }
        public void ClickFeedbackLink(string linkText) => FeedbackLinks.Single(link => string.Equals(link.Text, linkText)).Click();

        [FindsBy(How = How.XPath, Using = "//input[@value='Send a message']")]
        private IWebElement SendButton { get; set; }

        public void ClickSendButton() => SendButton.Click();

        [FindsBy(How = How.CssSelector, Using = "input#Name")]
        private IWebElement NameField { get; set; }

        public void FillInName(string name) => NameField.SendKeys(name);

        [FindsBy(How = How.CssSelector, Using = "input#Email")]
        private IWebElement EmailField { get; set; }
        public void FillInEmail(string email) => EmailField.SendKeys(email);

        [FindsBy(How = How.CssSelector, Using = "input#Comment")]
        private IWebElement CommentField { get; set; }
        public void FillInComment(string comment) => CommentField.SendKeys(comment);

        [FindsBy(How=How.TagName,Using = "blockquote")]
        private IList<IWebElement> Comments { get; set; }

        public int CountComments => Comments.Count;

        [FindsBy(How = How.CssSelector,Using = "span.text-danger span")]
        private IList<IWebElement> ErrorMessage { get; set; }

        public string ErrorMessageText(string field) => ErrorMessage
            .Single(link => Equals(link.GetAttribute("for"), field)).Text;
           
        [FindsBy(How=How.CssSelector, Using = ".container blockquote:last-child p")]
        private IWebElement LastComment { get; set; }

        public string LastCommentText => LastComment.Text;

        [FindsBy(How = How.CssSelector, Using = ".container blockquote:last-child cite")]
        private IWebElement LastAuthor { get; set; }

        public string LastAuthorText => LastAuthor.Text;
    }
}
