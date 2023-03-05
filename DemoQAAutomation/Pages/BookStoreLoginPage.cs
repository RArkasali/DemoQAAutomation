using DemoQAAutomation.Utils;
using NUnit.Framework;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace DemoQAAutomation.Pages
{
    class BookStoreLoginPage : SeleniumWrapper
    {
        private By NewUserButton => By.Id("newUser");
        private By UserNameTextBox => By.Id("userName");
        private By PasswordTextBox => By.Id("password");
        private By LoginButton => By.Id("login");
        private By LogoutButton => By.XPath("//button[text()='Log out']");

        private ScenarioContext _scenarioContext;
        public BookStoreLoginPage(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        public void ClickNewUserButton()
        {
            StaticWebWait(2);
            IsElementVisible(NewUserButton);
            JSClickElement(NewUserButton);
        }

        public void EnterLoginDetails(string value)
        {
            StaticWebWait(2);
            switch (value)
            {
               
              case "Username":
                    IsElementVisible(UserNameTextBox);
                    SendKeys(UserNameTextBox, (string)_scenarioContext["UserName"]);
                    break;
              case "Password":
                    IsElementVisible(PasswordTextBox);
                    SendKeys(PasswordTextBox, (string)_scenarioContext["Password"]);
                    break;
            }
        }

        public void ClickLoginButton()
        {
            IsElementVisible(LoginButton);
            ClickElement(LoginButton);
        }

        public void ValidatePostSubmissionData(string expectedValue)
        {
            IsElementVisible(LogoutButton);
            var actualValue = GetText(LoginButton);
            Assert.AreEqual(expectedValue, actualValue, $" actual value : {actualValue}, does not match with expected value : {expectedValue}");
        }

    }


}
