using DemoQAAutomation.Utils;
using OpenQA.Selenium;
using System.Threading;

namespace DemoQAAutomation.Pages
{
    class WidgetsPage : SeleniumWrapper
    {
        private By ToolTipsLink => By.XPath("//span[text()='Tool Tips']");
        private By AutoCompleteLink => By.XPath("//span[text()='Auto Complete']");
        private By DatePickerLink => By.XPath("//span[text()='Date Picker']");
      
       
        public void ClickOnWidgetsPageLink(string value)
        {
            IsTitleVisible("DEMOQA");
            switch (value.ToLower())
            {
                case "tool tips":
                    IsElementVisible(ToolTipsLink);
                    JSClickElement(ToolTipsLink);
                    break;
                case "auto complete":
                    IsElementVisible(AutoCompleteLink);
                    JSClickElement(AutoCompleteLink);
                    break;
                case "date picker":
                    IsElementVisible(DatePickerLink);
                    JSClickElement(DatePickerLink);
                    break;

            }
        }
    }
}
