    using DemoQAAutomation.Pages;
using TechTalk.SpecFlow;

namespace DemoQAAutomation.StepDefinitions
{
    [Binding]
    public class WidgetsPageStepDef
    {
        WidgetsPage widgetsPage;
        WidgetsPageStepDef()
        {
            widgetsPage = new WidgetsPage();
        }


        [When(@"User clicks on (.*) link on widgets page")]
        public void WhenUserClicksOnToolTipsLinkOnWidgetsPage(string value)
        {
            widgetsPage.ClickOnWidgetsPageLink(value);
        }

    }
}
