using pure_selenium.Framework;
using TechTalk.SpecFlow;

namespace pure_selenium.Steps
{
    using static BrowserTools;

    [Binding]
    public class CommonSteps
    {
        [BeforeFeature("default")]
        public static void BeforeFeature()
        {
            StartChrome();
        }

        [AfterFeature("default")]
        public static void AfterFeature()
        {
            Quit();
        }
    }
}