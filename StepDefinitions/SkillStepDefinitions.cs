using OpenQA.Selenium;
using SpecFlowProjectMars2.Pages;
using SpecFlowProjectMars2.Utilities;
using System;
using System.Reflection.Emit;
using TechTalk.SpecFlow;

namespace SpecFlowProjectMars2.StepDefinitions
{
    [Binding]
    public class SkillStepDefinitions
    {
        private SkillPage SkillPageObject;

        public SkillStepDefinitions (IWebDriver driver )

        {
            SkillPageObject = new SkillPage (driver);
        }
        [Given(@"User logs into Mars portal")]
        public void GivenUserLogsIntoMarsPortal()
        {
            AssertionHelpers.AssertLogin(SkillPageObject);
            TestDataManager.ClearSkillIfPresent(SkillPageObject);
        }

        [When(@"User navigate to skill module")]
        public void WhenUserNavigateToSkillModule()
        {
            SkillPageObject.Click_SkillsTab();
        }


        [When(@"User create a new Skill record '([^']*)' '([^']*)'")]
        public void whenUserCreateANewSkillRecord(string Skills, string Level)
        {
            SkillPageObject.CreateSkillsRecord(Skills, Level);
        }


        [Then(@"tooltip message should be ""([^""]*)""")]
        public void thenTooltipMessageShouldBe(string expectedMessage)
        {
            AssertionHelpers.AssertToolTipMessage(SkillPageObject, expectedMessage);
        }

        [Given(@"User logs into MARS portal")]
        public void GivenUserLogsIntoMARSPortal()
        {
            AssertionHelpers.AssertLogin(SkillPageObject);
            TestDataManager.ClearSkillIfPresent(SkillPageObject);
        }

        [When(@"User navigates to skill module")]
        public void WhenUserNavigatesToSkillModule()
        {
            SkillPageObject.Click_SkillsTab();
        }

        [When(@"User create a new Skill record without data")]
        public void WhenUserCreateANewSkillRecordWithoutData()
        {
            SkillPageObject.CreateSkillsRecord("", "");
        }

        [Given(@"User create a new Skill record '([^']*)' '([^']*)'")]
        public void GivenUserCreateANewSkillRecord(string SpecFlow, string Beginner)
        {
            SkillPageObject.CreateSkillsRecord(SpecFlow, Beginner);
        }

        [When(@"User edit an existing skill record '([^']*)' '([^']*)' '([^']*)' '([^']*)'")]
        public void WhenUserEditAnExistingSkillRecord(string oldSkills, string newSkills, string oldLevel, string newLevel)
        {
            SkillPageObject.EditSkillsRecord(oldSkills, newSkills, oldLevel, newLevel);
        }

        [When(@"User delete an existing Skill record '([^']*)'")]
        public void WhenUserDeleteAnExistingSkillRecord(string java)
        {
            SkillPageObject.DeleteSkillsRecord(java);
        }
    }
}
