using DemoQAAutomation.Pages;
using TechTalk.SpecFlow;

namespace DemoQAAutomation.StepDefinitions
{
    [Binding]
    public class HomePageStepDef
    {
        HomePage homePage;

        HomePageStepDef()
        {
            homePage = new HomePage();
        }

        [Given(@"User navigate the application")]
        public void GivenUserNavigateTheApplication()
        {
            homePage.NaviagteToTheApplication();
        }

        [Given(@"User clicks on (.*) link")]
        public void GivenUserClicksOnLink(string value)
        {
            homePage.ClickOnLink(value);
        }


    }
}
