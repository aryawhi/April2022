using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace ConsoleApp2.Pages
{
    internal class Skills_Page
    {
        public void WhenUserFilledTHESkillsDetailsAndSaved(IWebDriver driver)

        {  // Identify Skills //
            IWebElement Skills = driver.FindElement(By.XPath("//*[@id='ccount-profile-section']/div/section[2]/div/div/div/div[3]/form/div[1]/a[2]"));
            Skills.Click();
            driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[1]")).Click();
            //Navigate to Skills Textbox//
            IWebElement Skills_Textbox = driver.FindElement(By.XPath("//*[@id='account-profile-section'']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[1]/input"));
            Skills_Textbox.Clear();
            Skills_Textbox.SendKeys("Typing");
            SelectOptionByValue(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[2]/select"), "Expert");
            driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/span/input[1]")).Click();

        }

     

        [Then(@"The Skills details should be added successfully\.")]

        public void ThenTheSkillsDetailsShouldBeAddedSuccessfully(IWebDriver driver)

        {

            IWebElement skills = driver.FindElement(By.XPath("//*[@id='account-profile-section'/div/section[2]/div/div/div/div[3]/form/div[1]/a[2])"));
            Assert.True(skills.Displayed);
        }

    }
}
