using System;
using NUnit.Framework;
using pure_selenium.Framework;
using pure_selenium.PageObjects;
using TechTalk.SpecFlow;

namespace pure_selenium.Steps
{
    
    using static Assert;
    using static StringAssert;
    using static String;
    using static Browser;
    [Binding]
    public class FeedbackSteps
    {
        private string _name;
        private string _email;
        private string _comment;
        private readonly Page _home = new Page();
        
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
                _name = row[0];
                _email = row[1];
                _comment = row[2];
                _home.Main.FillInName(row[0]);
                _home.Main.FillInEmail(row[1]);
                _home.Main.FillInComment(row[2]);
            }
        }

        [Then(@"at least two items are shown in the feedback section")]
        public void ThenAtLeastTwoItemsAreShownInTheFeedbackSection()
        {
            IsTrue(_home.Main.Comments.Count >= 2);
        }

        [Then(@"the (.*) field shows the error message:")]
        public void ThenTheFieldShowsTheErrorMessage(string field, Table table)
        {
            foreach (var row in table.Rows)
            {
               AreEqual(_home.Main.ErrorMessageText(field),row[0]);
            }
        }

        [Then(@"the data is shown in the feedback section")]
        public void ThenTheDataIsShownInTheFeedbackSection()

        {
            AreEqual(_home.Main.LastCommentText, _comment);
            AreEqual(_home.Main.LastCommentAuthor,Concat(_name, "\r\n", _email));
        }
    }
}
