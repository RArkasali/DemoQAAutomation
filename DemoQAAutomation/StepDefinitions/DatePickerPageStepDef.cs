    using DemoQAAutomation.Pages;
using TechTalk.SpecFlow;

namespace DemoQAAutomation.StepDefinitions
{
    [Binding]
    public class DatePickerPageStepDef
    {
        DatePickerPage datePickerPage;
        DatePickerPageStepDef()
        {
            datePickerPage = new DatePickerPage();
        }

        [Then(@"User enter data in start date text field")]
        public void ThenUserEnterDataInStartDateTextField()
        {
            datePickerPage.EnterStartDate();
        }

        [Then(@"User enter data in date and time text field")]
        public void ThenUserEnterDataInDateAndTimeTextField()
        {
            datePickerPage.EnterDataAndTime();
        }


    }
}
