using NUnit.Framework;
using OpenQA.Selenium;
using SpecFlowMars.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowProjectMars2.Pages
{
    public class LoginPage : CommonDriver
    {

        public LoginPage()
        {

        }
        public LoginPage(IWebDriver driver) : base(driver)
        {

        }

        //Web Elements

        public IWebElement SignInButton => driver.FindElement(By.XPath("//*[contains(text(),\"Sign\")]"));
        public IWebElement EmailAddressTextbox => driver.FindElement(By.XPath("//input[@Placeholder='Email address']"));
        public IWebElement PasswordTextbox => driver.FindElement(By.XPath("//input[@Placeholder='Password']"));
        public IWebElement LoginButton => driver.FindElement(By.XPath("//button[contains(text(),'Login')]"));

        //Method
        public void LoginSteps()
        {
            driver.Navigate().GoToUrl("http://localhost:5000");
            try
            {
                //Identify Sign in button
                SignInButton.Click();
            }
            catch
            {
                Assert.Fail("MARS portal hasn't launched., {ex.Message}");
            }

            //Identify the EmailAddressTextbox and enter a valid Username
            EmailAddressTextbox.SendKeys("rsrilatha05@gmail.com");

            //Identify password textbox and enter a valid passsword

            PasswordTextbox.SendKeys("Venky@123");

            //Click on Login Button
            LoginButton.Click();
            Thread.Sleep(2000);
        }
    }
}