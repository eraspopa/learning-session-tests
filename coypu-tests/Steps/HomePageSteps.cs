using System;
using System.Linq;
using coypu_tests.PageObjects;
using coypu_tests.Tools;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;

namespace coypu_tests.Steps
{
    using static Assert;
    using static StringAssert;
    using static String;
   
    [Binding]
    public class HomePageSteps
    {
        private Page _home = new Page();
        [When(@"I click the (.*) header link")]
        public void WhenIClickTheHeaderLink(string link)
        {
           _home.Header.ClickHeaderLink(link);
        }
        
        [Then(@"the following quote is shown on the main page:")]
        public void ThenTheFollowingQuoteIsShownOnTheMainPage(Table table)
        {
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
               _home.Footer.CopyrightText);
        }
    }
}
