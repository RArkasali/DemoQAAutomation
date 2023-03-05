using DemoQAAutomation.Utils;
using NUnit.Framework;
using OpenQA.Selenium;

namespace DemoQAAutomation.Pages
{
    class ToolTipsPage : SeleniumWrapper
    {
        private By ToolTipButton => By.Id("toolTipButton");
        private By ToolTipTextField => By.Id("toolTipTextField");
        private By ToolTipMessage => By.XPath("//*[@role='tooltip']");
    

      public void MouseHoverContext(string value)
        {
            StaticWebWait(2);
            IsElementVisible(ToolTipButton);
            if (value.ToLower().Contains("button"))
                HouseHoverElement(ToolTipButton);
            else
                HouseHoverElement(ToolTipTextField);

        }

        public void ValidateSubmissionMessage(string expectedValue)
        {
            string actualValue = GetText(ToolTipMessage);
            Assert.AreEqual(expectedValue, actualValue, $" actual value : {actualValue}, does not match with expected value : {expectedValue}");

        }

    }
}
