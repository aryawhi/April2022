using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mars_QA2___Selenium.Pages
{
 
        internal class Homepage
        {
            [FindsBy(How = How.XPath, Using = "//*[@id='home']/div/div/div[1]/div/a")]
            public IWebElement signInButton { get; set; }

        }
    }
















    



    
