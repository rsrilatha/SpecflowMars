﻿using NUnit.Framework;
using OpenQA.Selenium;
using SpecFlowMars.Utilities;
using SpecFlowProjectMars2.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SpecFlowProjectMars2.Utilities
{
    public static class AssertionHelpers
    {
        public static void AssertToolTipMessage(CommonDriver page, string expectedMessage)
        {
            IWebDriver driver = page.getDriver();
            waitUtils.WaitToBeVisible(driver, "XPath", "//*[@class='ns-box-inner']", 20);
            IWebElement toolTipMessage = driver.FindElement(By.XPath("//*[@class='ns-box-inner']"));
            string actualMessage = toolTipMessage.Text.Trim();
            Console.WriteLine("Tooltip Text: " + actualMessage);
            // Remove single quotes from the expected message
            string expectedMessageWithoutQuotes = expectedMessage.Replace("'", "");
            // Check if the actual message matches the expected message without quotes
            if (actualMessage == expectedMessageWithoutQuotes)
            {
                // Log the success
                Console.WriteLine("Tooltip message matches the expected message.");
            }
            else
            {
                // Log the failure and provide details about the differences
                Console.WriteLine($"Expected: '{expectedMessage}'");
                Console.WriteLine($"But was:  '{actualMessage}'");
                Assert.Fail("Tooltip message does not match the expected message.");
            }
        }
        public static void AssertAddNewButtonVisible(CommonDriver page)
        {

            bool isAddNewButtonVisible = false;

            try
            {
                IWebDriver driver = page.getDriver();
                // Check if the Add New button is visible
                isAddNewButtonVisible = driver.FindElement(By.XPath("//*[@class='ui teal button ']")).Displayed;
            }
            catch (NoSuchElementException)
            {
                // If the Add New button is not found, set the flag to false
                isAddNewButtonVisible = false;
            }

            // Assert that the Add New button is visible
            Assert.IsFalse(isAddNewButtonVisible, "you cannot add more than 4 languages");
        }

        public static void AssertLogin(CommonDriver page)
        {
            Boolean LoggedIn = page.verifyLogin();

            Assert.IsTrue(LoggedIn);
        }

        internal static void AssertTooltipMessage(LanguagePage languagePageObject, string expectedMessage)
        {
            throw new NotImplementedException();
        }
    }
}
