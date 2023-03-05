using DemoQAAutomation.Pages;
using TechTalk.SpecFlow;

namespace DemoQAAutomation.StepDefinitions
{
    [Binding]
    public class TextBoxPageStepDef
    {
        TextBoxPage textboxPage;
        private ScenarioContext _scenarioContext;
        TextBoxPageStepDef(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
            textboxPage = new TextBoxPage(_scenarioContext);
        }


        [Then(@"User enter the full name in textbox")]
        public void ThenUserEnterTheFullNameInTextbox()
        {
            textboxPage.EnterFullName();
        }

        [Then(@"User enter the email address in textbox")]
        public void ThenUserEnterTheEmailAddressInTextbox()
        {
            textboxPage.EnterEmail();
        }

        [Then(@"User enter the current address in textbox")]
        public void ThenUserEnterTheCurrentAddressInTextbox()
        {
            textboxPage.EnterCurrentAddress();
        }

        [Then(@"User enter the permanent address in textbox")]
        public void ThenUserEnterThePermanentAddressInTextbox()
        {
            textboxPage.EnterPermanentAddress();
        }

        [When(@"User clicks on submit button")]
        public void WhenUserClicksOnSubmitButton()
        {
            textboxPage.ClickSubmitButton();
        }

        [Then(@"User verify the details post submission")]
        public void ThenUserVerifyTheDetailsPostSubmission()
        {
            textboxPage.ValidatePostSubmissionData();
        }


    }
}
