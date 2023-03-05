using DemoQAAutomation.Utils;
using OpenQA.Selenium;

namespace DemoQAAutomation.Pages
{
    class HomePage : SeleniumWrapper
    {
        private By ElementsLink => By.XPath("//h5[text()='Elements']");
        private By FormsLink => By.XPath("//h5[text()='Forms']");
        private By AlertsLink => By.XPath("//h5[text()='Alerts, Frame & Windows']");
        private By WidgetsLink => By.XPath("//h5[text()='Widgets']");
        private By InteractionsLink => By.XPath("//h5[text()='Interactions']");
        private By BookStoreLink => By.XPath("//h5[text()='Book Store Application']");

        public void NaviagteToTheApplication()
        {
            var URL = System.Environment.GetEnvironmentVariable("URL");
            _driver.Navigate().GoToUrl(URL);
            IsTitleVisible("DEMOQA");
        }

        public void ClickOnLink(string value)
        {
            switch (value.ToLower())
            {
                case "elements":
                    IsElementVisible(ElementsLink);
                    JSClickElement(ElementsLink);
                    break;
                case "forms":
                    IsElementVisible(FormsLink);
                    JSClickElement(FormsLink);
                    break;
                case "alerts":
                    IsElementVisible(AlertsLink);
                    JSClickElement(AlertsLink);
                    break;
                case "widgets":
                    IsElementVisible(WidgetsLink);
                    JSClickElement(WidgetsLink);
                    break;
                case "book store":
                    IsElementVisible(BookStoreLink);
                    JSClickElement(BookStoreLink);
                    break;
                case "interactions":
                    IsElementVisible(InteractionsLink);
                    JSClickElement(InteractionsLink);
                    break;
            }
          
        }
    }
}
