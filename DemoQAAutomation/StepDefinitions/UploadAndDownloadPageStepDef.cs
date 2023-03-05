    using DemoQAAutomation.Pages;
using TechTalk.SpecFlow;

namespace DemoQAAutomation.StepDefinitions
{
    [Binding]
    public class UploadAndDownloadPageStepDef
    {
        UploadAndDownloadPage uploadAndDownloadPage;
        UploadAndDownloadPageStepDef()
        {
            uploadAndDownloadPage = new UploadAndDownloadPage();
        }

        [When(@"User (.*) the file on the upload and download page")]
        public void WhenUserTheFileOnTheUploadAndDownloadPage(string value)
        {
            uploadAndDownloadPage.ClickDownloadAndUploadButtons(value);
        }

        [Then(@"User verifies a (.*) has done successfully")]
        public void ThenUserVerifiesTheHasDoneSuccessfully(string value)
        {
            uploadAndDownloadPage.ValidatePostSubmissionData(value);
        }

    }
}
