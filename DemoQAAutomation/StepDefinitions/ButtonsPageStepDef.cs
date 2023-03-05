    using DemoQAAutomation.Pages;
using TechTalk.SpecFlow;

namespace DemoQAAutomation.StepDefinitions
{
    [Binding]
    public class ButtonsPageStepDef
    {
        ButtonPage buttonsPage;
        ButtonsPageStepDef()
        {
            buttonsPage = new ButtonPage();
        }

        [When(@"User click on (.*)")]
        public void WhenUserClicksOn(string value)
        {
            buttonsPage.ClickButtonOnButtonsPage(value);
        }

        [Then(@"User verify the (.*) message as (.*)")]
        public void ThenUserVerifyTheMessageAs(string value, string expectedValue)
        {
            buttonsPage.ValidatePostSubmissionData(value, expectedValue);
        }

    }
}
