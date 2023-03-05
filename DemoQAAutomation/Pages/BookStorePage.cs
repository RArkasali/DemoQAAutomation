using DemoQAAutomation.Utils;
using OpenQA.Selenium;
using System.Threading;

namespace DemoQAAutomation.Pages
{
    class BookStorePage : SeleniumWrapper
    {
        private By BookStoreLoginLink => By.XPath("//span[text()='Login']");
      
       
        public void ClickOnBookStorePageLink(string value)
        {
            IsTitleVisible("DEMOQA");
            switch (value.ToLower())
            {
                case "login":
                    IsElementVisible(BookStoreLoginLink);
                    JSClickElement(BookStoreLoginLink);
                    break;
            }
        }
    }
}
