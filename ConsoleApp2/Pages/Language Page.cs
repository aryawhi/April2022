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
    internal class Language_Page
    {
        public void WhenUserFilledThelanguageDetailsAndSaved(IWebDriver driver)

        {
            // Identify Languages //

            IWebElement language = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[1]/a[1]"));
            language.Click();
            driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[1]/div[1]"));
            // Navigate to Language Textbox//
            IWebElement language_Textbox = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[1]/input"));
            language_Textbox.SendKeys("English");
            SelectOptionByValue(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select"), "Fluent");
            driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[3]/input[1]")).Click();

            [Then(@"The Language details should be added successfully\.")]
            public void ThenTheLanguageDetailsShouldBeAddedSuccessfully (IWebDriver driver)
            {
                IWebElement language = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[div/div/div/div[3]/form/div[1]/a[1]"));
                Assert.True(language.Displayed);

            }

        

    }
}
