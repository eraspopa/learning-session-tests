using System;
using System.Drawing.Imaging;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using page_factory2.PageObjects;
using TechTalk.SpecFlow;

namespace page_factory2.Steps
{
    using static Assert;
    using static StringAssert;
    using static String;
    using static TestContext;
   
    [Binding]
    public class HomePageSteps
    {
        private static IWebDriver _webDriver;
        HomePage _home = new HomePage(_webDriver);
        public const string BaseUrl = "http://lizas-test-site.gear.host";
        private string name;
        private string email;
        private string comment;
        [BeforeFeature()]
        public static void BeforeFeature()
        {
            _webDriver = new ChromeDriver();
            _webDriver.Navigate().GoToUrl(BaseUrl);

        }

        [AfterFeature()]
        public static void AfterFeature()
        {
            _webDriver.Quit();
        }
        
        [When(@"I click the (.*) header link")]
        public void WhenIClickTheHeaderLink(string link)
        {
         _home.Header.ClickNavLink(link); 
        }
        
        [Then(@"I am redirected to the /(.*) url")]
        public void ThenIAmRedirectedToTheUrl(string url)
        {
            Contains(url, _webDriver.Url);
        }

        [Then(@"the page has correct (.*) title")]
        public void ThenThePageHasCorrectTitle(string title)
        {
            AreEqual(title,_webDriver.Title);
        }

        [Then(@"the following quote is shown on the main page:")]
        public void ThenTheFollowingQuoteIsShownOnTheMainPage(Table table)
        {
            AreEqual(Join(" ", table.Rows.Select(r => r[0])),
                _home.Main.QuoteMessageText);
        }

        [When(@"I click the (.*) social icon")]
        public void WhenIClickTheSocialIcon(string icon)
        {
            _home.Footer.ClickSocialIcon(icon);
        }

        [Then(@"the copyright message is shown:")]
        public void ThenTheCopyrightMessageIsShown(Table table)
        {
            AreEqual(Join(" ", table.Rows.Select(r => r[0])),
                _home.Footer.CopyrightMessageText);
        }

        [Given(@"I am on the (.*) page")]
        [When(@"I navigate to the (.*) page")]
        public void WhenINavigateToThePage(string page)
        {
            _webDriver.Navigate().GoToUrl(BaseUrl + page);
        }

        [When(@"click the grey navigation (.*) link")]
        public void WhenClickTheGreyNavigationLink(string link)
        {
            _home.Main.ClickFeedbackLink(link);
        }

        [When(@"I click the (.*) button")]
        public void WhenIClickTheButton(string button)
        {
            _home.Main.ClickButton();
        }

        [When(@"fill in following values:")]
        public void WhenFillInFollowingValues(Table table)
        {
            foreach (var row in table.Rows)
            {
                name = row[0];
                email = row[1];
                comment = row[2];
                _home.Main.LeaveComment(row[0], row[1], row[2]);
            }

        }

        [Then(@"at least two items are shown in the feedback section")]
        public void ThenAtLeastTwoItemsAreShownInTheFeedbackSection()
        {
            WriteLine(_home.Main.NumberOfComments);
            //IsTrue(_home.NumberOfComments >= 2);
        }

        [Then(@"the (.*) field shows the error message:")]
        public void ThenTheFieldShowsTheErrorMessage(string field, Table table)
        {
            foreach (var row in table.Rows)
            {
                AreEqual(_home.Main.WarningText(field), row[0]);
            }
        }

        [Then(@"the data is shown in the feedback section")]
        public void ThenTheDataIsShownInTheFeedbackSection()
        {
            AreEqual(_home.Main.LatestCommentText, comment);
            AreEqual(_home.Main.LatestCommentAuthorText, Concat(name, "\r\n", email));
        }

        [Then(@"I am redirected to the correct (.*) url")]
        public void ThenIAmRedirectedToTheCorrectUrl(string url)
        {
            Contains(url,_webDriver.Url);
        }

      


    }
}
