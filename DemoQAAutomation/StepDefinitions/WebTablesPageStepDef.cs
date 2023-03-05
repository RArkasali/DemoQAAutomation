using DemoQAAutomation.Pages;
using TechTalk.SpecFlow;

namespace DemoQAAutomation.StepDefinitions
{
    [Binding]
    public class WebTablesPageStepDef
    {
        WebTablesPage webTablesPage;
        WebTablesPageStepDef(ScenarioContext scenarioContext)
        {
            webTablesPage = new WebTablesPage(scenarioContext);
        }

        [Then(@"User clicks on edit link")]
        public void ThenUserClicksOnEditLink()
        {
            webTablesPage.ClickOnEditLink();
        }

        [When(@"User update the first name for the record")]
        public void WhenUserUpdateTheFirstNameForTheRecord()
        {
            webTablesPage.RenameFirstName();
        }

        [Then(@"User validate the first name in the web table")]
        public void ThenUserValidateTheFirstNameInTheWebTable()
        {
            webTablesPage.ValidatePostSubmissionData();
        }


    }
}
