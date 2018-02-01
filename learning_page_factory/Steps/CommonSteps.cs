using learning_pure.Framework;
using TechTalk.SpecFlow;

namespace learning_pure.Steps
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