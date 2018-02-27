using System;
using System.Linq;
using System.Threading;
using NUnit.Framework;
using pure_selenium.Framework;
using pure_selenium.PageObjects;
using TechTalk.SpecFlow;

namespace pure_selenium.Steps
{
    using static Assert;
    using static StringAssert;
    using static String;
    using static BrowserTools;
   
    [Binding]
    public class HomePageSteps
    {
        private readonly Page _home = new Page();
        
        [When(@"I click the (.*) header link")]
        public void WhenIClickTheHeaderLink(string link)
        {
          _home.Header.ClickHeaderLink(link);
        }
        
        [Then(@"I am redirected to the /(.*) url")]
        public void ThenIAmRedirectedToTheUrl(string url)
        {
            Contains(url, CurrentUrl());
        }

        [Then(@"the page has correct (.*) title")]
        public void ThenThePageHasCorrectTitle(string title)
        {
            AreEqual(PageTitle(), title);
        }

        [Then(@"the following quote is shown on the main page:")]
        public void ThenTheFollowingQuoteIsShownOnTheMainPage(Table table)
        {
            Thread.Sleep(10000);
            AreEqual(Join(" ", table.Rows.Select(r => r[0])),
                 _home.Main.QuoteText);
        }
        
        [Then(@"social links have correct urls:")]
        public void ThenSocialLinksHaveCorrectUrls(Table table)
        {
            foreach (var row in table.Rows)
            {
                Contains(row[1],_home.Footer.SocialLink(row[0]));
           }
        }
        
        [Then(@"the copyright message is shown:")]
        public void ThenTheCopyrightMessageIsShown(Table table)
        {
            AreEqual(Join(" ", table.Rows.Select(r => r[0])),
                _home.Footer.Copyright());
        }

        [Given(@"I am on the (.*) page")]
        [When(@"I navigate to the (.*) page")]
        public void WhenINavigateToThePage(string page)
        {
            Visit(page);
        }

        [Then(@"I am redirected to the correct (.*) url")]
        public void ThenIAmRedirectedToTheCorrectUrl(string url)
        {
            Contains(url,CurrentUrl());
        }

    }
}
