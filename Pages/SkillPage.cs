using OpenQA.Selenium;
using SpecFlowMars.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowProjectMars2.Pages
{
    public class SkillPage : CommonDriver
    {
        public SkillPage(IWebDriver driver) : base(driver) { }
        public SkillPage() { }

        public IWebElement SkillsTab => driver.FindElement(By.XPath("//a[contains(text(),'Skills')]"));
        public IWebElement AddNewButton => driver.FindElement(By.XPath("//div[@class='ui teal button']"));
        public IWebElement SkillsTextbox => driver.FindElement(By.XPath("//*[@placeholder='Add Skill']"));
        public IWebElement chooseLevelDropdown => driver.FindElement(By.XPath("//*[@class='ui fluid dropdown']"));
        public IWebElement chooseLevelOption => driver.FindElement(By.XPath("//*[@value='\" + Level + \"']"));
        public IWebElement AddButton => driver.FindElement(By.XPath("//input[@value='Add']"));
        public IWebElement CancelButton => driver.FindElement(By.XPath("//input[@value='Cancel']"));
        public IWebElement TooltipMessage => driver.FindElement(By.XPath("//*[@class='ns-box-inner']"));
        public IWebElement EditSkillsTextbox => driver.FindElement(By.XPath("//input[@placeholder='Add Skill']"));
        public IWebElement EditChooseLevelDropdown => driver.FindElement(By.XPath("//*[@class='ui fluid dropdown']"));
        public IWebElement EditPencilIcon => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[4]/tr/td[3]/span[1]/i"));
        public IWebElement UpdateButton => driver.FindElement(By.XPath("//input[@value='Update']"));
        public IWebElement EditChooseLevelOption => driver.FindElement(By.XPath("//*[@value='\" + newLevel + \"']"));
        public IWebElement LastDeleteIcon => driver.FindElement(By.XPath("//div[@data-tab='second']//table/tbody[last()]/tr/td[3]/span[2]"));

        //Methods
       public void Click_SkillsTab()
        {
            waitUtils.waitToBeVisible(driver, "Xpath", "SkillsTab", 10);
        }

        public void CreateSkillsRecord(string Skills, string Level)
        {
            //Click on Addnew Button
            waitUtils.waitToBeVisible(driver, "xpath", "AddNewButton", 5);
            //Enter Skills
            SkillsTextbox.Click();
            SkillsTextbox.SendKeys(Skills);
            //Select skills level and dropdownlist
            waitUtils.waitToBeVisible(driver, "xpath", "chooseLevelDropdown", 5);
            chooseLevelDropdown.Click();
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//*[@value='\" + Level + \"']")).Click();
                //click on save button
            waitUtils.waitToBeVisible(driver, "Xapth", "AddButton", 5);
            AddButton.Click();
            Thread.Sleep(4000);
        }

        public void EditSkillsRecord(string oldSkills, string newSkills, string oldLevel, string newLevel)
        {
            //Click edit pencilicon for existing record
            waitUtils.waitToBeVisible(driver, "Xpath", "EditPencilIcon", 5);
            EditPencilIcon.Click();

            if(newSkills.Length > 0)
            {
                EditSkillsTextbox.Click();
                EditSkillsTextbox.SendKeys(newSkills);

            }
            if(newLevel.Length > 0)
            {
                waitUtils.waitToBeVisible(driver, "Xpath", "EditChooseLevelDropdown", 5);
                EditChooseLevelDropdown.Click();
                IWebElement EditChooseLevelOption = driver.FindElement(By.XPath("//*[@value='" + newLevel + "']"));
                EditChooseLevelOption.Click();
            }
            waitUtils.waitToBeVisible(driver, "Xpath", "UpdateButton", 5);
            UpdateButton.Click();
        }

        public void DeleteSkillsRecord(string java)
        {
            LastDeleteIcon.Click();
        }
    }


}
