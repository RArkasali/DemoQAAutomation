using DemoQAAutomation.Utils;
using OpenQA.Selenium;
using System.Threading;

namespace DemoQAAutomation.Pages
{
    class ElementsPage : SeleniumWrapper
    {
        private By TextBoxLink => By.XPath("//span[text()='Text Box']");
        private By CheckBoxLink => By.XPath("//span[text()='Check Box']");
        private By WebTablesLink => By.XPath("//span[text()='Web Tables']");
        private By ButtonsLink => By.XPath("//span[text()='Buttons']");
        private By UploadAndDownloadLink => By.XPath("//span[text()='Upload and Download']");
        

        public void ClickOnElementsPageLink(string value)
        {
            IsTitleVisible("DEMOQA");
            switch (value.ToLower())
            {
                case "textbox":
                    IsElementVisible(TextBoxLink);
                    JSClickElement(TextBoxLink);
                    break;
                case "checkbox":
                    IsElementVisible(CheckBoxLink);
                    JSClickElement(CheckBoxLink);
                    break;
                case "webtables":
                    IsElementVisible(WebTablesLink);
                    JSClickElement(WebTablesLink);
                    break;
                case "buttons":
                    IsElementVisible(ButtonsLink);
                    JSClickElement(ButtonsLink);
                    break;
                case "upload and download":
                    IsElementVisible(UploadAndDownloadLink);
                    JSClickElement(UploadAndDownloadLink);
                    break;
            }
          
        }
    }
}
