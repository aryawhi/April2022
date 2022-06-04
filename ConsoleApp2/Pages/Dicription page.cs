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
    internal class Dicription_page
    {
        When (@"User filled the Discription details and saved")


        [Then(@"The Description details should be added successfully\.")]
        public void ThenTheDescriptionDetailsShouldBeAddedSuccessfully_(IWebDriver driver)
        {
            IWebElement Description = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/div/div/form/div/div/div[1]/h3"));
            Assert.True(Description.Displayed);

        }
        public void WhenUserFilledTheDiscriptionDetailsAndSaved(IWebDriver driver)

        {

            // Identify Desription //
            IWebElement Description = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/div/div/div/h3"));
            Description.Click();

            // Navigate to Description Textbox //
            IWebElement Description_Textbox = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/div/div/form/div/div/div[1]/div"));
            Description_Textbox.Clear();
            Description_Textbox.SendKeys("ILovedancing,cooking,singing");
            driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/div/div/form/div/div/div[2]/button")).Click();

        }

    }
}
