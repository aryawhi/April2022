using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace Sri2022
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // open chrome browser
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            // launch turnup portal
            driver.Navigate().GoToUrl("http://horse.industryconnect.io/Account/Login?ReturnUrl=%2f");

            // identify username textboxand enter valid username
            IWebElement usernameTextbox = driver.FindElement(By.Id("UserName"));
            usernameTextbox.SendKeys("hari");

            // identify password textboxand enter valid password
            IWebElement passwordtextbox = driver.FindElement(By.Id("Password"));
            passwordtextbox.SendKeys("123123");

            // click on login button
            IWebElement loginbutton = driver.FindElement(By.XPath("//*[@id='loginForm']/form/div[3]/input[1]"));
            loginbutton.Click();

            // check if user is logged in successfully
            System.Threading.Thread.Sleep(2000);
             IWebElement helloHari = driver.FindElement(By.XPath("//*[@id='logoutForm']/ul/li/a"));
            
            
             //System.Threading.Thread.Sleep(2000);
            //IWebElement hellohari = driver.FindElement(By.XPath("//*[@id='logoutForm']/ul/li/a"));

            if (helloHari.Text == "Hello hari!")

                Console.WriteLine("Logged in successfully, test passed.");

            else

                Console.WriteLine("Login failed, test failed123");
                

        }
    }       
}
