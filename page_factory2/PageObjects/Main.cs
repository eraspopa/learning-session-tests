using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace page_factory2.PageObjects
{
    public class Main:BaseSection
    {
        public Main(IWebDriver driver) : base(driver)
        {
            
        }
        [FindsBy(How = How.CssSelector, Using = ".site-content q")]
        private IWebElement QuoteMessage;

        public string QuoteMessageText => QuoteMessage.Text;


        [FindsBy(How = How.CssSelector, Using = "div.container blockquote")]
        private IList<IWebElement> Comments;

        public int NumberOfComments => Comments.Count;

        [FindsBy(How = How.CssSelector, Using = ".container blockquote:last-child p")]
        private IWebElement LatestComment;

        public string LatestCommentText => LatestComment.Text;

        [FindsBy(How = How.CssSelector, Using = ".container blockquote:last-child cite")]
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

        public void ClickButton() => Button.Click();

        [FindsBy(How = How.CssSelector, Using = "span.text-danger span")]
        private IList<IWebElement> Warnings;

        public string WarningText(string field) => Warnings.Single(link => string.Equals(link.GetAttribute("for"), field)).Text;
    }
}
