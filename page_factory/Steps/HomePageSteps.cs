using System;
using System.Linq;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.PageObjects;
using page_factory.Sections;
using TechTalk.SpecFlow;
namespace page_factory.Steps
{
    using static Assert;
    using static StringAssert;
    using static String;
   
    [Binding]
    public class HomePageSteps
    {
        private static IWebDriver _driver;
        public const string BaseUrl = "http://lizas-test-site.gear.host";
        private string name;
        private string email;
        private string comment;
        private Page _page = new Page(_driver);
        [BeforeFeature()]
        public static void BeforeFeature()
        {
            _driver = new ChromeDriver();
        }

        [AfterFeature()]
        public static void AfterFeature()
        {
            _driver.Quit();
        }
        
        [When(@"I click the (.*) header link")]
        public void WhenIClickTheHeaderLink(string link)
        {
          _page.ClickHeaderLink(link);
            Thread.Sleep(1000);
        }
        
        [Then(@"I am redirected to the (.*) url")]
        public void ThenIAmRedirectedToTheUrl(string url)
        {
           AreEqual(BaseUrl+url, _driver.Url);
        }

        [Then(@"the page has correct (.*) title")]
        public void ThenThePageHasCorrectTitle(string title)
        {
            AreEqual(_driver.Title, title);
        }

        [Then(@"the following quote is shown on the main page:")]
        public void ThenTheFollowingQuoteIsShownOnTheMainPage(Table table)
        {
           AreEqual(Join(" ", table.Rows.Select(r => r[0])),_page.ArtistsQuoteText);
        }
        
        [Then(@"social links have correct urls:")]
        public void ThenSocialLinksHaveCorrectUrls(Table table)
        {

            
        }
        
        [Then(@"the copyright message is shown:")]
        public void ThenTheCopyrightMessageIsShown(Table table)
        {
           AreEqual(Join(" ", table.Rows.Select(r => r[0])),_page.CopyrightText);
        }

        [Given(@"I am on the (.*) page")]
        [When(@"I navigate to the (.*) page")]
        public void WhenINavigateToThePage(string page)
        {
            _driver.Navigate().GoToUrl(BaseUrl + page);
        }

        [When(@"click the grey navigation (.*) link")]
        public void WhenClickTheGreyNavigationLink(string link)
        {
            _page.ClickFeedbackLink(link);
        }

        [When(@"I click the (.*) button")]
        public void WhenIClickTheButton(string button)
        {
           _page.ClickSendButton();
            
        }

        [When(@"fill in following values:")]
        public void WhenFillInFollowingValues(Table table)
        {
            foreach (var row in table.Rows)
            {
                name = row[0]; email = row[1]; comment = row[2];
               _page.FillInName(row[0]);
                _page.FillInEmail(row[1]);
                _page.FillInComment(row[2]);
            }
        }

        [Then(@"at least two items are shown in the feedback section")]
        public void ThenAtLeastTwoItemsAreShownInTheFeedbackSection()
        {
           IsTrue(_page.CountComments >= 2);
        }

        [Then(@"the (.*) field shows the error message:")]
        public void ThenTheFieldShowsTheErrorMessage(string field, Table table)
       {
           Thread.Sleep(2000);
            foreach (var row in table.Rows)
            {
                AreEqual(_page.ErrorMessageText(field), row[0]);
            }

        }

        [Then(@"the data is shown in the feedback section")]
        public void ThenTheDataIsShownInTheFeedbackSection()
        {
            AreEqual(_page.LastCommentText, comment);
            AreEqual(_page.LastAuthorText, Concat(name, "\r\n", email));
        }

    }
}
