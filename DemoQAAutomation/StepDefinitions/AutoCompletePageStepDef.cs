using DemoQAAutomation.Pages;
using TechTalk.SpecFlow;

namespace DemoQAAutomation.StepDefinitions
{
    [Binding]
    public class AutoCompletePageStepDef
    {
        AutoCompletePage autoCompletePage;
        AutoCompletePageStepDef()
        {
            autoCompletePage = new AutoCompletePage();
        }


        [Then(@"User selects (.*) for (.*) value text field")]
        public void ThenUserSelectsForValueTextField(string data, string value)
        {
            autoCompletePage.SelectColorFromTextField(value, data);
        }

        [Then(@"User verfies value of (.*) for (.*) text field")]
        public void ThenUserVerfiesValueOfForTextField(string data, string value)
        {
            autoCompletePage.ValidateSubmissionData(value,data);
        }


    }
}
