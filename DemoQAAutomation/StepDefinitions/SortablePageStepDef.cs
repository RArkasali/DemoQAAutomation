    using DemoQAAutomation.Pages;
using TechTalk.SpecFlow;

namespace DemoQAAutomation.StepDefinitions
{
    [Binding]
    public class SortablePageStepDef
    {
        SortablePage sortablePage;
        SortablePageStepDef()
        {
            sortablePage = new SortablePage();
        }

        [When(@"User sorts the list in descending order")]
        public void WhenUserSortsTheListInDescendingOrder()
        {
            sortablePage.SortElementsInDecendingOrder();
        }



    }
}
