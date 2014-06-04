using TechTalk.SpecFlow;

namespace SpecFlowPlayground
{
    [Binding]
    public class StepDefinitions
    {
        [Given(@"a user '(.*)' is logged in")]
        public void GivenAUserIsLoggedIn(string username)
        {
            ScenarioContext.Current.Pending();
        }
    }
}