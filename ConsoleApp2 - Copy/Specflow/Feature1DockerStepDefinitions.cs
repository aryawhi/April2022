using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace ConsoleApp2
{
    [Binding]
    public class Feature1DockerStepDefinitions
    {
        IWebDriver driver;

        [Given(@"Logged in to Mars Logo home")]
        public void GivenLoggedInToMarsLogoHomePage()
        {
            driver.Navigate().GoToUrl("http://localhost:5000/Home");
            driver.Manage().Window.Size = new System.Drawing.Size(1050, 708);
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

