using BoDi;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using TechTalk.SpecFlow;

namespace DemoQAAutomation.Utils
{
    [Binding]
    public class Hooks : SeleniumWrapper
    {
        private readonly IObjectContainer _objectContainer;

        Hooks(IObjectContainer objectContainer)
        {
            _objectContainer = objectContainer;
        }

        [BeforeScenario]
        public void Initialize()
        {
             InitApp("chrome");
            _objectContainer.RegisterInstanceAs<IWebDriver>(_driver);
        }

        [AfterScenario]
        public void CleanUp()
        {
            _driver.Quit();
        }


    }
}
