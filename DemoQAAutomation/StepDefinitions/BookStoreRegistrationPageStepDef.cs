    using DemoQAAutomation.Pages;
using TechTalk.SpecFlow;

namespace DemoQAAutomation.StepDefinitions
{
    [Binding]
    public class BookStoreRegistrationPageStepDef
    {
        BookStoreRegistrationPage bookStoreRegistrationPage;
        BookStoreRegistrationPageStepDef(ScenarioContext scenarioContext)
        {
            bookStoreRegistrationPage = new BookStoreRegistrationPage(scenarioContext);
        }

        [Then(@"User enter the (.*) in textbox for registration page")]
        public void ThenUserEnterTheInTextboxForRegistrationPage(string value)
        {
            bookStoreRegistrationPage.EnterRegistrationDetails(value);
        }

        [Then(@"User clicks on captcha button")]
        public void ThenUserClicksOnCaptchaButton()
        {
            bookStoreRegistrationPage.ClickCapchtaButton();
        }

        [Then(@"User clicks on registraion button")]
        public void ThenUserClicksOnRegistraionButton()
        {
            bookStoreRegistrationPage.ClickRegistrationButton();
        }

        [Then(@"User verfies the registration message (.*)")]
        public void ThenUserVerfiesTheRegistrationMessage(string value)
        {
            bookStoreRegistrationPage.ValidatePostSubmissionData(value);
        }

        [Then(@"User clicks on login back button")]
        public void ThenUserClicksOnLoginBackButton()
        {
            bookStoreRegistrationPage.ClickGoBackToLoginButton();
        }



    }
}
