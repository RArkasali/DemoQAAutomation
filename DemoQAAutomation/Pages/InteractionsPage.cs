using DemoQAAutomation.Utils;
using OpenQA.Selenium;
using System.Threading;

namespace DemoQAAutomation.Pages
{
    class InteractionsPage : SeleniumWrapper
    {
        private By SortableLink => By.XPath("//span[text()='Sortable']");
        private By DroppableLink => By.XPath("//span[text()='Droppable']");
      
       
        public void ClickOnInteractionsPageLink(string value)
        {
            IsTitleVisible("DEMOQA");
            switch (value.ToLower())
            {
                case "sortable":
                    IsElementVisible(SortableLink);
                    JSClickElement(SortableLink);
                    break;
                case "droppable":
                    IsElementVisible(DroppableLink);
                    JSClickElement(DroppableLink);
                    break;
            }
        }
    }
}
