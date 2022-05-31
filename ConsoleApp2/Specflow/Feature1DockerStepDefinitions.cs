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
        private static IWebDriver driver;

        [BeforeScenario]
        public void Browser()
        {
            ChromeOptions chromeOptions = new ChromeOptions();

            //Open Chrome and acceptall the SSL Cerificates
            chromeOptions.AddArguments("Ignore-cartificate-errors");
            ChromeDriver chromeDriver = new ChromeDriver(chromeOptions);
            driver.Navigate().GoToUrl("http://localhost:5000/");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

        }

        [Given(@"Logged in to Mars Logo home")]
        public void GivenLoggedInToMarsLogoHomePage()
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

        [When(@"Navigate to Mars Logo profile")]
        public void WhenNavigateToMarsLogoProfile()
        {
            // Navigate to profile //
            IWebElement profile = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[1]/div/a[2]"));
            profile.Click();

        }

        [When(@"User filled the language details and saved")]
        public void WhenUserFilledThelanguageDetailsAndSaved()

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

        }

        [Then(@"The Language details should be added successfully\.")]
        public void ThenTheLanguageDetailsShouldBeAddedSuccessfully_()
        {
            IWebElement language = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[1]/a[1]"));
            Assert.True(language.Displayed);
        }


        [When(@"User filled the skills details and saved.")]

        public void WhenUserFilledTHESkillsDetailsAndSaved()

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

        public void ThenTheSkillsDetailsShouldBeAddedSuccessfully()

        {

            IWebElement skills = driver.FindElement(By.XPath("//*[@id='account-profile-section'/div/section[2]/div/div/div/div[3]/form/div[1]/a[2])"));
            Assert.True(skills.Displayed);
        }

        [When(@"User filled the Discription details and saved")]


        [Then(@"The Description details should be added successfully\.")]
        public void ThenTheDescriptionDetailsShouldBeAddedSuccessfully_()
        {
            IWebElement Description = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/div/div/form/div/div/div[1]/h3"));
            Assert.True(Description.Displayed);

        }
        public void WhenUserFilledTheDiscriptionDetailsAndSaved()

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

        internal void SelectOptionByText(By identifiers, string text)
        {
            SelectElement select = new SelectElement(driver.FindElement(identifiers));
            Thread.Sleep(1000);
            select.SelectByText(text);
        }

        internal void SelectOptionByValue(By identifier, string text)

        {

            SelectElement select = new SelectElement(driver.FindElement(identifier));
            Thread.Sleep(1000);
            select.SelectByValue(text);

        }


    }

































}

