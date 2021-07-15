using MarcTaskSecond.util;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace MarcTaskSecond.Pages
{
    class ChangePasswordPage
    {
        public ChangePasswordPage()
        {

            PageFactory.InitElements(CommonDriver.driver, this);
        }


        [FindsBy(How = How.XPath, Using = "//body/div[@id='account-profile-section']/div[1]/div[1]/div[2]/div[1]/span[1]")]
        private IWebElement ProfileName { get; set; }
        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Change Password')]")]
        private IWebElement ChangePass { get; set; }
        [FindsBy(How = How.XPath, Using = "//body/div[4]/div[1]/div[2]/form[1]/div[1]/input[1]")]
        private IWebElement CurrentPass { get; set; }
        [FindsBy(How = How.XPath, Using = "//body/div[4]/div[1]/div[2]/form[1]/div[2]/input[1]")]
        private IWebElement NewPass { get; set; }
        [FindsBy(How = How.XPath, Using = "//body/div[4]/div[1]/div[2]/form[1]/div[3]/input[1]")]
        private IWebElement ConfirmPass { get; set; }
        [FindsBy(How = How.XPath, Using = "//body/div[4]/div[1]/div[2]/form[1]/div[4]/button[1]")]
        private IWebElement SavePassword { get; set; }


        public void ChangePassword(IWebDriver driver)
        {
            ProfileName.Click();
            Thread.Sleep(2000);
            ChangePass.Click();
            Thread.Sleep(5000);
            CurrentPass.SendKeys("123456");
            NewPass.SendKeys("1231234");
            ConfirmPass.SendKeys("1231234");
            SavePassword.Click();

        }
    }
}
