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
using page_factory2.Tools;
using TechTalk.SpecFlow;

namespace page_factory2.Steps
{
    using static Assert;
    using static StringAssert;
    using static String;
    using static Browser;
    using static BrowserTools;
   
    [Binding]
    public class HomePageSteps
    {
        public static HomePage Home = new HomePage(Driver);
        
        [When(@"I click the (.*) header link")]
        public void WhenIClickTheHeaderLink(string link)
        {
            Home.Header.ClickNavLink(link); 
        }
        
        [Then(@"the following quote is shown on the main page:")]
        public void ThenTheFollowingQuoteIsShownOnTheMainPage(Table table)
        {
            AreEqual(Join(" ", table.Rows.Select(r => r[0])),
                Home.Main.QuoteMessageText);
        }

        [When(@"I click the (.*) social icon")]
        public void WhenIClickTheSocialIcon(string icon)
        {
            Home.Footer.ClickSocialIcon(icon);
        }

        [Then(@"the copyright message is shown:")]
        public void ThenTheCopyrightMessageIsShown(Table table)
        {
            AreEqual(Join(" ", table.Rows.Select(r => r[0])),
                Home.Footer.CopyrightMessageText);
        }

        
    }
}
