using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Pages
{
    internal class Log_in_page
    {

        public void GivenLoggedInToMarsLogoHomePage(IWebDriver driver)

        {

            driver.FindElement(By.XPath("//*[@id='home'']//a[Contains](.,'Sign In')]")).Click();
            // Identify username //
            IWebElement username = driver.FindElement(By.Name("email"));
            username.SendKeys("srilaxmikamalapur@gmail.com");
            // Identify password //
            IWebElement password = driver.FindElement(By.Name("password"));
            password.SendKeys("docker256");
            // click on login button //
            IWebElement Loginbutton = driver.FindElement(By.XPath("//button[contain(.,'login')]"));
            Loginbutton.Click();
            // login to mars logo //
            IWebElement marsLogo = driver.FindElement(By.XPath("//*[@id='ccount-profile-section']/div/div[1]/a"));
            Assert.True(marsLogo.Displayed);

        }

    }
}
