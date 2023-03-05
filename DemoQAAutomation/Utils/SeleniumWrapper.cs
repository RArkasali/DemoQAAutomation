using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using WebDriverManager.DriverConfigs.Impl;

namespace DemoQAAutomation.Utils
{
    public class SeleniumWrapper
    {
        public static IWebDriver _driver;
        public static string _downloadDirectory;
        public static string _uploadDirectory;
        public IWebDriver InitApp(string browserName)
        {
            var directoryPath = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.ToString();
            _downloadDirectory = Path.Combine(directoryPath, Constants.DATA, Constants.DOWNLOAD_FOLDER);
            _uploadDirectory = Path.Combine(directoryPath, Constants.DATA, Constants.UPLOAD_FOLDER);

            if (browserName.Equals("chrome"))
            {
                var chromeOptions = new ChromeOptions();
                chromeOptions.AddUserProfilePreference("download.default_directory", _downloadDirectory);
                chromeOptions.AddUserProfilePreference("download.prompt_for_download", false);
                chromeOptions.AddUserProfilePreference("disable-popup-blocking", "true");
                new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
                _driver = new ChromeDriver(chromeOptions);
            }

            _driver.Manage().Window.Maximize();
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(Constants.MID_WAIT); ;

            return _driver;
        }

        public IWebElement GetWebElement(By element)
        {
            return _driver.FindElement(element);
        }

        public IList<IWebElement> GetWebElements(By element)
        {
            return _driver.FindElements(element);
        }

        public void ClickElement(By webElement)
        {
            GetWebElement(webElement).Click();
        }

        public void SendKeys(By webElement, string value)
        {
            GetWebElement(webElement).SendKeys(value);
        }

        public void IsTitleVisible(string titleName)
        {
            WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(Constants.HIGH_WAIT));
            wait.Until(ExpectedConditions.TitleContains(titleName));
        }

        public void IsElementVisible(By webElement)
        {
            WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(Constants.HIGH_WAIT));
            wait.Until(ExpectedConditions.ElementIsVisible(webElement));
        }

        public void JSClickElement(By webElement)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)_driver;
            js.ExecuteScript("arguments[0].click();", GetWebElement(webElement));
        }

        public string GetText(By webElement)
        {
            return GetWebElement(webElement).Text;
        }

        public void DoubleClickElement(By webElement)
        {
            new Actions(_driver).DoubleClick(GetWebElement(webElement)).Perform();
        }

        public void RightClickElement(By webElement)
        {
            new Actions(_driver).ContextClick(GetWebElement(webElement)).Perform();
        }

        public void StaticWebWait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
        }

        public void ClearTextBox(By webElement)
        {
            GetWebElement(webElement).Clear();
        }

        public string GetAlertText()
        {
            return _driver.SwitchTo().Alert().Text;
        }

        public void AcceptAlertPopUp()
        {
            _driver.SwitchTo().Alert().Accept();
        }

        public void DismissAlertPopUp()
        {
            _driver.SwitchTo().Alert().Dismiss();
        }

        public void SendkeysAlertPopUp(string value)
        {
            _driver.SwitchTo().Alert().SendKeys(value);
        }

        public void DrapAndDropElement(IWebElement dragFrom, IWebElement dragTo)
        {
            new Actions(_driver).DragAndDrop(dragFrom,dragTo).Build().Perform();
        }

        public string GetAtributeValue(By webElement, string attributeName)
        {
            return GetWebElement(webElement).GetAttribute(attributeName);
        }

        public void HouseHoverElement(By webElement)
        {
            new Actions(_driver).MoveToElement(GetWebElement(webElement)).Perform();
        }

        public void DrapAndDropElement1(IWebElement dragFrom, IWebElement dragTo)
        {
            new Actions(_driver).ClickAndHold(dragFrom).MoveToElement(dragTo,30,30).Release(dragTo).Build().Perform();
        }
    }
}
