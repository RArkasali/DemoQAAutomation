using DemoQAAutomation.Utils;
using NUnit.Framework;
using OpenQA.Selenium;
using System;

namespace DemoQAAutomation.Pages
{
    class AutoCompletePage : SeleniumWrapper
    {
        private By SingleInputTexField => By.Id("autoCompleteSingleInput");
        private By MultiInputTextField => By.Id("autoCompleteMultipleInput");
        //private By SelectColor => By.XPath("//div[contains(@class,'auto-complete__menu')]");
        private By MultiInputTextFieldValue => By.XPath("(//*[@class='auto-complete__control css-yk16xz-control'])[1]");
        private By SingleInputTexFieldValue => By.XPath("(//*[@class='auto-complete__control css-yk16xz-control'])[2]");

        public void SelectColorFromTextField(string value, string data)
        {
            if (value.ToLower().Equals("single"))
            {
                SendKeys(SingleInputTexField, data);
                SendKeys(SingleInputTexField, Keys.Enter);
            }
            else
            {
                int count = data.Split(",").Length;
                var dataArray = data.Split(",");
                for (int i = 0; i < count; i++)
                {
                    SendKeys(MultiInputTextField, dataArray[i]);
                    SendKeys(MultiInputTextField, Keys.Enter);
                }
            }
           
        }

        public void ValidateSubmissionData(string value,string data)
        {
            string actualValue = "";
            if (value.ToLower().Equals("single"))
            {
                actualValue = GetText(SingleInputTexFieldValue);
                Assert.AreEqual(data.Trim(), actualValue.Trim(), $" actual value : {actualValue}, does not match with expected value : {data}");
            }
            else
            {
                int count = data.Split(",").Length;
                var dataArray = data.Split(",");
                for (int i = 0; i < count; i++)
                {
                    actualValue = GetText(MultiInputTextFieldValue);
                    Assert.True(actualValue.Contains(dataArray[i]), $" actual value : {actualValue}, does not match with expected value : {data}");

                }
            }
        }

     
        
    }
}
