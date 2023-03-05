using DemoQAAutomation.Utils;
using NUnit.Framework;
using OpenQA.Selenium;

namespace DemoQAAutomation.Pages
{
    class ButtonPage : SeleniumWrapper
    {
        private By DoubleClickButton => By.Id("doubleClickBtn");
        private By RightClickButton => By.Id("rightClickBtn");
        private By DynamicClickButton => By.XPath("//button[@class='btn btn-primary' and text()='Click Me']");
        private By DoubleClickMessage => By.Id("doubleClickMessage");
        private By RightClickMessage => By.Id("rightClickMessage");
        private By DynamicClickMessage => By.Id("dynamicClickMessage");


        public void ClickButtonOnButtonsPage(string value)
        {
            StaticWebWait(2);
            switch (value)
            {
                case "Double Click":
                    IsElementVisible(DoubleClickButton);
                    DoubleClickElement(DoubleClickButton);
                    break;
                case "Right Click":
                    IsElementVisible(RightClickButton);
                    RightClickElement(RightClickButton);
                    break;
                case "Dynamic Click":
                    IsElementVisible(DynamicClickButton);
                    JSClickElement(DynamicClickButton);
                    break;

            }

        }
        
        public void ValidatePostSubmissionData(string value, string expectedValue)
        {
            var actualValue = "";

            switch (value)
            {                  
                case "Double Click":
                    actualValue = GetText(DoubleClickMessage);
                    Assert.AreEqual(expectedValue, actualValue, $" actual value : {actualValue}, does not match with expected value : {expectedValue}");
                    break;
                case "Right Click":
                    actualValue = GetText(RightClickMessage);
                    Assert.AreEqual(expectedValue, actualValue, $" actual value : {actualValue}, does not match with expected value : {expectedValue}");
                    break;
                case "Dynamic Click":
                    actualValue = GetText(DynamicClickMessage);
                    Assert.AreEqual(expectedValue, actualValue, $" actual value : {actualValue}, does not match with expected value : {expectedValue}");
                    break;

            }     
         }

    }

    
}
