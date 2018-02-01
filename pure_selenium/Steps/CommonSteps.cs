using pure_selenium.Framework;
using TechTalk.SpecFlow;

namespace pure_selenium.Steps
{
    using static Browser;

    [Binding]
    public class CommonSteps
    {
        [BeforeFeature]
        public static void BeforeFeature()
        {
            Start();
        }

        [AfterFeature]
        public static void AfterFeature()
        {
            Quit();
        }
    }
}