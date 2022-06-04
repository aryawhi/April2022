using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Pages
{
    internal class Home_page
        public void Browser (IWebDriver driver)
    {
            ChromeOptions chromeOptions = new ChromeOptions();


             //Open Chrome and acceptall the SSL Cerificates
             chromeOptions.AddArguments("Ignore-cartificate-errors");
             ChromeDriver chromeDriver = new ChromeDriver(chromeOptions);
             driver.Navigate().GoToUrl("http://localhost:5000/");
             driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

    
      
        }




}
}
