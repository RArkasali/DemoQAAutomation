using DemoQAAutomation.Utils;
using NUnit.Framework;
using OpenQA.Selenium;
using System.Collections.Generic;
using System.Threading;

namespace DemoQAAutomation.Pages
{
    class DroppablePage : SeleniumWrapper
    {
        private By DraggableItemLink => By.Id("draggable");
        private By DroppableItemLink => By.Id("droppable");
            
        public void DropElement()
        {
          StaticWebWait(5);
          IsElementVisible(DraggableItemLink);
          DrapAndDropElement1(GetWebElement(DraggableItemLink), GetWebElement(DroppableItemLink));  
        }

        public void ValidatePostSubmission()
        {
            StaticWebWait(5);
            string actualValue = GetAtributeValue(DroppableItemLink,"class");
            Assert.True(actualValue.Contains("ui-state-highlight"), $" actual value : {actualValue}, does not match with expected value");
        }
    }
}
