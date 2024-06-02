using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SpecFlowProjectMars2.Pages;
using SpecFlowProjectMars2.Utilities;
using System;
using System.Reflection.Emit;
using TechTalk.SpecFlow;

namespace SpecFlowProjectMars2.StepDefinitions
{
    [Binding]
    public class LanguageStepDefinitions
    {
        private LanguagePage languagePageObject;

        private readonly IWebDriver driver;

        public LanguageStepDefinitions(IWebDriver driver)
        {
            languagePageObject = new LanguagePage(driver);
            this.driver = driver;
        }
        [Given(@"User log into Mars portal")]
        public void GivenUserLogIntoMarsPortal()
        {
            AssertionHelpers.AssertLogin(languagePageObject);
            TestDataManager.ClearLanguageIfPresent(languagePageObject);
        }

        [When(@"User navigate to Language module")]
        public void WhenUserNavigateToLanguageModule()
        {
            languagePageObject.Click_LanguageTab();
        }

        [When(@"User create a new Language record '([^']*)' '([^']*)'")]
        public void WhenUserCreateANewLanguageRecord(string Language, string Level)
        {

            languagePageObject.CreateLanguageRecord(Language, Level);
        }

        [Then(@"the tooltip message should be ""([^""]*)""")]
        public void ThenTheTooltipMessageShouldBe(string expectedMessage)
        {
            AssertionHelpers.AssertTooltipMessage(languagePageObject, expectedMessage);
        }
        [Given(@"User log into MARS portal")]
        public void GivenUserLogIntoMARSPortal()
        {
            AssertionHelpers.AssertLogin(languagePageObject);
            TestDataManager.ClearLanguageIfPresent(languagePageObject);
        }


        [Given(@"User create a new language record without data")]
        public void GivenUserCreateANewLanguageRecordWithoutData()
        {
            languagePageObject.CreateLanguageRecord("", "");
        }

        [Given(@"User create a new language record '([^']*)' '([^']*)'")]
        public void GivenUserCreateANewLanguageRecord(string english, string basic)
        {
            languagePageObject.CreateLanguageRecord(english, basic);
        }

        [Given(@"User log into the Mars portal")]
        public void GivenUserLogIntoTheMarsPortal()
        {
            AssertionHelpers.AssertLogin(languagePageObject);
        }

        [Given(@"User add Four language record '([^']*)' '([^']*)'")]
        public void GivenUserAddFourLanguageRecord(string Language, string Level)
        {
            languagePageObject.CreateLanguageRecord(Language, Level);
        }

        [Then(@"the AddNewButton Does Not exist")]
        public void ThenTheAddNewButtonDoesNotExist()
        {
            AssertionHelpers.AssertAddNewButtonVisible(languagePageObject);
        }

        [When(@"User edit an existing language record '([^']*)' '([^']*)' <oldLevel> '([^']*)'")]
        public void WhenUserEditAnExistingRecordOldLevel(string oldLanguage, string newLanguage, string oldLevel, String newLevel)
        {
            languagePageObject.EditLanguageRecord(oldLanguage, newLanguage, oldLevel, newLevel);
        }

        

        [When(@"User delete an existing Language record '([^']*)'")]
        public void WhenUserDeleteAnExistingLanguageRecord(string french)
        {
            languagePageObject.DeleteLanguageRecord(french);
        }
    }
}
