using DemoQAAutomation.Utils;
using NUnit.Framework;
using OpenQA.Selenium;
using System.IO;

namespace DemoQAAutomation.Pages
{
    class UploadAndDownloadPage : SeleniumWrapper
    {
        private By UploadButton => By.Id("uploadFile");
        private By DownloadButton => By.Id("downloadButton");
        private By UploadButtonMessage => By.Id("uploadedFilePath");


        public void ClickDownloadAndUploadButtons(string value)
        {
            StaticWebWait(2);
            switch (value)
            {
                case "Upload":
                    IsElementVisible(UploadButton);
                    SendKeys(UploadButton,Path.Combine(_uploadDirectory, Constants.UPLOAD_FILE_NAME));
                    break;
                case "Download":
                    IsElementVisible(DownloadButton);
                    ClickElement(DownloadButton);
                    break;
            }

        }
        
        public void ValidatePostSubmissionData(string value)
        {
            var actualValue = "";

            switch (value)
            {                  
                case "Upload":
                    actualValue = GetText(UploadButtonMessage);
                    Assert.True(actualValue.Contains(Constants.UPLOAD_FILE_NAME), "File does not upload successfully");
                    break;
                case "Download":
                    var count = Directory.GetFiles(_downloadDirectory).Length;
                    var flag = false;
                    
                    if (count > 0)
                        flag = true;

                    Assert.True(flag, "File does not download successfully");
                    Directory.Delete(_downloadDirectory, true);
                    Directory.CreateDirectory(_downloadDirectory);

                    break;

            }     
         }

    }

    
}
