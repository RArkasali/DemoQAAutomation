    using DemoQAAutomation.Pages;
using TechTalk.SpecFlow;

namespace DemoQAAutomation.StepDefinitions
{
    [Binding]
    public class WindowsPageStepDef
    {
        WindowsPage windowsPage;
        WindowsPageStepDef()
        {
            windowsPage = new WindowsPage();
        }

        [Then(@"User clicks on (.*) button on windows page")]
        public void ThenUserClicksOnButtonOnWindowsPage(string value)
        {
            windowsPage.ClickWindowTab(value);
        }


        [Then(@"User verify the message as (.*) in new page and tab")]
        public void ThenUserVerifiesThe(string expectedValue)
        {
            windowsPage.ValidateSubmissionMessage(expectedValue);
        }


    }
}
