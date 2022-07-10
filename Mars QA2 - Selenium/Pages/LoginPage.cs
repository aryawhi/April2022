using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mars_QA2___Selenium.Pages
{
    internal class LoginPage
    {

        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div/div/div[1]/div/div[1]/input")]
        public IWebElement emailAddress { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div/div/div[1]/div/div[2]/input")]
        public IWebElement passWord { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div/div/div[1]/div/div[4]/button")]
        public IWebElement loginButton { get; set; }

        public void Loginsteps()
        {
            emailAddress.SendKeys("kamalapursrilaxmi@gmail.com");
            passWord.SendKeys("docker256");
            loginButton.Click();
        }
    }
}

