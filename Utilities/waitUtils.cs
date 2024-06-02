using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowMars.Utilities
{
    public class waitUtils
    {
        public static void waitToBeClickable(WebDriver driver, string locatorType, string locatorValue, int seconds)
        {
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(seconds));   
            if (locatorType == "Xpath")
            {
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath(locatorValue)));
            }
            if (locatorType == "Id")
            {
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id(locatorValue)));
            }
            if (locatorType == "CssSelector")
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.CssSelector(locatorValue)));

            if (locatorType == "Name")
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Name(locatorValue)));

        }

        public static void waitToBeClickable(IWebDriver driver, string locatorType, string locatorValue, int seconds)
        {
            var wait = new WebDriverWait(driver, new TimeSpan(0, 0, seconds));

            if (locatorType == "XPath")
            {
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath(locatorValue)));
            }
            if (locatorType == "Id")
            {
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id(locatorValue)));
            }
            if (locatorType == "CssSelector")
            {
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.CssSelector(locatorValue)));
            }
            if (locatorType == "Name")
            {
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Name(locatorValue)));
            }
        }

        public static void WaitToExist(IWebDriver driver, string locatorType, string locatorValue, int seconds)
        {
            var wait = new WebDriverWait(driver, new TimeSpan(0, 0, seconds));


            if (locatorType == "XPath")
            {
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath(locatorValue)));
            }
            if (locatorType == "Id")
            {
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.Id(locatorValue)));
            }
            if (locatorType == "CssSelector")
            {
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.CssSelector(locatorValue)));
            }
            if (locatorType == "Name")
            {
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.Name(locatorValue)));
            }

        }

        public static void waitToBeVisible(IWebDriver driver, string locatortype, string loctorvalue, int seconds)
        {
            throw new NotImplementedException();
        }

        internal static void waitToBeVisible(IWebDriver driver, string locatortype, string locatorvalue)
        {
            throw new NotImplementedException();
        }

        internal static void WaitToBeVisible(IWebDriver driver, string locatortype, string locatorvalue, int seconds)
        {
            throw new NotImplementedException();
        }
    }
}
