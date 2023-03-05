    using DemoQAAutomation.Pages;
using TechTalk.SpecFlow;

namespace DemoQAAutomation.StepDefinitions
{
    [Binding]
    public class BookStorePageStepDef
    {
        BookStorePage bookStorePage;
        BookStorePageStepDef()
        {
            bookStorePage = new BookStorePage();
        }

        [When(@"User clicks on (.*) link on book store application page")]
        public void WhenUserClicksOnLoginLinkOnBookStoreApplicationPage(string value)
        {
            bookStorePage.ClickOnBookStorePageLink(value);
        }

    }
}
