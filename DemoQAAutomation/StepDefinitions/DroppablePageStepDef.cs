    using DemoQAAutomation.Pages;
using TechTalk.SpecFlow;

namespace DemoQAAutomation.StepDefinitions
{
    [Binding]
    public class DroppablePageStepDef
    {
        DroppablePage droppablePage;
        DroppablePageStepDef()
        {
            droppablePage = new DroppablePage();
        }

        [Then(@"User drag the item to the drop able place")]
        public void ThenUserDragTheItemToTheDropAblePlace()
        {
            droppablePage.DropElement();
        }

        [Then(@"User verifies a color change of the droppable box")]
        public void ThenUserVerifiesTheColorChangeOfTheDroppableBox()
        {
            droppablePage.ValidatePostSubmission();
        }

    }
}
