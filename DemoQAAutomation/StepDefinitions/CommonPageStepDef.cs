using DemoQAAutomation.Pages;
using TechTalk.SpecFlow;

namespace DemoQAAutomation.StepDefinitions
{
    [Binding]
    public class CommonPageStepDef
    {
        CommonPage commonPage;

        CommonPageStepDef()
        {
            commonPage = new CommonPage();
        }

        [Then(@"User validate navigation goes to (.*) page")]
        public void ThenUserValidateNavigationGoesToTextBoxPage(string expectedValue)
        {
            commonPage.ValidateNavigationIsOnCallingPage(expectedValue);
        }

        [Then(@"User refresh the page")]
        public void ThenUserRefreshThePage()
        {
            commonPage.RefreshPage();
        }

        [Then(@"User waits for (.*) seconds")]
        public void ThenUserWaitsForSeconds(int value)
        {
            commonPage.StaticWebWait(value);
        }


    }
}
