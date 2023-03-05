using DemoQAAutomation.Pages;
using TechTalk.SpecFlow;

namespace DemoQAAutomation.StepDefinitions
{
    [Binding]
    public class ElementsPageStepDef
    {
        ElementsPage elementsPage;

        ElementsPageStepDef()
        {
            elementsPage = new ElementsPage();
        }

        [When(@"User clicks on (.*) link on Elements page")]
        public void GivenUserClicksOnLinkOnElementsPage(string value)
        {
            elementsPage.ClickOnElementsPageLink(value);
        }


    }
}
