using DemoQAAutomation.Utils;
using NUnit.Framework;
using OpenQA.Selenium;
using System.Threading;
using TechTalk.SpecFlow;

namespace DemoQAAutomation.Pages
{
    class WindowsPage : SeleniumWrapper
    {
        private By NewTabButton => By.Id("tabButton");
        private By NewWindowButton => By.Id("windowButton");
        private By NewWindowMessageButton => By.Id("messageWindowButton");
        private By SamplePageHeader => By.Id("sampleHeading");
        private By SampleBodyPage => By.XPath("//body");

        public WindowsPage()
        {
            StaticWebWait(2);
        }

        public void ClickWindowTab(string value)
        {
            IsElementVisible(NewTabButton);

            if (value.ToLower().Equals("new tab"))
            {
                JSClickElement(NewTabButton);
            }
            else if (value.ToLower().Equals("new window"))
            {
                JSClickElement(NewWindowButton);
            }
            else
            {
                JSClickElement(NewWindowMessageButton);
            }
        }

        public void ValidateSubmissionMessage(string expectedValue)
        {
            StaticWebWait(2);

            var windowHandles = _driver.WindowHandles;
            int totalWindows = _driver.WindowHandles.Count;
            var newWindow = _driver.SwitchTo().Window(windowHandles[totalWindows - 1]);
            _driver = newWindow;

            StaticWebWait(2);

            if (expectedValue.ToLower().Contains("sample"))
            {
                string actualValue = GetText(SamplePageHeader);
                Assert.AreEqual(expectedValue, actualValue, $" actual value : {actualValue}, does not match with expected value : {expectedValue}");
                _driver.Close();
                _driver.SwitchTo().Window(windowHandles[0]);
            }
            else
            {
                string actualValue = expectedValue;
                Assert.AreEqual(expectedValue, actualValue, $" actual value : {actualValue}, does not match with expected value : {expectedValue}");
            }

            
        }
    }
}
