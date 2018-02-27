﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.3.0.0
//      SpecFlow Generator Version:2.3.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace page_factory2.Features
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.3.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Feedback")]
    public partial class FeedbackFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "Feedback.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Feedback", null, ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.OneTimeTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public virtual void TestInitialize()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        public virtual void FeatureBackground()
        {
#line 3
#line 4
   testRunner.Given("I am on the /Feedback page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("The feedback links navigate to the correct pages")]
        [NUnit.Framework.TestCaseAttribute("Feedback", "Create New", "Feedback/Create", null)]
        [NUnit.Framework.TestCaseAttribute("Feedback/Create", "Back to List", "Feedback", null)]
        public virtual void TheFeedbackLinksNavigateToTheCorrectPages(string page, string link, string url, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("The feedback links navigate to the correct pages", exampleTags);
#line 6
this.ScenarioSetup(scenarioInfo);
#line 3
this.FeatureBackground();
#line 7
   testRunner.When(string.Format("I navigate to the /{0} page", page), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 8
   testRunner.And(string.Format("click the grey navigation {0} link", link), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 9
   testRunner.Then(string.Format("I am redirected to the correct /{0} url", url), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("The feedbacks are shown in the feedback section")]
        public virtual void TheFeedbacksAreShownInTheFeedbackSection()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("The feedbacks are shown in the feedback section", ((string[])(null)));
#line 15
this.ScenarioSetup(scenarioInfo);
#line 3
this.FeatureBackground();
#line 16
   testRunner.Then("at least two items are shown in the feedback section", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("The required field message is shown when trying to submit the empty form")]
        public virtual void TheRequiredFieldMessageIsShownWhenTryingToSubmitTheEmptyForm()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("The required field message is shown when trying to submit the empty form", ((string[])(null)));
#line 18
this.ScenarioSetup(scenarioInfo);
#line 3
this.FeatureBackground();
#line 19
   testRunner.When("I navigate to the /Feedback/Create page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 20
   testRunner.And("I click the Send a message button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "message"});
            table1.AddRow(new string[] {
                        "The name is required."});
#line 21
   testRunner.Then("the Name field shows the error message:", ((string)(null)), table1, "Then ");
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "message"});
            table2.AddRow(new string[] {
                        "The comment is required."});
#line 24
   testRunner.And("the Comment field shows the error message:", ((string)(null)), table2, "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("The invalid email field message is shown when trying to submit incorrect email va" +
            "lue")]
        public virtual void TheInvalidEmailFieldMessageIsShownWhenTryingToSubmitIncorrectEmailValue()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("The invalid email field message is shown when trying to submit incorrect email va" +
                    "lue", ((string[])(null)));
#line 28
this.ScenarioSetup(scenarioInfo);
#line 3
this.FeatureBackground();
#line 29
   testRunner.When("I navigate to the /Feedback/Create page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "name",
                        "email",
                        "comment"});
            table3.AddRow(new string[] {
                        "test",
                        "test",
                        "test"});
#line 30
   testRunner.And("fill in following values:", ((string)(null)), table3, "And ");
#line 33
   testRunner.And("I click the Send a message button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "message"});
            table4.AddRow(new string[] {
                        "Invalid email address."});
#line 34
   testRunner.Then("the Email field shows the error message:", ((string)(null)), table4, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("The correct values are submited and displayed on the feedback page")]
        public virtual void TheCorrectValuesAreSubmitedAndDisplayedOnTheFeedbackPage()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("The correct values are submited and displayed on the feedback page", ((string[])(null)));
#line 38
this.ScenarioSetup(scenarioInfo);
#line 3
this.FeatureBackground();
#line 39
   testRunner.When("I navigate to the /Feedback/Create page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                        "name",
                        "email",
                        "comment"});
            table5.AddRow(new string[] {
                        "test",
                        "test@example.com",
                        "test"});
#line 40
   testRunner.And("fill in following values:", ((string)(null)), table5, "And ");
#line 43
   testRunner.And("I click the Send a message button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 44
   testRunner.Then("I am redirected to the /Feedback url", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 45
   testRunner.And("the data is shown in the feedback section", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
