using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using page_factory2.PageObjects;
using page_factory2.Tools;
using TechTalk.SpecFlow;

namespace page_factory2.Steps
{
    using static Browser;
    using static Assert;
    using static String;
    [Binding]
    public class FeedbackSteps
    {
        private string name;
        private string email;
        private string comment;
        public static HomePage Home = new HomePage(Driver);
        [When(@"click the grey navigation (.*) link")]
        public void WhenClickTheGreyNavigationLink(string link)
        {
            Home.Main.ClickFeedbackLink(link);
        }

        [When(@"I click the (.*) button")]
        public void WhenIClickTheButton(string button)
        {
            Home.Main.ClickButton();
        }

        [When(@"fill in following values:")]
        public void WhenFillInFollowingValues(Table table)
        {
            foreach (var row in table.Rows)
            {
                name = row[0];
                email = row[1];
                comment = row[2];
                Home.Main.LeaveComment(row[0], row[1], row[2]);
            }
        }

        [Then(@"at least two items are shown in the feedback section")]
        public void ThenAtLeastTwoItemsAreShownInTheFeedbackSection()
        {
            IsTrue(Home.Main.NumberOfComments >= 2);
        }

        [Then(@"the (.*) field shows the error message:")]
        public void ThenTheFieldShowsTheErrorMessage(string field, Table table)
        {
            foreach (var row in table.Rows)
            {
                AreEqual(Home.Main.WarningText(field), row[0]);
            }
        }

        [Then(@"the data is shown in the feedback section")]
        public void ThenTheDataIsShownInTheFeedbackSection()
        {
            AreEqual(Home.Main.LatestCommentText, comment);
            AreEqual(Home.Main.LatestCommentAuthorText, Concat(name, "\r\n", email));
        }
    }
}
