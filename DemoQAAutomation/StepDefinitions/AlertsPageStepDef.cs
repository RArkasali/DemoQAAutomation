using DemoQAAutomation.Pages;
using TechTalk.SpecFlow;

namespace DemoQAAutomation.StepDefinitions
{
    [Binding]
    public class AlertsPageStepDef
    {
        AlertsPage alertsPage;
        AlertsPageStepDef(ScenarioContext scenarioContext)
        {
            alertsPage = new AlertsPage(scenarioContext);
        }

        [Then(@"User clicks on see alert button")]
        public void ThenUserClicksOnSeeAlertButton()
        {
            alertsPage.ClickOnAlertButton();   
        }

        [Then(@"User verify the pop up message for alert as (.*)")]
        public void ThenUserVerifyThePopUpMessageForAlertAs(string expectedValue)
        {
            alertsPage.ValidateAlertPopUpMessage(expectedValue);
        }

        [Then(@"User clicks on see alert button for appear after 5 seconds")]
        public void ThenUserClicksOnSeeAlertButtonForAppearAfterSeconds()
        {
            alertsPage.ClickOnTimeAlertButton();
        }

        [Then(@"User clicks on comfirm box alert pop up")]
        public void ThenUserClicksOnComfirmBoxAlertPopUp()
        {
            alertsPage.ClickOnConfirmAlertButton();
        }

        [Then(@"User (.*) the alert")]
        public void ThenUserAccpetsTheAlert(string value)
        {
            alertsPage.ClickAlertPopUpButton(value);
        }

        [Then(@"User verifies the (.*)")]
        public void ThenUserVerifiesThe(string expectedValue)
        {
            alertsPage.ValidatePopUpMessage(expectedValue);
        }

       
        [Then(@"User clicks on prompt box alert pop up")]
        public void ThenUserClicksOnPromptBoxAlertPopUp()
        {
            alertsPage.ClickOnPromptAlertButton();
        }

        [Then(@"User enter the data in pop up alert")]
        public void ThenUserEnterTheDataInPopUpAlert()
        {
            alertsPage.SendValueInAlert();
        }




    }
}
