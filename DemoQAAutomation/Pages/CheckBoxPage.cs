using BoDi;
using DemoQAAutomation.Utils;
using Faker;
using NUnit.Framework;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace DemoQAAutomation.Pages
{
    class CheckBoxPage : SeleniumWrapper
    {   private By ExpandAllButton => By.XPath("//button[@title='Expand all']");
        private By ResultText => By.Id("result");
        private string CheckBoxSelectButton => "//*[text()='Data']/..//span[@class='rct-checkbox']";
      
        private ScenarioContext _scenarioContext;

        public CheckBoxPage(ScenarioContext scenarioContext)
        {
            StaticWebWait(2);
            _scenarioContext = scenarioContext;
        }

        public void ClickExpandAllButton()
        {
            IsElementVisible(ExpandAllButton);
            ClickElement(ExpandAllButton);
        }

        public void ClickCheckBoxElement(string value)
        {
            JSClickElement(By.XPath(CheckBoxSelectButton.Replace("Data", value)));
        }

        public void ValidatePostSubmissionData(string data)
        {
            string actualValue = GetText(ResultText);
            var dataArray = data.Split(",");

            for(int i = 0; i < dataArray.Length; i++)
                Assert.True(actualValue.Contains(dataArray[i].ToLower()), $" actual value : {actualValue}, does not match with expected value : {dataArray[i]}");
         }
        
    }
}
