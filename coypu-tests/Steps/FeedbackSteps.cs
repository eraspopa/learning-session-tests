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
    public class FeedbackSteps
    {
        private string name;
        private string email;
        private string comment;
        Page _home = new Page();

        [When(@"click the grey navigation (.*) link")]
        public void WhenClickTheGreyNavigationLink(string link)
        {
            _home.Main.ClickFeedbackLink(link);
        }

        [When(@"I click the (.*) button")]
        public void WhenIClickTheButton(string button)
        {
            _home.Main.ClickButton(button);
        }

        [When(@"fill in following values:")]
        public void WhenFillInFollowingValues(Table table)
        {
            foreach (var row in table.Rows)
            {
                name = row[0];email = row[1];comment = row[2];
                _home.Main.LeaveComment(row[0], row[1],row[2]);
            }
        }

        [Then(@"at least two items are shown in the feedback section")]
        public void ThenAtLeastTwoItemsAreShownInTheFeedbackSection()
        {
           IsTrue(_home.Main.NumberOfComments >= 2);
        }

        [Then(@"the (.*) field shows the error message:")]
        public void ThenTheFieldShowsTheErrorMessage(string field, Table table)
        {
            foreach (var row in table.Rows)
            {
               AreEqual(_home.Main.ErrorMessage(field),row[0]);
            }
        }

        [Then(@"the data is shown in the feedback section")]
        public void ThenTheDataIsShownInTheFeedbackSection()
        {
            AreEqual(_home.Main.LastComment, comment);
            AreEqual(_home.Main.LastCommentAuthor,Concat(name, "\r\n", email));
        }
    }
}
