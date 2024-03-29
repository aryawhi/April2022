﻿using OpenQA.Selenium;
using SeleniumNUnit.Global;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static SeleniumNUnit.Global.GlobalDefinitions;

namespace SeleniumNUnit.Pages
{
    internal class SignUp
    {
        #region  Initialize Web Elements 
        //Finding the Join 
        private IWebElement Join => driver.FindElement(By.XPath("//button[@class='ui green basic button']"));

        //Identify FirstName Textbox
        private IWebElement FirstName => driver.FindElement(By.Name("firstName"));

        //Identify LastName Textbox
        private IWebElement LastName => driver.FindElement(By.Name("lastName"));

        //Identify Email Textbox
        private IWebElement Email => driver.FindElement(By.Name("email"));

        //Identify Password Textbox
        private IWebElement Password => driver.FindElement(By.XPath("//input[@name='password']"));

        //Identify Confirm Password Textbox
        private IWebElement ConfirmPassword => driver.FindElement(By.XPath("//input[@name='confirmPassword']"));

        //Identify Term and Conditions Checkbox
        private IWebElement Checkbox => driver.FindElement(By.XPath("//input[@type='checkbox']"));

        //Identify join button
        private IWebElement JoinBtn => driver.FindElement(By.Id("submit-btn"));
        #endregion

        internal void Register()
        {
            //Populate the excel data
            ExcelLib.PopulateInCollection(Base.ExcelPath, "SignUp");

            //Click on Join button
            Join.Click();

            //Enter FirstName
            FirstName.SendKeys(ExcelLib.ReadData(2, "FirstName"));

            //Enter LastName
            LastName.SendKeys(ExcelLib.ReadData(2, "LastName"));

            //Enter Email
            Email.SendKeys(ExcelLib.ReadData(2, "Email"));

            //Enter Password
            Password.SendKeys(ExcelLib.ReadData(2, "Password"));

            //Enter Password again to confirm
            ConfirmPassword.SendKeys(ExcelLib.ReadData(2, "ConfirmPswd"));

            //Click on Checkbox
            Checkbox.Click();

            //Click on join button to Sign Up
            JoinBtn.Click();
        }
    }
}
