    using DemoQAAutomation.Pages;
using TechTalk.SpecFlow;

namespace DemoQAAutomation.StepDefinitions
{
    [Binding]
    public class ToolTipsPageStepDef
    {
        ToolTipsPage toolTipsPage;
        ToolTipsPageStepDef()
        {
            toolTipsPage = new ToolTipsPage();
        }


        [Then(@"User mouse hover the (.*)")]
        public void ThenUserMouseHoverThe(string value)
        {
            toolTipsPage.MouseHoverContext(value);
        }

        [Then(@"User verify mouse hover message as (.*)")]
        public void ThenUserVerifyMouseHoverMessageAs(string expectedValue)
        {
            toolTipsPage.ValidateSubmissionMessage(expectedValue);
        }

    }
}
