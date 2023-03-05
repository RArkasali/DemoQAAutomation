using DemoQAAutomation.Utils;
using OpenQA.Selenium;
using System.Threading;

namespace DemoQAAutomation.Pages
{
    class AlertAndFramePage : SeleniumWrapper
    {
        private By AlertFrameAlertLink => By.XPath("//span[text()='Alerts']");
        private By AlertFrameBrowserWindowsLink => By.XPath("//span[text()='Browser Windows']");
      
       
        public void ClickOnAlertsAndFramesPageLink(string value)
        {
            IsTitleVisible("DEMOQA");
            switch (value.ToLower())
            {
                case "alerts":
                    IsElementVisible(AlertFrameAlertLink);
                    JSClickElement(AlertFrameAlertLink);
                    break;
                case "windows":
                    IsElementVisible(AlertFrameBrowserWindowsLink);
                    JSClickElement(AlertFrameBrowserWindowsLink);
                    break;
            }
        }
    }
}
