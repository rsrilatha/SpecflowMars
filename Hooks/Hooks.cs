using BoDi;
using OpenQA.Selenium;
using SpecFlowMars.Utilities;
using SpecFlowProjectMars2.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using OpenQA.Selenium.Chrome;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace SpecFlowProjectMars2.Hooks
{
    [Binding]
    public sealed class Hooks
    {
        private readonly IObjectContainer _container;

        public Hooks(IObjectContainer container)
        {
            _container = container;
        }

        [BeforeScenario]
        public void BeforeScenario()
        {
            CommonDriver driverSetup = new CommonDriver();
            IWebDriver driver = driverSetup.Initialize();
            driver.Manage().Window.Maximize();
            LoginPage loginPageObject = new LoginPage(driver);
            loginPageObject.LoginSteps();

            _container.RegisterInstanceAs<IWebDriver>(driver);
        }

        [AfterScenario]
        public void AfterScenario()
        {
            var driver = _container.Resolve<IWebDriver>();

            if (driver != null)
            {
                driver.Quit();
            }

        }

    }
}
