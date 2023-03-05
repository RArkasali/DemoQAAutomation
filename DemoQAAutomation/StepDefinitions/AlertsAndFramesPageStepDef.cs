    using DemoQAAutomation.Pages;
using TechTalk.SpecFlow;

namespace DemoQAAutomation.StepDefinitions
{
    [Binding]
    public class AlertsAndFramesPageStepDef
    {
        AlertAndFramePage alertAndFramePage;
        AlertsAndFramesPageStepDef()
        {
            alertAndFramePage = new AlertAndFramePage();
        }

        [When(@"User clicks on (.*) link on alerts and frames page")]
        public void WhenUserClicksOnAlertsLinkOnAlertsAndFramesPage(string value)
        {
            alertAndFramePage.ClickOnAlertsAndFramesPageLink(value);
        }

    }
}
