using OpenQA.Selenium;
using SpecFlowMars.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowProjectMars2.Pages
{
    public class LanguagePage : CommonDriver
    {
        public LanguagePage(IWebDriver driver) : base(driver)
        {
        }
        public LanguagePage() { }   

        //Web Elements

        public IWebElement LanguageTab => driver.FindElement(By.XPath("//a[contains(text(),'Languages')]"));
        public IWebElement AddNewButton => driver.FindElement(By.XPath("//*[@class='ui teal button ']"));
        public IWebElement LanguageTextbox => driver.FindElement(By.XPath("//*[@placeholder='Add Language']"));


        public IWebElement chooseLevelDropdown => driver.FindElement(By.XPath("//*[@class='ui dropdown']"));
        public IWebElement chooseLevelOption => driver.FindElement(By.XPath("//*[@value='\" + Level + \"']"));


        public IWebElement AddButton => driver.FindElement(By.XPath("//input[@value='Add']"));
        public IWebElement CancelButton => driver.FindElement(By.XPath("//input[@value='Cancel']"));

        public IWebElement ToolTipMessage => driver.FindElement(By.XPath("//*[@class='ns-box-inner']"));
        public IWebElement EditLanguageTextbox => driver.FindElement(By.XPath("//*[@placeholder='Add Language']"));


        public IWebElement EditChooselevelDropdown => driver.FindElement(By.XPath("\"//*[@class='ui dropdown']"));
        public IWebElement EditpencilIcon => driver.FindElement(By.XPath("//div[@id='account-profile-section']//form//table//tbody[2]/tr/td[3]/span[1]/i"));


        public IWebElement UpdateButton => driver.FindElement(By.XPath("//input[@value='Update']"));
        public IWebElement EditChooseLevelOption => driver.FindElement(By.XPath("//*[@value='\" + newLevel + \"']"));
        public IWebElement LastDeleteIcon => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[3]/span[2]"));

        public void Click_LanguageTab()
        {
            waitUtils.waitToBeVisible(driver, "Xpath", "LanguageTab", 10);
            LanguageTab.Click();
        }

        public void CreateLanguageRecord(string Language, string Level)
        {
            waitUtils.waitToBeVisible(driver, "Xpath", "AddNewButton", 10);
            AddNewButton.Click();

            //Enter Language
            LanguageTextbox.Click();
            LanguageTextbox.SendKeys(Language);

            //Select Language level from Dropdown List
            chooseLevelDropdown.Click();
            Thread.Sleep(3000);
            driver.FindElement(By.XPath("//*[@value='\" + Level + \"']")).Click();

            //click on save Button
            AddButton.Click();
            Thread.Sleep(4000);

        }

        public void EditLanguageRecord(string oldLanguage, string newLanguage, string oldLevel, string newLevel)
        {
            //click edit pencilIcon for the existing record
            Thread.Sleep(1000);
            EditpencilIcon.Click();

            if (newLanguage.Length >0)
            {
                EditLanguageTextbox.SendKeys(newLanguage);
                Thread.Sleep(4000);
            }
            if (newLevel.Length > 0)
            { 
                EditChooselevelDropdown.Click ();
                Thread.Sleep(4000);

                IWebElement EditChooselevelOption = driver.FindElement(By.XPath("//*[@value='\" + newLevel + \"']"));
                EditChooseLevelOption.Click();
            }
            UpdateButton.Click ();
            Thread.Sleep(4000);
        }

        public void DeleteLanguageRecord(String newLanguage)
        {
            LastDeleteIcon.Click();
        }

        public void CreateLanguageRecord(object english, object basic)
        {
            throw new NotImplementedException();
        }

        internal void CreateLanguageRecord(string english, object basic)
        {
            throw new NotImplementedException();
        }
    }
}




     