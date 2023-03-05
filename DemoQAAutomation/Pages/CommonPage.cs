using DemoQAAutomation.Utils;
using NUnit.Framework;
using OpenQA.Selenium;
using System.Threading;

namespace DemoQAAutomation.Pages
{
    class CommonPage : SeleniumWrapper
    {
        private By HeaderValue  => By.ClassName("main-header");

        

        public void ValidateNavigationIsOnCallingPage(string expectedValue)
        {
            IsElementVisible(HeaderValue);
            string actualValue = GetText(HeaderValue);
            Assert.AreEqual(expectedValue , actualValue , "Header value does not matched for " + expectedValue + " page : " + actualValue);
        }


        public void RefreshPage()
        {
            _driver.Navigate().Refresh();
        }
    }
}
