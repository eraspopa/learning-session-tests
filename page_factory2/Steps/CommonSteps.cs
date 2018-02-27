using NUnit.Framework;
using page_factory2.PageObjects;
using page_factory2.Tools;
using TechTalk.SpecFlow;

namespace page_factory2.Steps
{
    using static Assert;
    using static StringAssert;
    using static BrowserTools;
    [Binding]
    public class CommonSteps
    {
        public static HomePage Home;
        [BeforeFeature()]
        public static void BeforeFeature()
        {
            LaunchChrome();
        }

        [AfterFeature()]
        public static void AfterFeature()
        {
            Quit();
        }

        [Given(@"I am on the (.*) page")]
        [When(@"I navigate to the (.*) page")]
        public void WhenINavigateToThePage(string page)
        {
            Visit(page);
        }

        [Then(@"I am redirected to the correct (.*) url")]
        [Then(@"I am redirected to the /(.*) url")]
        public void ThenIAmRedirectedToTheUrl(string url)
        {
            Contains(url, CurrentUrl());
        }

        [Then(@"the page has correct (.*) title")]
        public void ThenThePageHasCorrectTitle(string title)
        {
            AreEqual(title, PageTitle());
        }
    }
}
