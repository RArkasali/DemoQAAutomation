    using DemoQAAutomation.Pages;
using TechTalk.SpecFlow;

namespace DemoQAAutomation.StepDefinitions
{
    [Binding]
    public class InteractionsPageStepDef
    {
        InteractionsPage interactionsPage;
        InteractionsPageStepDef()
        {
            interactionsPage = new InteractionsPage();
        }

        [When(@"User clicks on (.*) link on interactions page")]
        public void WhenUserClicksOnLoginLinkOnBookStoreApplicationPage(string value)
        {
            interactionsPage.ClickOnInteractionsPageLink(value);
        }

    }
}
