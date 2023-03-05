    using DemoQAAutomation.Pages;
using TechTalk.SpecFlow;

namespace DemoQAAutomation.StepDefinitions
{
    [Binding]
    public class BookStoreLoginPageStepDef
    {
        BookStoreLoginPage bookStoreLoginPage;
        BookStoreLoginPageStepDef(ScenarioContext scenarioContext)
        {
            bookStoreLoginPage = new BookStoreLoginPage(scenarioContext);
        }

        [Then(@"User clicks on new user button")]
        public void ThenUserClicksOnNewUserButton()
        {
            bookStoreLoginPage.ClickNewUserButton();
        }


        [Then(@"User enter the (.*) in textbox for login page")]
        public void ThenUserEnterTheInTextboxForLoginPage(string value)
        {
            bookStoreLoginPage.EnterLoginDetails(value);
        }

        [Then(@"User clicks on login button")]
        public void ThenUserClicksOnLoginButton()
        {
            bookStoreLoginPage.ClickLoginButton();
        }

        [Then(@"User verfies the login message (.*)")]
        public void ThenUserVerfiesTheLoginMessage(string value)
        {
            bookStoreLoginPage.ValidatePostSubmissionData(value);
        }


    }
}
