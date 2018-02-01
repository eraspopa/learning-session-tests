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
using TechTalk.SpecFlow;

namespace learning_pure.Steps
{
    using static Assert;
    using static StringAssert;
    using static String;
    using static ScenarioContext;
    using static TestContext;

    [Binding]
    public class HomePageSteps
    {
        private static IWebDriver _webDriver;
        public const string BaseUrl = "http://lizas-test-site.gear.host";
        private string name;
        private string email;
        private string comment;
        [BeforeFeature()]
        public static void BeforeFeature()
        {
            _webDriver = new ChromeDriver();
        }

        [AfterFeature()]
        public static void AfterFeature()
        {
            _webDriver.Quit();
        }

        public static void SaveToContext(string data, string key)
        {
            WriteLine(key);
            WriteLine(data);
            Current.Set(data, key);
        }

        [When(@"I click the (.*) header link")]
        public void WhenIClickTheHeaderLink(string link)
        {
           _webDriver.FindElement(By.XPath($"//nav[@class='site-navigation']//a[.='{link}']")).Click();
        }
        
        [Then(@"I am redirected to the /(.*) url")]
        public void ThenIAmRedirectedToTheUrl(string url)
        {
            Contains(url, _webDriver.Url);
        }

        [Then(@"the page has correct (.*) title")]
        public void ThenThePageHasCorrectTitle(string title)
        {
            AreEqual(_webDriver.Title, title);
        }

        [Then(@"the following quote is shown on the main page:")]
        public void ThenTheFollowingQuoteIsShownOnTheMainPage(Table table)
        {
            AreEqual(Join(" ", table.Rows.Select(r => r[0])),
                _webDriver.FindElement(By.CssSelector(".site-content q")).Text);
        }
        
        [Then(@"social links have correct urls:")]
        public void ThenSocialLinksHaveCorrectUrls(Table table)
        {
            foreach (var row in table.Rows)
            {
                Contains(row[1],_webDriver.FindElement(By.XPath($"//a[i[contains(@class,'fa-{row[0]}')]]")).GetAttribute("href"));
            }
            
        }
        
        [Then(@"the copyright message is shown:")]
        public void ThenTheCopyrightMessageIsShown(Table table)
        {
            AreEqual(Join(" ", table.Rows.Select(r => r[0])),
                _webDriver.FindElement(By.CssSelector(".site-footer p")).Text);
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
            _webDriver.FindElement(By.XPath($"//p[@class='thank'][.='{link}']")).Click();
        }

        [When(@"I click the (.*) button")]
        public void WhenIClickTheButton(string button)
        {
            _webDriver.FindElement(By.XPath($"//input[@value='{button}']")).Click();
        }

        [When(@"fill in following values:")]
        public void WhenFillInFollowingValues(Table table)
        {
            foreach (var row in table.Rows)
            {
                name = row[0];
                email = row[1];
                comment = row[2];
                _webDriver.FindElement(By.CssSelector("input#Name")).SendKeys(row[0]);
                _webDriver.FindElement(By.CssSelector("input#Email")).SendKeys(row[1]);
                _webDriver.FindElement(By.CssSelector("input#Comment")).SendKeys(row[2]);
            }
        }

        [Then(@"at least two items are shown in the feedback section")]
        public void ThenAtLeastTwoItemsAreShownInTheFeedbackSection()
        {
            IsTrue(_webDriver.FindElements(By.CssSelector("blockquote")).Count >= 2);
        }

        [Then(@"the (.*) field shows the error message:")]
        public void ThenTheFieldShowsTheErrorMessage(string field, Table table)
        {
            foreach (var row in table.Rows)
            {
               AreEqual(_webDriver.FindElement(By.XPath($"//span[contains(@class,'text-danger')]/span[@for='{field}']")).Text,row[0]);
            }
            
        }

        [Then(@"the data is shown in the feedback section")]
        public void ThenTheDataIsShownInTheFeedbackSection()

        {
            SaveToContext(_webDriver.FindElement(By.CssSelector(".container blockquote:last-child p")).Text,"test");
            AreEqual(_webDriver.FindElement(By.CssSelector(".container blockquote:last-child p")).Text, comment);
            AreEqual(_webDriver.FindElement(By.CssSelector(".container blockquote:last-child cite")).Text,Concat(name, "\r\n", email));
        }

        [Then(@"I am redirected to the correct (.*) url")]
        public void ThenIAmRedirectedToTheCorrectUrl(string url)
        {
            Contains(url,_webDriver.Url);
        }

    }
}
