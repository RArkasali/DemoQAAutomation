
using DemoQAAutomation.Utils;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using TechTalk.SpecFlow;

namespace DemoQAAutomation.Pages
{
    class BookStoreRegistrationPage : SeleniumWrapper
    {
        private By FirstNameTextBox => By.Id("firstname");
        private By LastNametTextBox => By.Id("lastname");
        private By UserNameTextBox => By.Id("userName");
        private By PasswordTextBox => By.Id("password");
        private By CaptchaButton => By.XPath("//div[@class='rc-anchor-center-container']");
        private By RegistrationButton => By.Id("register");
        private By GoToLoginButton => By.Id("gotologin");

        private ScenarioContext _scenarioContext;
        public BookStoreRegistrationPage(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        public void EnterRegistrationDetails(string value)
        {
            StaticWebWait(2);
            switch (value)
            {
                case "FirstName":
                    IsElementVisible(FirstNameTextBox);
                    _scenarioContext["FirstName"] = Faker.Name.First();
                    SendKeys(FirstNameTextBox,(string)_scenarioContext["FirstName"]);
                    break;
                case "LastName":
                    IsElementVisible(LastNametTextBox);
                    _scenarioContext["LastName"] = Faker.Name.Last();
                    SendKeys(LastNametTextBox, (string)_scenarioContext["LastName"]);
                    break;
                case "UserName":
                    IsElementVisible(UserNameTextBox);
                    _scenarioContext["UserName"] = (string)_scenarioContext["FirstName"] + (string)_scenarioContext["LastName"];
                    SendKeys(UserNameTextBox, (string)_scenarioContext["UserName"]);
                    break;
                case "Password":
                    IsElementVisible(PasswordTextBox);
                    _scenarioContext["Password"] = Faker.Name.First().ToUpper() + "@" + "1993";
                    SendKeys(PasswordTextBox, (string)_scenarioContext["Password"]);
                    break;

            }
        }

        public void ClickCapchtaButton()
        {
            //new WebDriverWait(_driver, TimeSpan.FromSeconds(Constants.HIGH_WAIT)).Until(ExpectedConditions.FrameToBeAvailableAndSwitchToIt(By.XPath("")));
//            new WebDriverWait(driver, 10).until(
//    ExpectedConditions.frameToBeAvailableAndSwitchToIt(
//        By.xpath("//iframe[starts-with(@name, 'a-') and starts-with(@src, 'https://www.google.com/recaptcha')]")
//    )
//);
//            // wait a couple of seconds before clicking the Captcha

//            new WebDriverWait(driver, 20).until(
//                ExpectedConditions.elementToBeClickable(
//                    By.cssSelector("div.recaptcha-checkbox-checkmark")
//                )
//            ).click();
            JSClickElement(CaptchaButton);
        }

        public void ClickRegistrationButton()
        {
            IsElementVisible(RegistrationButton);
            ClickElement(RegistrationButton);
        }
        
        public void ValidatePostSubmissionData(string expectedValue)
        {
            var actualValue = GetAlertText();
            Assert.AreEqual(expectedValue, actualValue, $" actual value : {actualValue}, does not match with expected value : {expectedValue}");
            AcceptAlertPopUp();   
        }

        public void ClickGoBackToLoginButton()
        {
            IsElementVisible(GoToLoginButton);
                ClickElement(GoToLoginButton);
        }

}

    
}
