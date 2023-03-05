using DemoQAAutomation.Utils;
using OpenQA.Selenium;
using System.Collections.Generic;
using System.Threading;

namespace DemoQAAutomation.Pages
{
    class SortablePage : SeleniumWrapper
    {
        private By SortableElements => By.XPath("//div[@id='demo-tabpane-list']/div/div");
       
       
        public void SortElementsInDecendingOrder()
        {
            IList <IWebElement> ElementsToSort = GetWebElements(SortableElements);

            var count = ElementsToSort.Count;

            StaticWebWait(4);

            for(int i = 0; i < count; i++)
            {
                DrapAndDropElement(ElementsToSort[count - 1], ElementsToSort[i]);
                ElementsToSort = GetWebElements(SortableElements);
                StaticWebWait(1);
            }



           
        }
    }
}
