﻿using MarcTaskSecond.util;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;


namespace MarcTaskSecond.Pages
{
    class LoginPage
    {
        public LoginPage()
        {

            PageFactory.InitElements(CommonDriver.driver, this);
        }
        //Finding the Sign Link
        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Sign')]")]
        private IWebElement SignIntab { get; set; }

        // Finding the Email Field
        [FindsBy(How = How.Name, Using = "email")]
        private IWebElement EmailAddress { get; set; }

        //Finding the Password Field
        [FindsBy(How = How.Name, Using = "password")]
        private IWebElement Password { get; set; }

        //Finding the Password Field
        [FindsBy(How = How.Name, Using = "rememberDetails")]
        private IWebElement RememberMe { get; set; }

        //Finding the Login Button
        [FindsBy(How = How.XPath, Using = "//button[contains(text(),'Login')]")]
        private IWebElement LoginBtn { get; set; }

        // [FindsBy(How = How.XPath, Using = "//*[@id='account-profile-section']/div/div[1]/div[2]/div/a[2]/button")]
        // private IWebElement LogOut { get; set; }

        //Read Excel value
        private string emailAddress = ExcelLib.ReadData(1, "EmailAddress");
        private string password = ExcelLib.ReadData(1, "Password");


        public void LoginSteps(IWebDriver driver)
        {
            SignIntab.Click();
            EmailAddress.SendKeys(emailAddress);
            Password.SendKeys(password);
            RememberMe.Click();
            LoginBtn.Click();
          
        }

        
    }
}
