using DemoQAAutomation.Utils;
using NUnit.Framework;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace DemoQAAutomation.Pages
{
    class WebTablesPage : SeleniumWrapper
    {
        private By EditLink => By.Id("edit-record-1");
        private By FirstNameTextBox => By.Id("firstName");
        private By FirstCellTd => By.XPath("(//div[@class='rt-td'])[1]");
        private By SubmitButton => By.Id("submit");

        private ScenarioContext _scenarioContext;

       public WebTablesPage(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }
  
        public void ClickOnEditLink()
        {
            StaticWebWait(2);
            IsElementVisible(EditLink);
            ClickElement(EditLink);
            
        }

        public void RenameFirstName()
        {
            IsElementVisible(FirstNameTextBox);
            _scenarioContext["FirstName"] = Faker.Name.First();
            ClearTextBox(FirstNameTextBox);
            SendKeys(FirstNameTextBox, (string)_scenarioContext["FirstName"]);
            ClickElement(SubmitButton);
        }

        public void ValidatePostSubmissionData()
        {
            string actualValue = GetText(FirstCellTd);
            string expectedValue = (string)_scenarioContext["FirstName"];
            Assert.AreEqual(expectedValue, actualValue, $" actual value : {actualValue}, does not match with expected value : {expectedValue}");
                
        }
        
    }
 
}
 

    
