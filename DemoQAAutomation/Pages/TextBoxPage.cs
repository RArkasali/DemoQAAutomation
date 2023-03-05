using BoDi;
using DemoQAAutomation.Utils;
using Faker;
using NUnit.Framework;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace DemoQAAutomation.Pages
{
    class TextBoxPage : SeleniumWrapper
    {   private By userFullName => By.Id("userName");
        private By UserEmail => By.Id("userEmail");
        private By CurrentAddress => By.Id("currentAddress");
        private By PermanentAddress => By.Id("permanentAddress");
        private By SubmitButton => By.Id("submit");
        private By ActualNameElement => By.XPath("//p[@id='name']");
        private By ActualEmailElement => By.XPath("//p[@id='email']");
        private By ActualCurrentAddressElement => By.XPath("//p[@id='currentAddress']");
        private By ActualPermanentAddressElement => By.XPath("//p[@id='permanentAddress']");

        private ScenarioContext _scenarioContext;

        public TextBoxPage(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        public void EnterFullName()
        {
            var fullName = Faker.Name.FullName(NameFormats.WithPrefix);
            _scenarioContext["FullName"] = fullName;
            SendKeys(userFullName,fullName);
        }

        public void EnterEmail()
        {
            //var name = Faker.Name.First();
            var emailAddress = Faker.Name.First();
            emailAddress = emailAddress + "@gmail.com";
            _scenarioContext["EmailAddress"] = emailAddress;
            SendKeys(UserEmail, emailAddress);
        }

        public void EnterCurrentAddress()
        {
            var address = $"{Faker.Address.StreetAddress()}, {Faker.Address.Country()}, {Faker.Address.City()}";
            _scenarioContext["CurrentAddress"] = address;
            SendKeys(CurrentAddress, address);

        }

        public void EnterPermanentAddress()
        {
            SendKeys(PermanentAddress, (string)_scenarioContext["CurrentAddress"]);
        }

        public void ClickSubmitButton()
        {
            JSClickElement(SubmitButton);
        }


        public void ValidatePostSubmissionData()
        {
            string actualName = GetText(ActualNameElement);
            string actualEmail = GetText(ActualEmailElement);
            string actualCurrentAddress = GetText(ActualCurrentAddressElement);
            string actualPermanentAddress = GetText(ActualPermanentAddressElement);

            Assert.True(actualName.Contains((string)_scenarioContext["FullName"]), $" actual value : {actualName}, does not match with expected value : {(string)_scenarioContext["FullName"]}");
            Assert.True(actualEmail.Contains((string)_scenarioContext["EmailAddress"]), $" actual value : {actualEmail}, does not match with expected value : {(string)_scenarioContext["EmailAddress"]}");
            Assert.True(actualCurrentAddress.Contains((string)_scenarioContext["CurrentAddress"]), $" actual value : {actualCurrentAddress}, does not match with expected value : {(string)_scenarioContext["CurrentAddress"]}");
            Assert.True(actualPermanentAddress.Contains((string)_scenarioContext["CurrentAddress"]), $" actual value : {actualPermanentAddress}, does not match with expected value : {(string)_scenarioContext["CurrentAddress"]}");
            
         }
    }

    
}
