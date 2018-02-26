using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace page_factory
{
    public class HomePage
    {
        private IWebDriver driver;

        public HomePage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.CssSelector, Using = "nav.site-navigation a")]
        private IList<IWebElement> NavLinks;

        public void ClickNavLink(string linkText) => NavLinks.Single(link => string.Equals(link.Text, linkText)).Click();

        [FindsBy(How = How.CssSelector, Using = ".site-content q")]
        private IWebElement QuoteMessage;

        public string QuoteMessageText => QuoteMessage.Text;

        [FindsBy(How = How.CssSelector, Using = ".site-footer p")]
        private IWebElement CopyrightMessage;

        public string CopyrightMessageText => QuoteMessage.Text;

        [FindsBy(How = How.CssSelector, Using = "blockquote")]
        private IList<IWebElement> Comments;

        public int NumberOfComments => Comments.Count;

        [FindsBy(How = How.CssSelector, Using = ".container blockquote:last-child p")]
        private IWebElement LatestComment;

        public string LatestCommentText => LatestComment.Text;

        [FindsBy(How = How.CssSelector,Using = ".container blockquote:last-child cite")]
        private IWebElement LatestCommentAuthor;

        public string LatestCommentAuthorText => LatestCommentAuthor.Text;

        [FindsBy(How = How.CssSelector, Using = "input#Name")]
        private IWebElement NameField;

        [FindsBy(How = How.CssSelector, Using = "input#Email")]
        private IWebElement EmailField;

       
        [FindsBy(How = How.CssSelector, Using = "input#Comment")]
        private IWebElement CommentField;

       
        public void LeaveComment(string name, string email, string comment)
        {
            NameField.SendKeys(name);
            EmailField.SendKeys(email);
            CommentField.SendKeys(comment);
        }

        [FindsBy(How = How.CssSelector, Using = "p.thank")]
        private IList<IWebElement> FeedbackLinks;

        public void ClickFeedbackLink(string linkText) => FeedbackLinks.Single(link => string.Equals(link.Text, linkText)).Click();

        [FindsBy(How = How.CssSelector, Using = "input.main-btn")]
        private IWebElement Button;

        public void ClickButton()=> Button.Click();
        
        [FindsBy(How = How.CssSelector,Using = "span.text-danger span")]
        private IList<IWebElement> Warnings;

        public string WarningText(string field) => Warnings.Single(link => string.Equals(link.GetAttribute("for"), field)).Text;

        [FindsBy(How = How.CssSelector, Using = "div.social a")]
        public IList<IWebElement> SocialIcons;
        public IList<string> SocialLink() => SocialIcons.Select(a=>a.GetAttribute("href")).ToList();
    }
}
