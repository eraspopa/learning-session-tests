using System;
using System.Linq;
using learning_pure.Framework;
using learning_pure.PageObjects;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace learning_pure.Steps
{
    
    using static Assert;
    using static StringAssert;
    using static String;
    using static Browser;
    [Binding]
    public class HomePageSteps
    {
        private Page home = new Page();
        
        [When(@"I click the (.*) header link")]
        public void WhenIClickTheHeaderLink(string link)
        {
          home.Header.ClickHeaderLink(link);
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
            AreEqual(Join(" ", table.Rows.Select(r => r[0])),
                home.Main.QuoteText());
        }
        
        [Then(@"social links have correct urls:")]
        public void ThenSocialLinksHaveCorrectUrls(Table table)
        {
            foreach (var row in table.Rows)
            {
                Contains(row[1],home.Footer.SocialLink(row[0]));
            }
        }
        
        [Then(@"the copyright message is shown:")]
        public void ThenTheCopyrightMessageIsShown(Table table)
        {
            AreEqual(Join(" ", table.Rows.Select(r => r[0])),
                home.Footer.Copyright());
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
