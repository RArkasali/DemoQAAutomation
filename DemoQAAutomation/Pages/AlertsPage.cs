using DemoQAAutomation.Utils;
using NUnit.Framework;
using OpenQA.Selenium;
using System.Threading;
using TechTalk.SpecFlow;

namespace DemoQAAutomation.Pages
{
    class AlertsPage : SeleniumWrapper
    {
        private By AlertButton => By.Id("alertButton");
        private By TimeAlertButton => By.Id("timerAlertButton");
        private By ConfirmAlertButton => By.Id("confirmButton");
        private By PromptAlertButton => By.Id("promtButton");
        private By ConfirmResultAlertButton => By.Id("confirmResult");
        private By PromptResultAlertButton => By.Id("promptResult");
        private ScenarioContext _scenarioContext;
        public AlertsPage(ScenarioContext scenarioContext)
        {
            StaticWebWait(2);
            _scenarioContext = scenarioContext;
        }

        public void ClickOnAlertButton()
        {
            IsElementVisible(AlertButton);
            JSClickElement(AlertButton);
        }

        public void ClickOnTimeAlertButton()
        {
            IsElementVisible(TimeAlertButton);
            JSClickElement(TimeAlertButton);
        }

        public void ClickOnConfirmAlertButton()
        {
            IsElementVisible(ConfirmAlertButton);
            JSClickElement(ConfirmAlertButton);
        }

        public void ClickOnPromptAlertButton()
        {
            IsElementVisible(PromptAlertButton);
            JSClickElement(PromptAlertButton);
        }

        public void ClickAlertPopUpButton(string value)
        {
            if (value.ToLower().Equals("accept"))
                AcceptAlertPopUp();
            else
                DismissAlertPopUp();
        }

        public void ValidateAlertPopUpMessage(string value)
        {
            string actualValue = GetAlertText();
            Assert.AreEqual(value, actualValue, $" actual value : {actualValue}, does not match with expected value : {value}");
            AcceptAlertPopUp();
        }
        public void ValidatePopUpMessage(string value)
        {
            string actualValue = "";
            if (value.ToLower().Contains("ok"))
            {
                actualValue = GetText(ConfirmResultAlertButton);
                Assert.AreEqual(value.Trim(), actualValue.Trim(), $" actual value : {actualValue}, does not match with expected value : {value}");
            }
            else if (value.ToLower().Contains("cancel"))
            {
                actualValue = GetText(ConfirmResultAlertButton);
                Assert.AreEqual(value.Trim(), actualValue.Trim(), $" actual value : {actualValue}, does not match with expected value : {value}");
            }   
            else
            {
                actualValue = GetText(PromptResultAlertButton);
                Assert.AreEqual(value.Trim() + " " + (string)_scenarioContext["Name"], actualValue.Trim(), $" actual value : {actualValue}, does not match with expected value : {value}");
            }
           
        }

        public void SendValueInAlert()
        {
            _scenarioContext["Name"] = Faker.Name.First();
            SendkeysAlertPopUp((string)_scenarioContext["Name"]);
            AcceptAlertPopUp();
        }

    }
}
