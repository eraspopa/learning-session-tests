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
namespace page_factory.Features
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.3.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("HomePage")]
    public partial class HomePageFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "HomePage.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "HomePage", null, ProgrammingLanguage.CSharp, ((string[])(null)));
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
   testRunner.Given("I am on the / page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("The header links navigate to the correct pages")]
        [NUnit.Framework.TestCaseAttribute("About", "Home/About", null)]
        [NUnit.Framework.TestCaseAttribute("Contact", "Feedback", null)]
        public virtual void TheHeaderLinksNavigateToTheCorrectPages(string link, string url, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("The header links navigate to the correct pages", exampleTags);
#line 6
this.ScenarioSetup(scenarioInfo);
#line 3
this.FeatureBackground();
#line 7
   testRunner.When(string.Format("I click the {0} header link", link), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 8
   testRunner.Then(string.Format("I am redirected to the /{0} url", url), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 9
   testRunner.And(string.Format("the page has correct {0} – Daehyun Kim title", link), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("The artist\'s quote is shown on the home page")]
        public virtual void TheArtistsQuoteIsShownOnTheHomePage()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("The artist\'s quote is shown on the home page", ((string[])(null)));
#line 15
this.ScenarioSetup(scenarioInfo);
#line 3
this.FeatureBackground();
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "quote"});
            table1.AddRow(new string[] {
                        "If the artist can disappear and hide well,"});
            table1.AddRow(new string[] {
                        "people find meaningful and important something from the work."});
            table1.AddRow(new string[] {
                        "I don\'t want to disturb the process."});
#line 16
   testRunner.Then("the following quote is shown on the main page:", ((string)(null)), table1, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("The copyright message is shown on the footer")]
        public virtual void TheCopyrightMessageIsShownOnTheFooter()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("The copyright message is shown on the footer", ((string[])(null)));
#line 22
this.ScenarioSetup(scenarioInfo);
#line 3
this.FeatureBackground();
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "message"});
            table2.AddRow(new string[] {
                        "Copyright © Your Website 2017"});
#line 23
   testRunner.Then("the copyright message is shown:", ((string)(null)), table2, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Social link navigates to the correct url")]
        [NUnit.Framework.TestCaseAttribute("facebook", "facebook.com/daehyun.kim/", null)]
        [NUnit.Framework.TestCaseAttribute("pinterest", "pinterest.com/pin/102245854017904870/?lp=true", null)]
        [NUnit.Framework.TestCaseAttribute("instagram", "instagram.com/explore/tags/moonassi/", null)]
        public virtual void SocialLinkNavigatesToTheCorrectUrl(string icon, string url, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Social link navigates to the correct url", exampleTags);
#line 27
this.ScenarioSetup(scenarioInfo);
#line 3
this.FeatureBackground();
#line 28
   testRunner.When(string.Format("I click the {0} social icon", icon), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 29
   testRunner.Then(string.Format("I am redirected to the /{0} url", url), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
