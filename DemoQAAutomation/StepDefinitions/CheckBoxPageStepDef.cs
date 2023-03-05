using DemoQAAutomation.Pages;
using TechTalk.SpecFlow;

namespace DemoQAAutomation.StepDefinitions
{
    [Binding]
    public class CheckBoxPageStepDef
    {
        CheckBoxPage checkBoxPage;
        private ScenarioContext _scenarioContext;
        CheckBoxPageStepDef(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
            checkBoxPage = new CheckBoxPage(_scenarioContext);
        }


        [Then(@"User clicks on expand all button")]
        public void ThenUserClicksOnExpandAllButton()
        {
            checkBoxPage.ClickExpandAllButton();
        }

        [Then(@"User selects (.*) checkbox")]
        public void ThenUserSelectsCheckbox(string value)
        {
            checkBoxPage.ClickCheckBoxElement(value);
        }

        [Then(@"User validate the success message includes (.*)")]
        public void ThenUserValidateTheSuccessMessageIncludes(string value)
        {
            checkBoxPage.ValidatePostSubmissionData(value);
        }


    }
}
