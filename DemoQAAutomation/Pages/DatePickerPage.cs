using DemoQAAutomation.Utils;
using NUnit.Framework;
using OpenQA.Selenium;
using System;

namespace DemoQAAutomation.Pages
{
    class DatePickerPage : SeleniumWrapper
    {
        private By StartDateTextField => By.Id("datePickerMonthYearInput");
        private By DateTimeTextField => By.Id("dateAndTimePickerInput");
        
   
        public void EnterStartDate()
        {
            ClearTextBox(StartDateTextField);
            string date = DateTime.Now.ToString("MM/dd/yyyy");
            SendKeys(StartDateTextField, date);
        }

        public void EnterDataAndTime()
        {
            ClearTextBox(DateTimeTextField);
            string date = DateTime.Now.ToString("MMM d, yyyy hh:mm tt");
            SendKeys(DateTimeTextField, date);
        }

     
        
    }
}
