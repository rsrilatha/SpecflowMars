using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Interactions;
using System.Security.Cryptography.X509Certificates;

namespace SpecFlowMars.Utilities
{
    public class CommonDriver
    {
        public IWebDriver driver;
        public CommonDriver()
        {


        }
        public CommonDriver(IWebDriver driver)
        {
            this.driver = driver;
        }
        public IWebDriver Initialize()
        {
            driver = new ChromeDriver();
            return driver;
        }

        internal IWebDriver getDriver()
        {
            return driver;
        }
        public void GoToSkillsTab()
        {
            IWebElement skillsTab = driver.FindElement(By.XPath("//a[@data-tab='second']"));
            skillsTab.Click();
        }

        public Boolean verifyLogin()
        {
            Console.WriteLine(driver.Url);
            if (driver.Url != "http://localhost:5000/Home" && driver.Url != "data:,")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
